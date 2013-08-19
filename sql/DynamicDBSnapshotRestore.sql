-- =============================================
-- Author:		Alex Host & Michael Secord
-- Create date: 01/30/2013
-- Description:	Dynamic DB Snapshot and Restore Script.
-- Version:		1.7
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
		
		/*--- This can be left alone unless you need to debug ---*/
		/*--- 1=Run 0=Preview Script ---*/
		,@Run INT = 1

/*--- Here's where we do the magic. No need to change anything below here ---*/
--#region This is where the magic SQL lives
DECLARE @Server INT = CASE WHEN @@SERVERNAME = 'VMCUSTOMERS' THEN 1 WHEN @@SERVERNAME = 'VMSQL11' THEN 2 WHEN @@SERVERNAME = 'VMMANHATTAN' THEN 3 WHEN @@SERVERNAME = 'VMTAYLOR' THEN 4 WHEN @@SERVERNAME = 'VMANDREWS' THEN 1 WHEN @@SERVERNAME = 'VMCOKECUSTOMERS' THEN 3 ELSE 1 END
DECLARE @Drive NVARCHAR(1) = CASE WHEN @Server IN (1,4) THEN 'D' WHEN @Server = 2 THEN 'E' WHEN @Server = 3 THEN 'C' END
DECLARE @SQL NVARCHAR(MAX) = CASE WHEN @HHDays = -1 THEN '' ELSE 'USE ' + @Database + ';' + CHAR(10)+CHAR(13) + 'DELETE FROM dbo.HandheldLog WHERE DATEDIFF(D,TimeStamp,GETDATE()) > ' + CAST(@HHDays AS NVARCHAR) + CHAR(10)+CHAR(13) END +
CASE 
WHEN @CreateOrRestore = 1 THEN
      'USE MASTER;' + CHAR(10)+CHAR(13) +
	  'DBCC SHRINKDATABASE (' + @Database + ',5)' +
      'CREATE DATABASE Snapshot_' + @Database + '' + CHAR(10)+CHAR(13) +
      'ON     (NAME = N''PrimaryFile'', FILENAME = ''' + @Drive + ':\DB\Primary_Snapshot_'   + @Database + '.ss'')' + CHAR(10)+CHAR(13) +
              ',(NAME = N''BlobsFile'', FILENAME = ''' + @Drive + ':\DB\Blobs_Snapshot_'     + @Database + '.ss'')' + CHAR(10)+CHAR(13) +
              ',(NAME = N''InventoryFile'', FILENAME = ''' + @Drive + ':\DB\Inventory_Snapshot_' + @Database + '.ss'')' + CHAR(10)+CHAR(13) +
              ',(NAME = N''OrdersFile'', FILENAME = ''' + @Drive + ':\DB\Orders_Snapshot_'    + @Database + '.ss'')' + CHAR(10)+CHAR(13) + CASE WHEN @Server <> 4 THEN ' ' WHEN @Server = 4 THEN ',(NAME = N''SSD1File'', FILENAME = ''' + @Drive + ':\DB\SSD1_Snapshot_'+ @Database + '.ss'')' + CHAR(10)+CHAR(13) ELSE ' ' END +
      'AS SNAPSHOT OF ' + @Database
WHEN @CreateOrRestore = 2 THEN
      'USE MASTER' + CHAR(10)+CHAR(13) +
      'ALTER DATABASE '   + @Database + ' SET SINGLE_USER WITH ROLLBACK IMMEDIATE' + CHAR(10)+CHAR(13) +
      'RESTORE DATABASE ' + @Database + ' FROM DATABASE_SNAPSHOT = ''Snapshot_' + @Database + ''';' + CHAR(10)+CHAR(13) +
      'ALTER DATABASE '   + @Database + ' SET MULTI_USER'
END
DECLARE @DC NVARCHAR(150) = CASE WHEN @Database like 'Ozarks%' THEN 'USE ' + @Database + ' UPDATE dbo.LedgerSetup SET DirectConnectServerName = ''VMGPOZARKS''' ELSE '' END

IF @Run = 1
EXEC(@SQL)
ELSE
SELECT @SQL

IF @Run = 1
EXEC ('USE ' + @Database + ' UPDATE dbo.LedgerSetup SET UseDirectConnect = 0')
ELSE
SELECT ('USE ' + @Database + ' UPDATE dbo.LedgerSetup SET UseDirectConnect = 0')

IF @Run = 1
EXEC (@DC)
ELSE
SELECT @DC
--#endregion

-- =============================================
/*				RELEASE NOTES
v1.7 - 08/15/2013 - MS
* Added option to trim HH logs (deleting from dbo.HandheldLog only)
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