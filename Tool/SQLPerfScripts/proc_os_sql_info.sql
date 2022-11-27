CREATE PROCEDURE [dbo].[proc_os_sql_info]
AS
BEGIN
	SELECT host_platform, host_distribution, host_release, 
       host_service_pack_level, host_sku,
	   @@SERVERNAME AS [Server Name], @@VERSION AS [SQL Server and OS Version Info]
	    --, os_language_version 
FROM sys.dm_os_host_info WITH (NOLOCK) OPTION (RECOMPILE); 

END