 use master
 create database TestDb
 go
 use TestDb

Create Table Customers(
CustomerId int identity primary key,
Names varchar(100),
Email varchar(100),
LastDate date,
Amount money)

Create Table Invoice(
InvoiceId int identity primary key,
InvoiceDate datetime,
CustomerId int references Customers(CustomerId),
Amount money,
Balance money)

Create Table Payout(
PayoutId int identity primary key,
PayDate datetime,
InvoiceId int references Invoice(InvoiceId),
Amount money )

