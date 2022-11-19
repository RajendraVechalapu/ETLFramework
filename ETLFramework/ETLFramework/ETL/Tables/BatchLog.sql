CREATE TABLE [ETL].[BatchLog] (
    [BatchLogID]    INT            IDENTITY (1, 1) NOT NULL,
    [StartDateTime] DATETIME       CONSTRAINT [DF__BatchLog__StartD__4316F928] DEFAULT (getdate()) NOT NULL,
    [EndDateTime]   DATETIME       NULL,
    [Status]        VARCHAR (50)   NOT NULL,
    [Comments]      NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_BatchLog] PRIMARY KEY CLUSTERED ([BatchLogID] ASC),
    CONSTRAINT [CHK_BatchLog] CHECK ([Status]='Error' OR [Status]='Completed' OR [Status]='InProgress' OR [Status]='Started')
);



