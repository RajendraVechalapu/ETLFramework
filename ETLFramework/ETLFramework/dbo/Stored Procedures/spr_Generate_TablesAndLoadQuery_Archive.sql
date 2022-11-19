create Procedure [dbo].[spr_Generate_TablesAndLoadQuery_Archive]
as
begin
DECLARE @SourceServer varchar(max)='[AdventureWorks2019]'
DECLARE @SourceTable varchar(max)='[Person].[Address]'
--DECLARE @TargetTable varchar(max)='[Person].[LandingAddress]' -- Landing
DECLARE @TargetTable varchar(max)='[Person].[Address]' -- Main

--EXEC generateTable  @SourceServer,@SourceTable,@LandingTargetTable


--ALTER proc generateTable(@SourceServer varchar(max),@SourceTable varchar(max),@TargetTable varchar(max))
--AS 
begin

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[temp]') AND type in (N'U'))
DROP TABLE [dbo].[temp]


declare @dropTableIfExists varchar(max)='IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'''+@TargetTable+''') AND type in (N''U''))
DROP TABLE '+@TargetTable+''

exec(@dropTableIfExists)

DECLARE @TableCreationQuery varchar(max)='SELECT * 
INTO temp
FROM '+@SourceServer+'.'+@SourceTable+'
where 1=0'

--print @TableCreationQuery
exec (@TableCreationQuery)


DECLARE @ColumnName nvarchar(max);
SET @ColumnName=(SELECT
    DISTINCT STUFF((
        SELECT ',' + case when a.DATA_TYPE='timestamp' then 'cast('+ a.COLUMN_NAME +' as varbinary(8)) '+a.COLUMN_NAME+'' else a.COLUMN_NAME end
        FROM (
            SELECT Column_name ,DATA_TYPE
            FROM INFORMATION_SCHEMA.COLUMNS (NOLOCK) 
WHERE '['+TABLE_SCHEMA+'].['+TABLE_NAME+']' = '[dbo].[temp]') a
        for xml path('')
    ),1,1,'') AS ColumnName)

DECLARE @Sqlquery nvarchar(max)
SET @Sqlquery = 'SELECT ' + @ColumnName + ' into '+@TargetTable+' FROM [dbo].[temp]' + '';
print @SqlQuery
--INSERT INTO originaltbl
EXECUTE(@Sqlquery)

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[temp]') AND type in (N'U'))
DROP TABLE [dbo].[temp]


end
end