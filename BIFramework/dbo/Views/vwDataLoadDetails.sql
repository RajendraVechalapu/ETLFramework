CREATE VIEW vwDataLoadDetails
as
SELECT 
      [SourceTable]
      ,[SourceTableColumnNames]
      ,[LandingTargetTable]
      ,[TargetTable]
      ,[HighWaterMarkColumn]
      ,[DataLoadType]
      ,[HighWaterMarkValue]
  FROM [ETL].[SourceTablesDataLoadDetails]
  