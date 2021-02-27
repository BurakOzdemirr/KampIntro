--Select
Select ContactName, CompanyName, City from Customers

-- Şehri londra olanları tüm kolonlarıyla getir.
Select * from Customers where City = 'London' 

-- Ürünler tablosunda categoryID si 1 olanların tüm kolonlarını getir.
select * from Products where CategoryID= 1

select * from Products where CategoryID= 1 or CategoryId= 3

select * from Products where CategoryID= 1 and UnitPrice>=10

-- ProductName 'e göre ürünleri sırala
select * from Products order by ProductName 

-- Kategoriye göre ürünleri sırala.
select * from Products order by CategoryID

--asc => azalan  desc => düşen
select * from Products order by UnitPrice desc

-- Product tablosunda kaç data var onu sayar ve verir. count => adet demektir.
Select count(*) from Products

-- Yönetim bize dedi ki hangi kategoride kaç farklı ürünümüz var. Bunu öğrenmek için group by kullanırız.
-- group by ile * kullanılmaz.

select categoryID from Products group by CategoryID
-- bütün kategorileri bana tekrar etmeyecek şekilde listele.

select categoryID, count(*) from Products group by CategoryID
-- bu da 1 kategoride 12 ürün 2 kategoride 12 ürün 3 kategoride 13 ürün varmış demek oluyor.

select categoryID, count(*) from Products group by CategoryID having count(*)<10
-- içinde 10 taneden az ürün olan kategorileri listele.

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories on Products.CategoryID = Categories.CategoryID


Select * from Products p left join [Order Details] od on p.ProductID= od.ProductID inner join Orders o on o.OrderID = od.OrderID
-- bu sorgu yazıma göre solda olup  sağda olmayanları da getir demektir.

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null