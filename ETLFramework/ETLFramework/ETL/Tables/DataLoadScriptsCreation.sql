CREATE TABLE [ETL].[DataLoadScriptsCreation] (
    [ID]                  INT            IDENTITY (1, 1) NOT NULL,
    [ActualSourceTable]   VARCHAR (100)  NULL,
    [SourceTable]         VARCHAR (100)  NULL,
    [SourceQuery]         NVARCHAR (MAX) NULL,
    [TargetTable]         VARCHAR (100)  NULL,
    [TargetQuery]         NVARCHAR (MAX) NULL,
    [DataLoadType]        VARCHAR (100)  NULL,
    [HighWaterMarkColumn] VARCHAR (MAX)  NULL,
    [Stage]               VARCHAR (50)   NULL,
    CONSTRAINT [PK_DataLoadScriptsCreation] PRIMARY KEY CLUSTERED ([ID] ASC)
);

