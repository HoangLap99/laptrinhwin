use master
go 
if DB_ID('CuaHang') is not null
	drop database QuanLyCuaHang
go
create database CuaHang
go
 use CuaHang
 go
 create table khachhang(
 makhachhang nchar(10) not null primary key,
 tenkhachhang nvarchar(50),
 diachi nvarchar(50),
 sodienthoai nvarchar(10)
 )
 insert into khachhang values(001,N'Lập Đình',N'08/10/1999',N'Thanh Hóa',N'nam',N'0987859749')
 insert into khachhang values(002,N'Bính Nguyễn',N'04/04/1999',N'Hải Phòng',N'nam',N'0985445452')
 insert into khachhang values(003,N'Cường Ngô',N'12/03/1999',N'Thái Bình',N'nam',N'2102151')
 select* from khachhang
create table nhanvien(
manhanvien nchar(10) not null primary key,
tennhanvien nvarchar(50) ,
ngaysinh date,
gioitinh nchar(10),
diachi nvarchar(50),
sodienthoai nchar(10),
)
--nhâp bảng nhân viên
 insert into nhanvien values(2017605,N'Lập Đình',N'08/10/1999',N'Thanh Hóa',N'nam',N'0987859749')
 insert into nhanvien values(2017606,N'Bính Nguyễn',N'04/04/1999',N'Hải Phòng',N'nam',N'0985445452')
 insert into nhanvien values(2017607,N'Cường Ngô',N'12/03/1999',N'Thái Bình',N'nam',N'2102151')

 create table taikhoan(
mataikhoan nchar(10) not null primary key,
manhanvien nchar(10),
matkhau nchar(10),
constraint fk_taikhoan foreign key (manhanvien) references nhanvien(manhanvien)
 )
 insert into taikhoan values(01,2017605,N'admin')
 insert into taikhoan values(02,2017606,N'admin')
 insert into taikhoan values(03,2017607,N'admin')
 create table loaisanpham(
 maloaisanpham nchar(10) primary key not null,
 tenloaisanpham nvarchar(50),
 nhacungcap nchar(10)
 constraint fk_loaisanpham foreign key (nhacungcap) references nhacungcap(manhacungcap)
 )
 insert into loaisanpham values(001,N'Cây ăn quả',10)
 insert into loaisanpham values(002,N'Cây để bàn',10)
 insert into loaisanpham values(003,N'Hoa Hồng',10)
 insert into loaisanpham values(004,N'Hoa Hướng Dương',10)

 create table sanpham(
 masanpham nchar(10) not null primary key,
 tensanpham nvarchar(50),
 giathanh int,
 soluongcon int,
 loaisanpham nchar(10),
 constraint fk_sanpham foreign key (loaisanpham) references loaisanpham(maloaisanpham)
 )
 insert into sanpham values(1,N'Cây mít',N'20000',100,001)
 insert into sanpham values(2,N'Cây xương rồng',N'30000',80,002)
 insert into sanpham values(3,N'Hoa Hồng Đỏ',N'10000',150,003)
 insert into sanpham values(4,N'Hoa Hướng Dương',N'50000',50,004)
 create table hoadon(
 mahoadon int identity(1,1) primary key,
 ngaylap date,
 nhanvienban nchar(10),
 khachhang nchar(10),
  constraint fk_hoadon1 foreign key (nhanvienban) references nhanvien(manhanvien),
  constraint fk_hoadon2 foreign key (khachhang) references khachhang(makhachhang)
 )
 insert into hoadon values(N'10/10/2019',2017605,001)
 insert into hoadon values(N'01/01/2020',2017606,002)
 insert into hoadon values(N'05/05/2020',2017607,003)

 create table chitiethoadon(
 hoadon int not null,
 sanpham nchar(10) not null,
 soluong int,
 giaban int,
 
 constraint PK_chitiethoadon primary key (hoadon, sanpham),
	constraint FK1_cthd foreign key (hoadon) references hoadon (mahoadon)
	on update cascade on delete cascade ,
	constraint FK2_cthd foreign key (sanpham) references sanpham (masanpham)
	on update cascade on delete cascade 
 )
 insert into chitiethoadon values(001,1,5,30000)
 insert into chitiethoadon values(002,2,10,40000) 
 insert into chitiethoadon values(003,3,15,15000)
 select * from chitiethoadon
 select * from sanpham
  select * from hoadon
  create table chamcong(
   manhanvien nchar(10),
  luong1ngay money,
  songaylam int,
 
   constraint PK_chamcong primary key ( manhanvien),
	constraint fk_chamcong foreign key (manhanvien) references nhanvien (manhanvien)
	on update cascade on delete cascade 

  ) 
  insert into chamcong values(2017605,200000,30)
  insert into chamcong values(2017606,200000,31)
  insert into chamcong values(2017607,200000,29)


  select*from taikhoan