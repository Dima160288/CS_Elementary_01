

drop table OrdersD
drop table orders
drop table users
drop table products
drop TABLE UsersLogin

create table Products
(
ProdID int NOT NULL Primary Key,
ProdName varchar(200) not null,
Qty int null,
price int varchar(50)
)


Create table UsersLogin
(
UserID int,
Email varchar(200),
PW varchar(50) not null
)

create table Users
(
UserID int not null primary key,
fio varchar(200),
Phone varchar(20) null,
FOREIGN KEY (UserID) REFERENCES UsersLogin(UserID)
)

Create table Orders
(
OrderID int  primary key,
OrderDate datetime,
UserID int,
OrderState smallint,
Notes varchar(2000),
FOREIGN KEY (UserID) REFERENCES Users(UserID)
)


Create table OrdersD
(
OrderID int,
SrcPosID int,
ProdID int,
qty int,
CONSTRAINT PK_Person PRIMARY KEY (OrderID,SrcPosID),
FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
FOREIGN KEY (ProdID) REFERENCES Products(ProdID)
)



 --select IFNULL(UserID,0) as UserID from Users where email = '1223@' and PW = 'qwerty'
