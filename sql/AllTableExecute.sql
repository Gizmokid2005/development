begin tran

create table #Tables (ServerName nvarchar(30), Lines int)
exec sp_msForEachDB 
    'use ?
     if object_id(''FleetLoaderExportLog'') is not null 
     insert into #Tables (ServerName, Lines)
     (select db_name(), count(*) from dbo.FleetLoaderExportLog)'
select * from #Tables where ServerName not like 'Snapshot%' order by ServerName
drop table #Tables

rollback