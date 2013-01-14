-- =============================================
-- Author:		Michael Secord
-- Create date: 12/5/2012
-- Description:	A script to find an column in a table, a table, or a combination of both.
-- =============================================

BEGIN TRAN

declare @ShowColumns int         = 1
declare @TableName nvarchar(50)  = '%'
declare @ColumnName nvarchar(50) = '%InventoryBatchNid%'
select distinct Table_Catalog 'Database', Table_Name 'Table'
  ,case when @ShowColumns = 0 then (select cast(count(C.Column_Name) as nvarchar(5)) from Information_Schema.Columns as C
        where Table_Name = I.Table_Name and Column_Name like @ColumnName) else Column_Name end 'Column'
  ,case when @ShowColumns = 0 then '' else
   case when Character_Maximum_Length is not null then Data_Type + ' (' + cast(Character_Maximum_Length as nvarchar(10)) + ')'
        when Numeric_Precision is not null and Data_Type <> 'image' then Data_Type + ' (' + cast(Numeric_Precision as nvarchar(10)) + ')'
        else Data_Type end end 'DataType'
  ,case when @ShowColumns = 0 then '' else
   case when ColumnProperty(Object_ID(Table_Name), Column_Name, 'AllowsNull') = 1 then 'Yes' else 'No' end end 'Nullable'
  ,case when @ShowColumns = 0 then '' else
   case when ColumnProperty(Object_ID(Table_Name), Column_Name, 'IsComputed') = 1 then 'Computed'
        when ColumnProperty(Object_ID(Table_Name), Column_Name, 'IsIdentity') = 1 then 'Identity' else Column_Default end end 'Default'
  ,case when @ShowColumns = 0 then '' else C.Definition end 'Expression'
from Information_Schema.Columns as I left join Sys.Computed_Columns as C on C.Object_ID = Object_ID(Table_Name) and C.Name = Column_Name
where Table_Name like @TableName and Column_Name like @ColumnName and Table_Name not like '[AZ]Log%' --and Table_Name not like 'Legacy%'
order by Table_Catalog, Table_Name


ROLLBACK TRAN