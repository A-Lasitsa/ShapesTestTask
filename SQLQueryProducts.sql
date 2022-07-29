/* Название таблицы с продуктами - Product; колонка с названиями продуктов во всех таблицах - pName */
declare @SQL nvarchar(max) = 'select Product.pName, category from Product left join ('

select @SQL = @SQL + 'select Product.pName, '''+ t.TABLE_NAME +''' as category from Product join ['+ t.TABLE_NAME +'] on Product.pName = ['+ t.TABLE_NAME +'].pName union ' 
From INFORMATION_SCHEMA.TABLES t
where TABLE_NAME != 'Product'

select @SQL = substring(@SQL,1,len(@SQL)-6)

select @SQL = @SQL + ') as incl on Product.pName = incl.pName'

exec sp_executesql @SQL
