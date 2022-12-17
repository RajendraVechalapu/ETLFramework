
CREATE proc [dbo].[spr_BatchStart]
as

INSERT INTO [ETL].[BatchLog]
           ([StartDateTime]
           ,[EndDateTime]
           ,[Status])
     VALUES
           (GETDATE()
           ,GETDATE()
           ,'Started')
