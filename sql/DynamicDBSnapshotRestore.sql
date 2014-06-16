-- =============================================
-- Author:      Alex Host & Michael Secord
-- Create date: 01/30/2013
-- Last update: 06/16/2014
-- Description: Dynamic DB Snapshot and Restore Script.
-- Version:     1.20
-- =============================================

USE master;
DECLARE 
        /*--- Database name ---*/
        @Database NVARCHAR(50) = 'DBName'
        
        /*--- What to do? ---*/
        /*--- 1=Create 2=Restore ---*/
        ,@CreateOrRestore INT = 1

        /*--- Number of days to keep HH logs ---*/
        /*--- -1=Keep all logs ---*/
        /*--- (WARNING: THIS COULD ADD SIGNIFICANT SNAPSHOT CREATION TIME) ---*/
        ,@HHDays INT = -1

        /*--- Shrink DB? ---*/
        /*--- 1=Yes; 0=No ---*/
        ,@Shrink BIT = 1
        
        /*--- This can be left alone unless you need to debug ---*/
        /*--- 1=Run 0=Preview Script ---*/
        ,@Run BIT = 1

        /*--- This is to override automatic snapshot drive handling. ---*/
        /*--- Script assumes localhost will have two drives and snapshot to D: ----*/
        ,@Override NVARCHAR(1) = NULL

        /*--- Single User Mode ---*/
        /*--- Defaults to off (0). 1=On ---*/
        ,@SU BIT = 0

