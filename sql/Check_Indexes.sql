BEGIN TRAN

Select sys.name 'Index Name'
   ,obj.name 'Belongs to table'
   ,stat.Index_Type_Desc
   ,stat.Avg_Fragmentation_In_Percent
From sys.dm_db_Index_Physical_Stats (db_id(db_name()),null,null,null,null)
   as stat join sys.indexes as sys on stat.Index_Id = sys.Index_Id and stat.Object_id = sys.Object_id
   join sys.objects as obj on obj.Object_id = sys.Object_id
Where Avg_Fragmentation_In_Percent > 30.00
   and sys.Name is not null
Order by stat.Avg_Fragmentation_In_Percent Desc


ROLLBACK TRAN