create table DanhMucss(
	DanhMucsID int identity(1,1) primary key not null,
	DanhMucName nvarchar(175) not null
	)
create table SanPham(
	SanPhamId int identity(1,1) primary key not null,
	SanPhamTen nvarchar(175) not null,
	SanPhamMoTa nvarchar(200),
	DanhMucsID int not null foreign key references DanhMucss(DanhMucsID)
)
go
drop table SanPham
go
drop table DanhMucss
go

insert into DanhMucss values (N'Máy Tính'), (N'Ði?n tho?i'), (N'Qu?n áo'), (N'Gi?y'), (N'Mu B?o Hi?m'), (N'Nhà C?a'), (N'Cây c?i'), (N'Ph? ki?n');
go
insert into SanPham values (N'Laptop include Bluezone host', N'Máy tính có c?u hình không ph?i bàn cãi cùng v?i du?c làm ch? bluezone d? còn theo dõi th? m?i hay ch?', 1), (N'Vertu', N'Nh? g?n, ti?n l?i, khó v?, dùng làm g?ch d?p v? b?t c? th? gì b?n mu?n, du?c chính ph? khuyên dùng', 2), (N'Iphone 13 Pro Max never disappointed', N'iphone có c?u hình ngon ngh?, s? 13 không bao làm b?n th?t v?ng cho dù dó là s? cho s? th?t b?i', 2), (N'Bò s?a Oreo Supereme Limited with Nguy?n Phú Tr?ng Signature', N'áo này s? không làm b?n th?t v?ng ch? vì có m?i màu d? :))) mà l?i còn du?c t?ng bí thu kí t?ng n?a ch?, ghen ghê :)', 3), (N'Nike air max with Nguyen Xuan Phuc signature', N'cái giày ngon l?i du?c ch? kí c?a ch? t?ch nu?c thì còn gì b?ng', 4), (N'Corona helmet with Vu Duc Dam signature', N'luôn luôn ch? d?o phòng ch?ng d?ch, hình m?u cho t?m guong c?a toàn th? nhân dân', 5), (N'B?nh Vi?n dã chi?n Vinh Phúc', N'Nhi?u phòng ti?n nghi cùng trang thi?t b? và giu?ng ngon bi?n gi?c ng? trong b?nh vi?n c?a b?n tr? thành hi?n th?c', 6), (N'Cây c?i ? Nam Ðàn, Ngh? An', N'Ch?ng d?ch m?t m?i v?i b? áo tr?ng thì du?c ng?i du?i g?c cây thì còn gì b?ng', 7), (N'Kh?u trang N95 và b? kit ch?ng corona c?a các nhà lãnh d?o Vi?t Nam thu?ng dùng', N'd? này mà có thì kh?i ph?i bàn', 8);
go

select * from DanhMucss
go
select * from SanPham
go
