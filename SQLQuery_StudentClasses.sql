Create table classes(
	classId int identity(1,1) primary key not null,
	className varchar(10) not null
)
go

insert into classes values ('A1908G1'), ('A1908G2');
go

select * from classes
go

Create table student(
	studentId int identity(1,1) primary key not null,
	studentName nvarchar(70) not null,
	studentEmail varchar(50) not null,
	classId int foreign key references classes(classId) not null
)
go

insert into student values ( N'Phong','phong@gmail.com', 2), ( N'Tuan', 'tuan@gmail.com', 2), ( N'Tu', 'tu@outlook.com', 1)
go

select * from student;
go

select s.studentId, s.studentName, s.studentEmail, c.className from student as s left join classes as c on s.classId = c.classId;
go