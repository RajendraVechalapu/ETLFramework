--exec [dbo].[2_LandingGenerateDataLoadQueries] 1
CREATE PROC [dbo].[2_LandingGenerateDataLoadQueries](@ETLBatchLogId int)
AS
BEGIN

--Landing, HighWaterMark query, included in the source query itself
--Run this script in Target Database, it will create table scripts
DECLARE @ID int, @SourceQuery varchar(max),@TargetQuery varchar(max),@SQLLoadQuery varchar(max),@HighWaterMarkColumn varchar(150)

SET @ID=(SELECT MIN(ID) FROM [ETL].[DataLoadScriptsCreation] WHERE Stage='Landing')

--DECLARE @HighWaterMarkQuery varchar(max)

WHILE (@ID IS NOT NULL)
BEGIN

SELECT 
@SourceQuery=e.SourceQuery,@TargetQuery=e.TargetQuery,@HighWaterMarkColumn=e.HighWaterMarkColumn
FROM [ETL].[DataLoadScriptsCreation] e WHERE ID=@ID and Stage='Landing'

IF @HighWaterMarkColumn IS NOT NULL
BEGIN
SELECT ''
END

--Table Creation, Landing, Target Tables
SET @SQLLoadQuery =''+@TargetQuery+''
SET @SQLLoadQuery = @SQLLoadQuery+''+replace(@SourceQuery,'@ETLBatchLogId',@ETLBatchLogId)+''

PRINT @SQLLoadQuery
--exec(@TargetTableLandingCreationQuery)

SET @ID=(SELECT MIN(ID) FROM [ETL].[DataLoadScriptsCreation] WHERE ID > @ID and Stage='Landing')
END

END
