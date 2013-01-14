SET ARITHABORT ON
SET QUOTED_IDENTIFIER ON
 DECLARE @Table VARCHAR(255)  
 DECLARE @cmd NVARCHAR(500)  
 DECLARE TableCursor CURSOR FOR 
   Select obj.name
   From sys.dm_db_Index_Physical_Stats (db_id(db_name()),null,null,null,null)
   as stat join sys.indexes as sys on stat.Index_Id = sys.Index_Id and stat.Object_id = sys.Object_id
   join sys.objects as obj on obj.Object_id = sys.Object_id
   Where Avg_Fragmentation_In_Percent > 10.00
   and sys.Name is not null
   group by obj.name
 OPEN TableCursor   
  FETCH NEXT FROM TableCursor INTO @Table   
  WHILE @@FETCH_STATUS = 0   
   BEGIN   
      SET @cmd = 'ALTER INDEX ALL ON ' + @Table + ' REBUILD'  
      EXEC (@cmd)  
      FETCH NEXT FROM TableCursor INTO @Table   
   END   
  CLOSE TableCursor   
  DEALLOCATE TableCursor  