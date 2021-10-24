SELECT p.ProductName AS product, t.Tag as category
FROM products p
	LEFT JOIN products_tags p_t ON p_t.ProductId =  p.Id
	LEFT JOIN tags t ON t.Id = p_t.TagId