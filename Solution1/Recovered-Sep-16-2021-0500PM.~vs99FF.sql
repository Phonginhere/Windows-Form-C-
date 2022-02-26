create table Product(
	ProductId int identity(1,1) not null,
	ProductName nvarchar(50),
	ProductCmt nvarchar(100)
)

insert into Product values(N'ipad', N'tuy?t v?i');

select * from Product