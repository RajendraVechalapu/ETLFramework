CREATE TABLE [dbo].[perfqueries] (
    [id]        INT            IDENTITY (1, 1) NOT NULL,
    [perfname]  VARCHAR (150)  NULL,
    [perfquery] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_perfqueries] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [IX_perfqueries] UNIQUE NONCLUSTERED ([perfname] ASC)
);

