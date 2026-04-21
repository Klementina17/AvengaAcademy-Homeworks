

SELECT SUM(TotalPrice) as TotalAmount
FROM Orders o
GO

SELECT be.Name, SUM(TotalPrice) as TotalAmount
FROM Orders o INNER JOIN BusinessEntities be ON o.BusinessEntityId=be.Id
GROUP BY be.Name
GO

SELECT be.Id,be.Name,SUM(TotalPrice) as TotalAmount
FROM Orders o INNER JOIN BusinessEntities be ON o.BusinessEntityId=be.Id
WHERE o.CustomerId<20
GROUP BY be.Id,be.Name
GO


SELECT be.Id,be.Name,Max(TotalPrice) as MaxOrderAmount,AVG(TotalPrice) as AvgOrder
FROM Orders o INNER JOIN BusinessEntities be ON o.BusinessEntityId=be.Id
GROUP BY be.Id,be.Name
GO

SELECT TOP 1 be.Name, SUM(o.TotalPrice) as TotalSales
FROM Orders o
JOIN BusinessEntities be ON o.BusinessEntityId = be.Id
GROUP BY be.Id, be.Name
ORDER BY TotalSales DESC
GO

SELECT be.Id,be.Name,SUM(o.TotalPrice) as TotalAmount
FROM Orders o INNER JOIN BusinessEntities be ON o.BusinessEntityId=be.Id
GROUP BY be.Id,be.Name
HAVING SUM(o.TotalPrice) > 635558
GO

SELECT be.Id,be.Name,SUM(o.TotalPrice) as TotalAmount
FROM Orders o INNER JOIN BusinessEntities be ON o.BusinessEntityId=be.Id
WHERE o.CustomerId<20
GROUP BY be.Id,be.Name
HAVING SUM(o.TotalPrice) <100000
GO

SELECT be.Id,be.Name,MAX(o.TotalPrice) AS MaxPrice,AVG(o.TotalPrice) AS AvgPrice
FROM Orders o INNER JOIN BusinessEntities be ON o.BusinessEntityId = be.Id
GROUP BY be.Id, be.Name
HAVING SUM(o.TotalPrice) > 4 * AVG(o.TotalPrice);
GO