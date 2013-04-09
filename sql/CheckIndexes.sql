BEGIN TRAN

SELECT 
	sys.name 'Index Name'
	,sch.name + '.' + obj.name 'Belongs to table'
	,stat.Index_Type_Desc
	,stat.Avg_Fragmentation_In_Percent
FROM 
	sys.dm_db_Index_Physical_Stats (DB_ID(DB_NAME()),NULL,NULL,NULL,NULL) AS stat JOIN sys.indexes AS sys ON stat.Index_Id = sys.Index_Id AND stat.Object_id = sys.Object_id
	JOIN sys.objects AS obj ON obj.Object_id = sys.Object_id
	JOIN sys.schemas AS sch ON obj.schema_id = sch.schema_id
WHERE 
	Avg_Fragmentation_In_Percent > 30.00
	AND sys.Name IS NOT NULL
ORDER BY 
	stat.Avg_Fragmentation_In_Percent DESC


ROLLBACK TRAN