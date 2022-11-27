--EXEC spr_fetch_TableQuery 'LAPTOP-NI0AKHN4','AdventureWorks2019','Person.Address'

CREATE PROC [dbo].[spr_fetch_TableQuery] (@Linkedserver varchar(max),@DBName varchar(max),@TableName varchar(max))
AS
BEGIN
print ('SELECT 

CASE WHEN ORDINAL_POSITION=1 THEN

''SELECT  ''+ ''[''+COLUMN_NAME+'']''

ELSE
''[''+COLUMN_NAME+'']'' 
END

ColumnName

FROM ['+@Linkedserver+'].['+@DBName+'].INFORMATION_SCHEMA.COLUMNS
where TABLE_SCHEMA+''.''+TABLE_NAME='''+@TableName+'''
ORDER BY ORDINAL_POSITION
')

END