SET ARITHABORT ON
SET QUOTED_IDENTIFIER ON
DECLARE @Table VARCHAR(255)
DECLARE @cmd NVARCHAR(500)
DECLARE TableCursor CURSOR FOR
	SELECT
		sch.name + '.' + obj.name AS 'name'
	FROM
		sys.dm_db_Index_Physical_Stats (DB_ID(DB_NAME()),NULL,NULL,NULL,NULL) AS stat
		JOIN sys.indexes AS sys ON stat.Index_Id = sys.Index_Id AND stat.Object_id = sys.Object_id
		JOIN sys.objects AS obj ON obj.Object_id = sys.Object_id
		JOIN sys.schemas AS sch ON obj.schema_id = sch.schema_id
	WHERE
		Avg_Fragmentation_In_Percent > 10.00
		AND sys.Name IS NOT NULL
	GROUP BY
		obj.name
		,sch.name
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