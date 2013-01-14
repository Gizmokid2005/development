BEGIN TRAN

DECLARE @command varchar(1000) = '
    USE ?
    insert into #Results (ServerName,RecName,RecKey,SqlQuery)
    (select  DB_NAME() as DatabaseName
            ,RecName
            ,RecKey
            ,SqlQuery
	from reports
	where IsSqlQuery = 1 and RecName like ''%Settlement%'')'
create table #Results(ServerName nvarchar(30),RecName nvarchar(100),RecKey nvarchar(15),SqlQuery nvarchar(max))
EXEC sp_MSforeachdb @command
select 
	* 
from 
	#Results as r 
where 	
	((r.ServerName not like 'snapshot%' and r.ServerName not like 'ss_%') 
	/*and (	r.ServerName like 'AHD%' or 
			r.ServerName like 'Alfa%' or 
			r.ServerName like 'Anderson2012%' or 
			r.ServerName like 'BnB%' or 
			r.ServerName like 'Chas%' or 
			r.ServerName like 'Hayes%' or 
			r.ServerName like 'Hop%' or 
			r.ServerName like 'Modern%' or 
			r.ServerName like 'Vintage%' or 
			r.ServerName like 'Windy%'
		)*/)
		
order by r.ServerName
drop table #Results


ROLLBACK TRAN