CREATE TABLE [ETL].[TableLoadReport] (
    [TableLoadReportID] BIGINT         IDENTITY (1, 1) NOT NULL,
    [SourceTableName]   NVARCHAR (500) NULL,
    [TargetTableName]   NVARCHAR (500) NULL,
    [RowCount]          INT            NULL,
    [RowsInserted]      INT            NULL,
    [RowsUpated]        INT            NULL,
    [RowsDeleted]       INT            NULL,
    [AsAtDate]          DATETIME       NULL,
    [Status]            VARCHAR (100)  NULL,
    [Comments]          NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_TableLoadReport] PRIMARY KEY CLUSTERED ([TableLoadReportID] ASC),
    CONSTRAINT [CHK_TableLoad] CHECK ([Status]='Error' OR [Status]='Completed' OR [Status]='InProgress' OR [Status]='Started')
);

