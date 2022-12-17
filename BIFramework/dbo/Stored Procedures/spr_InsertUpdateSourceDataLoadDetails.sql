
CREATE PROC [dbo].[spr_InsertUpdateSourceDataLoadDetails](
@SourceServer varchar(max)
           ,@SourceDatabase varchar(max)
           ,@SourceTable varchar(max)
           ,@SourceQuery varchar(max)
		   ,@SourceTableColumnNames varchar(max)
		   ,@LandingTargetTableSchema varchar(max)
           ,@LandingTargetTable varchar(max)
           ,@TargetTable varchar(max)
           ,@HighWaterMarkColumn varchar(max)
           ,@AutoIdentityColumn varchar(max)
           ,@KeyColumns varchar(max)
		   ,@DataLoadType varchar(max)
		   
		  -- ,@LandingTargetQuery varchar(max)
		 --  ,@TargetQuery varchar(max)
)
as

DELETE FROM [ETL].[SourceTablesDataLoadDetails] WHERE 
replace(replace([SourceServer],'[',''),']','')=replace(replace(@SourceServer,'[',''),']','') 
AND replace(replace(SourceDatabase,'[',''),']','')=replace(replace(@SourceDatabase ,'[',''),']','')
AND replace(replace(SourceTable,'[',''),']','')=replace(replace(@SourceTable,'[',''),']','')

INSERT INTO [ETL].[SourceTablesDataLoadDetails]
           ([SourceServer]
           ,[SourceDatabase]
           ,[SourceTable]
           ,[SourceQuery]
		   ,SourceTableColumnNames
		   ,[LandingTargetTableSchema]
           ,[LandingTargetTable]
           ,[TargetTable]
           ,[HighWaterMarkColumn]
           ,[AutoIdentityColumn]
           ,[KeyColumns]
		   ,[DataLoadType]

		   )
     VALUES
           (
			@SourceServer
           ,@SourceDatabase
           ,@SourceTable
           ,@SourceQuery
		   ,@SourceTableColumnNames
		   ,replace(replace(@LandingTargetTableSchema,'[',''),']','')
           ,replace(replace(@LandingTargetTable,'[',''),']','')
           ,@TargetTable
           ,@HighWaterMarkColumn
           ,@AutoIdentityColumn
           ,@KeyColumns
		   ,@DataLoadType
		   )
