
/*
DECLARE @ETLBatchLogId INT=(SELECT isnull(MAX(BatchLogID),1) FROM etl.BatchLog)
exec [dbo].[2_LandingGenerateDataLoadQueries] @ETLBatchLogId
*/

CREATE PROC [dbo].[LandingGenerateDataLoadQueries_archive](@ETLBatchLogId int)
AS
BEGIN

--Landing, HighWaterMark query, included in the source query itself
--Run this script in Target Database, it will create table scripts
DECLARE @ID int, @SourceQuery varchar(max),@TargetQuery varchar(max),@TargetTable varchar(150),@SQLLoadQuery varchar(max),@HighWaterMarkColumn varchar(150)

SET @ID=(SELECT MIN(ID) FROM [ETL].[DataLoadScriptsCreation] WHERE Stage='Landing')

DECLARE @HighWaterMarkQuery varchar(max)

WHILE (@ID IS NOT NULL)
BEGIN

SELECT 
@SourceQuery=e.SourceQuery,@TargetQuery=e.TargetQuery,@TargetTable=e.TargetTable,@HighWaterMarkColumn=e.HighWaterMarkColumn
FROM [ETL].[DataLoadScriptsCreation] e WHERE ID=@ID and Stage='Landing'

IF @HighWaterMarkColumn IS NOT NULL
BEGIN
SET @HighWaterMarkQuery= 'DECLARE @HighWaterMarkValue BITINT=(SELECT MAX(['+@HighWaterMarkColumn+']) FROM '+@TargetTable+')'
END

IF @HighWaterMarkColumn IS NOT NULL
BEGIN
	SET @SQLLoadQuery =''+@HighWaterMarkQuery+';'
END
--Table Creation, Landing, Target Tables
SET @SQLLoadQuery =''+@TargetQuery+''
SET @SQLLoadQuery = @SQLLoadQuery+''+replace(@SourceQuery,'@ETLBatchLogId',@ETLBatchLogId)+''

IF @HighWaterMarkColumn IS NOT NULL
BEGIN
	SET @SQLLoadQuery = @SQLLoadQuery+''+' WHERE '+@HighWaterMarkColumn+' >= @HighWaterMarkColumn'
END
PRINT @SQLLoadQuery
--exec(@TargetTableLandingCreationQuery)

SET @ID=(SELECT MIN(ID) FROM [ETL].[DataLoadScriptsCreation] WHERE ID > @ID and Stage='Landing')
END

END