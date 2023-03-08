Create database ManageCoffeeShop
GO

USE ManageCoffeeShop
GO
 
--food
--table
--foodcategory
--Account
--Bill
--BillInfo

Create table TableFood
(
	id INT Identity primary key,
	name Nvarchar(100) not null default 'Unname',
	status Nvarchar(100) not null default 'Empty'   -- empty || have people
)
GO
Create table Account
(
	Username Nvarchar(100) primary key,
	DisplayName Nvarchar(100) not null default 'CoderChanDoi',
	Password Nvarchar(100) not null,
	Type int not null default 0 -- 1: admin| 0: staff

)
GO
Create table FoodCategory
(
	id INT Identity primary key not null,
	name Nvarchar(100) not null default 'Unname',
)
GO
Create table Food
(
	id INT Identity primary key,
	name Nvarchar(100) not null default 'Unname',
	idCategory Int not null,
	price float not null default 0

	Foreign key (idCategory) references dbo.FoodCategory(id)
)
GO
Create table Bill
(
	id INT Identity primary key,
	DateCheckIn Date not null,
	DateCheckOut date,
	idTable int not null,
	status int default 0, -- 1 da thanh toan| 0 chua thanh toan

	Foreign key (idTable) references dbo.TableFood(id)
)
GO
Create table BillInfo
(
	id INT Identity primary key,
	idBill Int not null,
	idFood Int not null,
	count int not null default 0

	Foreign key (idBill) references dbo.Bill(id),
	Foreign key (idFood) references dbo.Food(id)
)

go


create proc USP_GetAccountByUsername
@Username nvarchar(100)
as
begin
	select * from dbo.Account where Username = @Username
end
go

exec dbo.USP_GetAccountByUsername @Username = N'thanh'

select * from dbo.Account where Username = N'khanh' and Password = N'3' or 1 = 1 --


create proc USP_Login
@Username nvarchar(100), @Password nvarchar(100)
As 
Begin
	select * from dbo.Account where Username = @username and Password = @password
End
GO

-- delete procedure
drop procedure USP_Login
drop database ManageCoffeeShop


-- add table
Declare @i int = 1
while @i <= 20
begin 
	insert dbo.TableFood (name) values (N'Table ' + cast(@i as nvarchar(100)))
	set @i = @i + 1
end

delete  from dbo.TableFood

select * from dbo.TableFood

-- table lsit 
create proc USP_GetTableList
AS select * from dbo.TableFood
go

update dbo.TableFood set status = N'Booked' where id = 15

exec dbo.USP_GetTableList

-- add category
insert dbo.FoodCategory
			(name)
values (N'SeaFood')--name - nvarchar(100)
insert dbo.FoodCategory
		(name)
values (N'JungFood')
insert dbo.FoodCategory
		(name)
values (N'WaterFood')
insert dbo.FoodCategory
		(name)
values (N'FarmFood')
insert dbo.FoodCategory
		(name)
values (N'Drink')

-- add food
insert dbo.Food
		(name, idCategory, price)
values (N'Mực một nắng nướng sa tế', 1, 120000)
insert dbo.Food
		(name, idCategory, price)
values (N'Nghêu hấp xả', 1, 120000)
insert dbo.Food
		(name, idCategory, price)
values (N'Mì xào hải sản', 1, 100000)
insert dbo.Food
		(name, idCategory, price)
values (N'Heo Rừng nướng', 2, 120000)
insert dbo.Food
		(name, idCategory, price)
values (N'Gà rừng nướng lu', 2, 210000)
insert dbo.Food
		(name, idCategory, price)
values (N'Dú dê nướng sữa', 4, 150000)
insert dbo.Food
		(name, idCategory, price)
values (N'Cơm chiên mushi', 3, 50000)
insert dbo.Food
		(name, idCategory, price)
values (N'7UP', 5, 15000)
insert dbo.Food
		(name, idCategory, price)
values (N'Cà phê', 5, 10000)
-- thêm bill
insert dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status)
values (Getdate(), null, 15, 0)
insert dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status)
values (Getdate(), null, 12, 0)
insert dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status)
values (Getdate(), null, 4, 1)
insert dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status)
values (Getdate(), Getdate(), 2, 1)
insert dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status)
values (Getdate(), Getdate(), 5, 1)
-- theem bill info
insert dbo.BillInfo
		(idBill, idFood, count)
values (1, 1, 2)
insert dbo.BillInfo
		(idBill, idFood, count)
values (1, 3, 4)
insert dbo.BillInfo
		(idBill, idFood, count)
values (1, 5, 1)
insert dbo.BillInfo
		(idBill, idFood, count)
values (2, 6, 2)
insert dbo.BillInfo
		(idBill, idFood, count)
values (3, 5, 2)
insert dbo.BillInfo
		(idBill, idFood, count)
values (4, 6, 4)
insert dbo.BillInfo
		(idBill, idFood, count)
values (5, 7, 9)
insert dbo.BillInfo
		(idBill, idFood, count)
values (6, 6, 2)
insert dbo.BillInfo
		(idBill, idFood, count)
values (7, 5, 2)

select * from dbo.Bill where idTable = 15

select * from dbo.Bill
select * from dbo.Food
select * from dbo.BillInfo
select * from dbo.FoodCategory 
select * from dbo.TableFood

select * from dbo.BillInfo where idBill = 4

select * from dbo.Bill where idTable = 2 and status = 1

select f.name, bi.count, f.price, f.price*bi.count as totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f 
where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = 15

select * from dbo.BillInfo
select * from dbo.Bill
select * from dbo.TableFood

Create proc USP_InsertBill
@idTable INT
AS
BEGIN
	insert dbo.Bill
		(DateCheckIn, DateCheckOut, idTable, status)
	values (Getdate(), null, @idTable, 0)
END
GO

Create proc USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN
	insert dbo.BillInfo
		(idBill, idFood, count)
	values (@idBill, @idFood, @count)
END
GO

select * from dbo.Account