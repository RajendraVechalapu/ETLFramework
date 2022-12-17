
/*
[2_spr_GenerateDataLoadQueries]
*/

CREATE proc [dbo].[2_spr_GenerateDataLoadQueries]
as

BEGIN
--Run this script in Target Database, it will create table scripts
DECLARE @ID int, @SourceServer varchar(max),@SourceTable varchar(max),@SourceTableColumnNames varchar(max)
,@LandingTargetTable varchar(max),@TargetTable varchar(max),@HighWaterMarkColumn varchar(max),@srcMergeSchemaName varchar(max),@srcMergeTableName varchar(max)

declare @TargetTableLandingCreationQuery varchar(max),@TargetTableCreationQuery varchar(max),@HighWaterMarkQuery varchar(max)
,@LandingTableFromQuery varchar(max),@LandingTableToQuery varchar(max)
,@TargetTableFromQuery varchar(max),@TargetTableToQuery varchar(max),@SQLQuery VARCHAR(MAX),@KeyJoinColumns varchar(max)

set @ID=(SELECT MIN(ID) FROM ETL.SourceTablesDataLoadDetails)

PRINT('exec dbo.spr_BatchStart

DECLARE @BatchLogID int
set @BatchLogID=(SELECT ISNULL(MAX(BatchLogID),1) FROM ETL.BatchLog)')

print ''

WHILE (@ID IS NOT NULL)
BEGIN

SELECT 
@SourceServer=e.SourceServer,@SourceTable=e.SourceTable,@SourceTableColumnNames=e.SourceTableColumnNames
,@LandingTargetTable=e.LandingTargetTable,@TargetTable=e.TargetTable,@HighWaterMarkColumn=e.HighWaterMarkColumn,
@KeyJoinColumns=e.KeyColumns
FROM ETL.SourceTablesDataLoadDetails e WHERE ID=@ID

--SELECT @SourceQuery,@LandingTargetTable,@TargetTable

--Landing DataLoad


--SET @LandingTableToQuery='INSERT INTO '+@LandingTargetTable+' ('+@SourceTableColumnNames+',CreatedAsAt,ModifiedAsAt,ETLBatchLogId)'
SET @LandingTableFromQuery='SELECT '+replace(@SourceTableColumnNames,isnull(@HighWaterMarkColumn,''),'cast('+isnull(@HighWaterMarkColumn,'')+' as varbinary(8)) '+isnull(@HighWaterMarkColumn,'')+' ')+', 
	getdate() as CreatedAsAt, getdate() ModifiedAsAt,@BatchLogID FROM '+@SourceServer+'.'+@SourceTable+' '

--SET @SQLQuery=@LandingTableFromQuery +@LandingTableFromQuery
SET @SQLQuery=@LandingTableFromQuery

IF isnull(@HighWaterMarkColumn,'') != ''
BEGIN
SET @HighWaterMarkQuery= 'DECLARE @HighWaterMarkValue BIGINT=(SELECT ISNULL(MAX(CAST('+@HighWaterMarkColumn+' AS BIGINT)),0) FROM '+@TargetTable+')'
SET @SQLQuery=@HighWaterMarkQuery+@SQLQuery
SET @SQLQuery=@SQLQuery+ 'WHERE '+@HighWaterMarkColumn+'>=@HighWaterMarkValue'
END

SELECT @SQLQuery

--SELECT @LandingTargetTable

SELECT @srcMergeSchemaName=TABLE_SCHEMA,@srcMergeTableName=TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES
WHERE '['+TABLE_SCHEMA+'].['+TABLE_NAME+']'=@LandingTargetTable

if isnull(@KeyJoinColumns,'')!=''
begin
SET  @KeyJoinColumns=replace(replace('"'''+@KeyJoinColumns+'''"','[',''),']','')
/*
exec ('targetdb.dbo.[sp_generate_merge] @schema='''+@srcMergeSchemaName+''',@table_name='''+@srcMergeTableName+''',@target_table='''+@TargetTable+'''
	,@cols_to_join_on='+@KeyJoinColumns+'')
	*/
end

set @ID=(SELECT MIN(ID) FROM ETL.SourceTablesDataLoadDetails WHERE ID > @ID)

END



END
