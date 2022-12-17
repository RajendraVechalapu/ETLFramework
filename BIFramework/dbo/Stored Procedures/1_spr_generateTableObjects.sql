
CREATE proc [dbo].[1_spr_generateTableObjects]
as
BEGIN
--Run this script in Target Database, it will create table scripts
DECLARE @ID int, @SourceServer varchar(max),@SourceTable varchar(max),@SourceTableColumnNames varchar(max)
,@LandingTargetTable varchar(max),@TargetTable varchar(max),@HighWaterMarkColumn varchar(max),@AutoIdentityColumn varchar(max)
,@SourceDatabase varchar(max)

declare @TargetTableLandingCreationQuery varchar(max),@TargetTableCreationQuery varchar(max)

set @ID=(SELECT MIN(ID) FROM ETLFramework.ETL.SourceTablesDataLoadDetails)

WHILE (@ID IS NOT NULL)
BEGIN

SELECT 
@SourceServer=e.SourceServer,@SourceDatabase=e.SourceDatabase,@SourceTable=e.SourceTable,@SourceTableColumnNames=e.SourceTableColumnNames
,@LandingTargetTable=e.LandingTargetTable,@TargetTable=e.TargetTable,@HighWaterMarkColumn=e.HighWaterMarkColumn,
@AutoIdentityColumn=e.AutoIdentityColumn
FROM ETLFramework.ETL.SourceTablesDataLoadDetails e WHERE ID=@ID

--SELECT @SourceQuery,@LandingTargetTable,@TargetTable

declare @dropLandingTargetTableIfExists varchar(max)='IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'''+@LandingTargetTable+''') AND type in (N''U''))
DROP TABLE '+@LandingTargetTable+''

declare @dropTargetTableIfExists varchar(max)='IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'''+@TargetTable+''') AND type in (N''U''))
DROP TABLE '+@TargetTable+''

print ''
print @dropLandingTargetTableIfExists
exec(@dropLandingTargetTableIfExists)
print ''
print @dropTargetTableIfExists
exec(@dropTargetTableIfExists)


SET @SourceTableColumnNames=REPLACE(@SourceTableColumnNames,isnull(@AutoIdentityColumn,''),' 1 as '+isnull(@AutoIdentityColumn,'')+'')

SET @TargetTableLandingCreationQuery='SELECT '+replace(@SourceTableColumnNames,isnull(@HighWaterMarkColumn,''),'cast('+isnull(@HighWaterMarkColumn,'')+' as varbinary(8)) '+isnull(@HighWaterMarkColumn,'')+' ')+', 
	getdate() as CreatedAsAt, getdate() ModifiedAsAt,null as ETLBatchLogId INTO '+@LandingTargetTable+' FROM '+@SourceServer+'.'+@SourceDatabase+'.'+@SourceTable+' where 1=0'

SET @TargetTableCreationQuery='SELECT '+replace(@SourceTableColumnNames,isnull(@HighWaterMarkColumn,''),'cast('+isnull(@HighWaterMarkColumn,'')+' as varbinary(8)) '+isnull(@HighWaterMarkColumn,'')+' ')+', 
	getdate() as CreatedAsAt, getdate() ModifiedAsAt,null as ETLBatchLogId INTO '+@TargetTable+' FROM '+@SourceServer+'.'+@SourceDatabase+'.'+@SourceTable+' where 1=0'

print @TargetTableLandingCreationQuery
print ''
print @TargetTableCreationQuery
exec(@TargetTableLandingCreationQuery)
exec(@TargetTableCreationQuery)
	

set @ID=(SELECT MIN(ID) FROM ETLFramework.ETL.SourceTablesDataLoadDetails WHERE ID > @ID)
END



END
