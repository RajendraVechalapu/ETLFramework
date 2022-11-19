CREATE proc [dbo].[1_generateTableObjects]
as
BEGIN
--Run this script in Target Database, it will create table scripts
DECLARE @ID int, @SourceQuery varchar(max),@LandingTargetTable varchar(max),@TargetTable varchar(max),@TargetTableLandingCreationQuery varchar(max),@TargetTableCreationQuery varchar(max)

set @ID=(SELECT MIN(ID) FROM ETLFramework.ETL.TablesObjectsCreation)

WHILE (@ID IS NOT NULL)
BEGIN

SELECT 
@SourceQuery=e.SourceQuery,@LandingTargetTable=e.LandingTargetTable,@TargetTable=e.TargetTable
FROM ETLFramework.ETL.TablesObjectsCreation e WHERE ID=@ID

--SELECT @SourceQuery,@LandingTargetTable,@TargetTable

declare @dropTableIfExists varchar(max)='IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'''+@TargetTable+''') AND type in (N''U''))
DROP TABLE '+@TargetTable+''

print @dropTableIfExists
--exec(@dropTableIfExists)

set @dropTableIfExists ='IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'''+@LandingTargetTable+''') AND type in (N''U''))
DROP TABLE '+@LandingTargetTable+''

print @dropTableIfExists
--exec(@dropTableIfExists)


--Table Creation, Landing, Target Tables
set @TargetTableLandingCreationQuery ='SELECT src.*, getdate() as CreatedAsAt, getdate() ModifiedAsAt,null as ETLBatchLogId into  '+@LandingTargetTable+' FROM('+@SourceQuery+' ) src where 1=0'
print @TargetTableLandingCreationQuery

set @TargetTableCreationQuery ='SELECT src.*, getdate() as CreatedAt, getdate() ModifiedAt,null as ETLBatchLogId into  '+@TargetTable+' FROM('+@SourceQuery+') src where 1=0'
print @TargetTableCreationQuery
--exec(@TargetTableLandingCreationQuery)
--exec(@TargetTableCreationQuery)
	

set @ID=(SELECT MIN(ID) FROM ETLFramework.ETL.TablesObjectsCreation WHERE ID > @ID)
END



END
