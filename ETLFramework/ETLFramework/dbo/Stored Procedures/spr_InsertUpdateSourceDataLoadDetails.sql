CREATE PROC [dbo].[spr_InsertUpdateSourceDataLoadDetails](
@SourceServer varchar(max)
           ,@SourceDatabase varchar(max)
           ,@SourceTable varchar(max)
           ,@SourceQuery varchar(max)
		   ,@SourceTableColumnNames varchar(max)
           ,@LandingTargetTable varchar(max)
           ,@TargetTable varchar(max)
           ,@DataLoadType varchar(max)
           ,@HighWaterMarkColumn varchar(max)
           ,@AutoIdentityColumn varchar(max)
           ,@KeyColumns varchar(max)
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
           ,[LandingTargetTable]
           ,[TargetTable]
           ,[DataLoadType]
           ,[HighWaterMarkColumn]
           ,[AutoIdentityColumn]
           ,[KeyColumns]
		   --,InsertLandingTargetQuery
		  -- ,InsertUpdateTargetQuery
		   )
     VALUES
           (@SourceServer
           ,@SourceDatabase
           ,@SourceTable
           ,@SourceQuery
		   ,@SourceTableColumnNames
           ,@LandingTargetTable
           ,@TargetTable
           ,@DataLoadType
           ,@HighWaterMarkColumn
           ,@AutoIdentityColumn
           ,@KeyColumns
		  -- ,@LandingTargetQuery
		  -- ,@TargetQuery
		   )