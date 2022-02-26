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

insert into DanhMucss values (N'M�y T�nh'), (N'�i?n tho?i'), (N'Qu?n �o'), (N'Gi?y'), (N'Mu B?o Hi?m'), (N'Nh� C?a'), (N'C�y c?i'), (N'Ph? ki?n');
go
insert into SanPham values (N'Laptop include Bluezone host', N'M�y t�nh c� c?u h�nh kh�ng ph?i b�n c�i c�ng v?i du?c l�m ch? bluezone d? c�n theo d�i th? m?i hay ch?', 1), (N'Vertu', N'Nh? g?n, ti?n l?i, kh� v?, d�ng l�m g?ch d?p v? b?t c? th? g� b?n mu?n, du?c ch�nh ph? khuy�n d�ng', 2), (N'Iphone 13 Pro Max never disappointed', N'iphone c� c?u h�nh ngon ngh?, s? 13 kh�ng bao l�m b?n th?t v?ng cho d� d� l� s? cho s? th?t b?i', 2), (N'B� s?a Oreo Supereme Limited with Nguy?n Ph� Tr?ng Signature', N'�o n�y s? kh�ng l�m b?n th?t v?ng ch? v� c� m?i m�u d? :))) m� l?i c�n du?c t?ng b� thu k� t?ng n?a ch?, ghen gh� :)', 3), (N'Nike air max with Nguyen Xuan Phuc signature', N'c�i gi�y ngon l?i du?c ch? k� c?a ch? t?ch nu?c th� c�n g� b?ng', 4), (N'Corona helmet with Vu Duc Dam signature', N'lu�n lu�n ch? d?o ph�ng ch?ng d?ch, h�nh m?u cho t?m guong c?a to�n th? nh�n d�n', 5), (N'B?nh Vi?n d� chi?n Vinh Ph�c', N'Nhi?u ph�ng ti?n nghi c�ng trang thi?t b? v� giu?ng ngon bi?n gi?c ng? trong b?nh vi?n c?a b?n tr? th�nh hi?n th?c', 6), (N'C�y c?i ? Nam ��n, Ngh? An', N'Ch?ng d?ch m?t m?i v?i b? �o tr?ng th� du?c ng?i du?i g?c c�y th� c�n g� b?ng', 7), (N'Kh?u trang N95 v� b? kit ch?ng corona c?a c�c nh� l�nh d?o Vi?t Nam thu?ng d�ng', N'd? n�y m� c� th� kh?i ph?i b�n', 8);
go

select * from DanhMucss
go
select * from SanPham
go
