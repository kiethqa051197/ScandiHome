SELECT 
	D.CategoryCode
	, (SELECT C.CategoryName FROM SKUCategory C WHERE C.CategoryCode=D.CategoryCode) AS CategoryName

	, D.GroupSKUCode
	, D.GroupSKUName

	, D.NewProductNote
	, D.SKU

	, D.ColorCode1
	, IIF(D.ColorCode1 IS NULL, NULL, (SELECT C.Color FROM SKUColor C WHERE C.ColorCode = D.ColorCode1)) as ColorName1
	, D.ColorCode2
	, IIF(D.ColorCode2 IS NULL, NULL, (SELECT C.Color FROM SKUColor C WHERE C.ColorCode = D.ColorCode2)) as ColorName2

	, D.MaterialCode1
	, IIF(D.MaterialCode1 IS NULL, NULL, (SELECT M.MaterialName FROM SKUMaterial M WHERE M.MaterialCode = D.MaterialCode1)) as MaterialName1
	, D.MaterialCode2
	, IIF(D.MaterialCode2 IS NULL, NULL, (SELECT M.MaterialName FROM SKUMaterial M WHERE M.MaterialCode = D.MaterialCode2)) as MaterialName2
	
	, D.SeriesCode
	, IIF(D.SeriesCode IS NULL, NULL, (SELECT S.SeriesReferences FROM ProductSeries S WHERE S.SeriesCode = D.SeriesCode)) as Series
	, IIF(D.SeriesCode IS NULL, NULL, (SELECT S.SeriesName FROM ProductSeries S WHERE S.SeriesCode = D.SeriesCode)) as InhouseSeries

	, D.DesignDate
	, D.DesignerName

FROM
(
	SELECT
		*

		, (SELECT PC.ColorCode FROM SKUProductColor PC WHERE PC.SKU=D.SKU AND PC.Id = (SELECT MIN(Id) FROM SKUProductColor WHERE SKU=D.SKU)) as ColorCode1
		, (SELECT PC.ColorCode FROM SKUProductColor PC WHERE PC.SKU=D.SKU AND PC.Id = (SELECT MAX(Id) FROM SKUProductColor WHERE SKU=D.SKU) AND (SELECT COUNT(*) FROM SKUProductColor DDD WHERE DDD.SKU=D.SKU) = 2) as ColorCode2
	
		, (SELECT PM.MaterialCode FROM SKUProductMaterial PM WHERE PM.SKU=D.SKU AND PM.Id = (SELECT MIN(Id) FROM SKUProductMaterial WHERE SKU=D.SKU)) as MaterialCode1
		, (SELECT PM.MaterialCode FROM SKUProductMaterial PM WHERE PM.SKU=D.SKU AND PM.Id = (SELECT MAX(Id) FROM SKUProductMaterial WHERE SKU=D.SKU) AND (SELECT COUNT(*) FROM SKUProductMaterial DDD WHERE DDD.SKU=D.SKU) = 2) as MaterialCode2

		, (SELECT PS.SeriesCode FROM ProductSeriesDetail PS WHERE PS.SKU=D.SKU) as SeriesCode
	FROM
	(
		SELECT 
			M.CategoryCode AS CategoryCode

			, SP.ModelSKUCode AS GroupSKUCode
			, M.ModelSKUName AS GroupSKUName

			, P.[Description] as NewProductNote
			, P.SKU

			, CONCAT(CAST((M.Width * 10) AS varchar), ' x ', CAST((M.Depth * 10) AS varchar), ' x ', CAST((M.Height * 10) AS varchar)) as Size
			, M.Width AS Width
			, M.Depth AS Depth
			, M.Height AS Height

			, P.DraftName

			, P.DesignDate
			, P.Designer + ' - ' + ISNULL(U.FirstName, '') + ' - ' + ISNULL(U.LastName, '') as DesignerName
		FROM Product P
		INNER JOIN dbo.SKUProduct SP
			ON P.ProductCode=SP.ProductCode
		INNER JOIN dbo.SKUModel M
			ON SP.ModelSKUCode=M.ModelSKUCode
		INNER JOIN [User] U
			ON P.Designer=U.UserName
	) D
	WHERE 
		EXISTS (SELECT PS.SeriesCode FROM ProductSeriesDetail PS WHERE PS.SKU=D.SKU)
) D