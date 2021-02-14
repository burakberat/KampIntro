--Select
Select ContactName, CompanyName, City from Customers

Select * from Customers where City = 'London'

Select * from Products where CategoryID = 1 or CategoryID = 3

Select * from Products where CategoryID = 1 and UnitPrice >= 10

select * from Products order by ProductName

select * from Products order by CategoryID, ProductName

select * from Products order by UnitPrice desc --- asc: artan desc: azalan

select ProductName from Products

select COUNT(*) from Products

select COUNT(*) from Products where CategoryID = 2

Select CategoryID, count(*) from Products group by CategoryID

Select CategoryID, count(*) from Products group by CategoryID having count(*) < 10

Select CategoryID, count(*) from Products where UnitPrice > 20 group by CategoryID having count(*) < 10

select * from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where UnitPrice > 10

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID

select * from customers c left join Orders o --solda olup sağda olmayanları da getir.
on c.customerID = o.customerID
where o.CustomerID is null -- daha önce hiç ürün satın almayan müşteriler.

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderDate = od.OrderID







