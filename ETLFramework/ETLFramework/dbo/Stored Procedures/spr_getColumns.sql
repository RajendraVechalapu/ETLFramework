CREATE proc spr_getColumns(@DBName varchar(max),@TableName varchar(max))
as
begin
SELECT 
	 col.COLUMN_NAME AS ColumnName
     , col.DATA_TYPE AS DataType
     , col.CHARACTER_MAXIMUM_LENGTH AS MaxLength
	 ,col.NUMERIC_PRECISION
	 ,col.NUMERIC_SCALE
	 , CAST(CASE col.IS_NULLABLE
                WHEN 'NO' THEN 0
                ELSE 1
            END AS bit)AS IsNullable
		, col.COLUMN_DEFAULT AS DefaultSetting
     , COLUMNPROPERTY(OBJECT_ID('[' + col.TABLE_SCHEMA + '].[' + col.TABLE_NAME + ']'), col.COLUMN_NAME, 'IsIdentity')AS IsIdentity
     , COLUMNPROPERTY(OBJECT_ID('[' + col.TABLE_SCHEMA + '].[' + col.TABLE_NAME + ']'), col.COLUMN_NAME, 'IsComputed')AS IsComputed
     , CAST(ISNULL(pk.is_primary_key, 0)AS bit)AS IsPrimaryKey
	 
  FROM [AdventureWorks2019].INFORMATION_SCHEMA.COLUMNS AS col
       LEFT JOIN(SELECT SCHEMA_NAME(o.schema_id)AS TABLE_SCHEMA
                      , o.name AS TABLE_NAME
                      , c.name AS COLUMN_NAME
                      , i.is_primary_key
                   FROM sys.indexes AS i JOIN sys.index_columns AS ic ON i.object_id = ic.object_id
                                                                     AND i.index_id = ic.index_id
                                         JOIN sys.objects AS o ON i.object_id = o.object_id
                                         LEFT JOIN sys.columns AS c ON ic.object_id = c.object_id
                                                                   AND c.column_id = ic.column_id
                  WHERE i.is_primary_key = 1)AS pk ON col.TABLE_NAME = pk.TABLE_NAME
                                                  AND col.TABLE_SCHEMA = pk.TABLE_SCHEMA
                                                  AND col.COLUMN_NAME = pk.COLUMN_NAME
 WHERE 1=1
 and col.DATA_TYPE='decimal'
 and col.TABLE_NAME = 'product'
   --AND col.TABLE_SCHEMA = 'person'
 ORDER BY col.TABLE_NAME, col.ORDINAL_POSITION
 end