Select Products.name, Category.name 
	from Products
Join ProductCategory
	on ProductCategory.productId = Product.Id
Join Category
	on Category.Id = ProductCategory.categoryId