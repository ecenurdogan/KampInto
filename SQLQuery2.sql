--Select
--ANSI STANDARDI
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers
Select * from Customers where City ='London'
select *from Products where CategoryID = 1 or CategoryID = 3
select *from Products where CategoryID = 1 and UnitPrice>10
select * from Products order by ProductName
Select count(*) from Products