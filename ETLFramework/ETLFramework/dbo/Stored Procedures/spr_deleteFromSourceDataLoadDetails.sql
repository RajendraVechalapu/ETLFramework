create PROC [dbo].[spr_deleteFromSourceDataLoadDetails](
@SourceServer varchar(max)
           ,@SourceDatabase varchar(max)
           ,@SourceTable varchar(max)
           
)
as

DELETE FROM [ETL].[SourceTablesDataLoadDetails] WHERE 
replace(replace([SourceServer],'[',''),']','')=replace(replace(@SourceServer,'[',''),']','') 
AND replace(replace(SourceDatabase,'[',''),']','')=replace(replace(@SourceDatabase ,'[',''),']','')
AND replace(replace(SourceTable,'[',''),']','')=replace(replace(@SourceTable,'[',''),']','')