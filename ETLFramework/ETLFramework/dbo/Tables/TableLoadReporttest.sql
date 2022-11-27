CREATE TABLE [dbo].[TableLoadReporttest] (
    [SourceTableName] NVARCHAR (500) NULL,
    [TargetTableName] NVARCHAR (500) NULL,
    [RowCount]        INT            NULL,
    [RowsInserted]    INT            NULL,
    [RowsUpated]      INT            NULL,
    [RowsDeleted]     INT            NULL,
    [AsAtDate]        DATETIME       NULL,
    [Status]          VARCHAR (100)  NULL,
    [Comments]        NVARCHAR (MAX) NULL
);

