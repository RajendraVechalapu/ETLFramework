CREATE TABLE [ETL].[BatchLog] (
    [BatchLogID]    INT            IDENTITY (1, 1) NOT NULL,
    [StartDateTime] DATETIME       DEFAULT (getdate()) NOT NULL,
    [EndDateTime]   DATETIME       NULL,
    [Status]        CHAR (1)       NOT NULL,
    [Comments]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_BatchLog] PRIMARY KEY CLUSTERED ([BatchLogID] ASC),
    CONSTRAINT [CHK_BatchLog] CHECK ([Status]='Error' OR [Status]='Completed' OR [Status]='InProgress' OR [Status]='Started')
);

