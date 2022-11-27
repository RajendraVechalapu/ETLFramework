CREATE TABLE [ETL].[SourceTablesDataLoadDetails] (
    [ID]                     INT           IDENTITY (1, 1) NOT NULL,
    [SourceServer]           VARCHAR (250) NOT NULL,
    [SourceDatabase]         VARCHAR (MAX) NULL,
    [SourceTable]            VARCHAR (150) NOT NULL,
    [SourceQuery]            VARCHAR (MAX) NOT NULL,
    [SourceTableColumnNames] VARCHAR (MAX) NULL,
    [LandingTargetTable]     VARCHAR (150) NOT NULL,
    [TargetTable]            VARCHAR (150) NOT NULL,
    [DataLoadType]           VARCHAR (150) NOT NULL,
    [HighWaterMarkColumn]    VARCHAR (150) NULL,
    [AutoIdentityColumn]     VARCHAR (150) NULL,
    [KeyColumns]             VARCHAR (150) NULL,
    CONSTRAINT [PK_TablesObjectsCreation] PRIMARY KEY CLUSTERED ([ID] ASC)
);