/*--- Here's where we do the magic. No need to change anything below here ---*/
--#region This is where the magic SQL lives
DECLARE @Server INT = CASE WHEN @@SERVERNAME = 'VMCUSTOMERS' OR @@SERVERNAME = 'VMANDREWS' THEN 1 WHEN @@SERVERNAME = 'VMSQL11' THEN 2 WHEN @@SERVERNAME = 'VMMANHATTAN' OR @@SERVERNAME = 'VMCOKECUSTOMERS' OR @@SERVERNAME = 'VMTAYLOR' OR @@SERVERNAME = 'VMCUSTOMERS2' THEN 3 WHEN @Override IS NOT NULL THEN 0 ELSE 1 END
DECLARE @Drive NVARCHAR(1) = CASE WHEN @Server IN (1) THEN 'D' WHEN @Server IN (2) THEN 'E' WHEN @Server IN (3) THEN 'C' WHEN @Server IN (0) THEN @Override END
DECLARE @SQL NVARCHAR(MAX) = CASE WHEN @HHDays = -1 THEN '' ELSE 'USE [' + @Database + '];' + CHAR(10)+CHAR(13) + 'DELETE FROM dbo.HandheldLog WHERE DATEDIFF(D,TimeStamp,GETDATE()) > ' + CAST(@HHDays AS NVARCHAR) + CHAR(10)+CHAR(13) END +
CASE 
WHEN @CreateOrRestore = 1 THEN
    'USE MASTER;
    ' + CASE WHEN @SU = 1 THEN 'ALTER DATABASE [' + @Database + '] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;' ELSE '' END + '
    USE [' + @Database + '] UPDATE dbo.LedgerSetup SET UseDirectConnect = 0;
    USE [' + @Database + ']; IF EXISTS (SELECT t.name FROM sys.tables as t WHERE t.name = ''PalletizationMasterControl'') UPDATE dbo.PalletizationMasterControl SET BlackBoxHostname = ''VMDEV'', BlackBoxPort = ''20202'';
    IF (SELECT COMPATIBILITY_LEVEL FROM SYS.DATABASES WHERE NAME=''[' + @Database + ']'') < 100 BEGIN ALTER DATABASE [' + @Database + '] SET COMPATIBILITY_LEVEL = 100 END;
    DELETE FROM [' + @Database + '].dbo.ConcurrencyTokens;
    ' + CASE WHEN @Database LIKE 'Ozarks%' THEN 'USE [' + @Database + '] UPDATE dbo.LedgerSetup SET DirectConnectServerName = ''VMGPOZARKS'';' ELSE '' END 
    + CASE WHEN @Shrink = 1 THEN CHAR(10) + CHAR(9) + 'DBCC SHRINKDATABASE ([' + @Database + '],5)' ELSE '' END + '
    CREATE DATABASE [Snapshot_' + @Database + ']
    ON     (NAME = N''PrimaryFile'', FILENAME = ''' + @Drive + ':\DB\' + @Database + 'Primary_Snapshot_.ss'')
           ,(NAME = N''BlobsFile'', FILENAME = ''' + @Drive + ':\DB\' + @Database + 'Blobs_Snapshot_.ss'')
           ,(NAME = N''InventoryFile'', FILENAME = ''' + @Drive + ':\DB\' + @Database + 'Inventory_Snapshot_.ss'')
           ,(NAME = N''OrdersFile'', FILENAME = ''' + @Drive + ':\DB\' + @Database + 'Orders_Snapshot_.ss'')' + CASE WHEN @Server <> 4 THEN ' ' WHEN @Server = 4 THEN + CHAR(10) + ',(NAME = N''SSD1File'', FILENAME = ''' + @Drive + ':\DB\'+ @Database + 'SSD1_Snapshot_.ss'')' + CHAR(10) ELSE ' ' END +
      'AS SNAPSHOT OF [' + @Database + '];
    ' + CASE WHEN @SU = 1 THEN 'ALTER DATABASE [' + @Database + '] SET MULTI_USER;' ELSE '' END
WHEN @CreateOrRestore = 2 THEN
    'USE MASTER;
    ' + CASE WHEN @SU = 1 THEN 'ALTER DATABASE [' + @Database + '] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;' ELSE '' END + '
    RESTORE DATABASE [' + @Database + '] FROM DATABASE_SNAPSHOT = ''Snapshot_' + @Database + ''';
    ' + CASE WHEN @SU = 1 THEN 'ALTER DATABASE [' + @Database + '] SET MULTI_USER;' ELSE '' END
END

IF @Run = 1
EXEC(@SQL)
ELSE
SELECT @SQL
--#endregion

-- =============================================
/*                RELEASE NOTES
v1.20 - 06/16/14 - MS
* Changed the filename format for the snapshot files. Database name is now first. (Should have no operational impact).
-----
v1.19 - 01/30/14 - MS
* Updated to disable single-user mode by default.
-----
v1.18 - 01/09/14 - MS
* Changed the BlackBox port to 20202.
------
v1.17 - 12/13/13 - MS
* Cleaned up the SQL a bit more to consolidate how certain updates were running (all DB "fixes" now run prior to snapshot).
-----
v1.16 - 12/03/13 - MS
* Now we check if tables exist before trying to delete from them.
-----
v1.15 - 11/27/13 - MS
* Properly terminated statements to ensure everything processes in order.
-----
v1.14 - 11/20/13 - MS
* Add support for VMCUSTOMERS2
-----
v1.13 - 11/14/13 - MS
* Added bit for DBCC Shrink.
* We now set BlackBox to our VMDEV instance on snapshot.
* Cleaned up some of the magic.
-----
v1.12 - 11/04/2013 - MS
* Added support for snapshot drive override.
* Cleaned up drive setup for VMTaylor.
-----
v1.11 - 10/18/2013 - AH & MS
* Always clear concurrency locks before creating the snapshot.
* Always force the database into 2008+ compatibility to ensure WMS works.
* Cleaned up magic SQL.
* Added updated date to header.
-----
v1.10 - 10/10/2013 - MS
* Updated the restore section properly. *sigh*
-----
v1.9 - 10/09/2013 - AH/MS
* Updated so databases with hyphens will work in this script as well.
-----
v1.8 - 09/23/2013 - MS
* Added Single user mode during snapshot creation process.
-----
v1.7 - 08/15/2013 - MS
* Added option to trim HH logs (deleting from dbo.HandheldLog only).
* Added safeguard to change Ozarks' GP server to local copy instead of live.
-----
v1.6 - 07/12/2013 - MS
* Added DB Shrink to 5% to help decrease space requirements.
-----
v1.5 - 04/18/2013 - MS
* Added support for VMCOKECUSTOMERS server.
-----
v1.4 - 02/15/2013 - MS
* Added GP Direct connect disable during the restore process.
-----
v1.3 - 01/30/2013 - AH
* Added Use Master to prevent the script locking the database.
-----
v1.2 - 12/27/2012 - MS
* Fixed another issue with Restore. "GO" Isn't allowed in an exec. - Thanks Steven G
-----
v1.1 - 12/27/2012 - MS
* Fixed issue on line 31 - looking for the wrong INT to restore.
* Fixed quote issue on line 34 - Thanks Steven G!
* Added version to header.
-----
v1.0 - 12/19/2012 - MS
* Added multi-server support
* Preview mode
* Additional comments
-----
V0.9 – 11/26/2012 - AH/MS
* Limited release beta version
*/
-- =============================================
