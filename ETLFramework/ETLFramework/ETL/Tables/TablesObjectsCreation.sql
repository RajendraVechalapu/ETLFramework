CREATE TABLE [ETL].[TablesObjectsCreation] (
    [ID]                 INT           IDENTITY (1, 1) NOT NULL,
    [SourceTable]        VARCHAR (50)  NULL,
    [SourceQuery]        VARCHAR (MAX) NULL,
    [LandingTargetTable] VARCHAR (100) NULL,
    [TargetTable]        VARCHAR (100) NULL,
    CONSTRAINT [PK_TablesObjectsCreation] PRIMARY KEY CLUSTERED ([ID] ASC)
);

