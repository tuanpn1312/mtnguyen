---Tìm tất cả các thuộc tính của Sách
ALTER PROCEDURE pro_GetAllProducts
AS
BEGIN
	SELECT * FROM dbo.SanPham
END
GO
--Tìm sách theo mã sách
ALTER PROCEDURE pro_GetProductByID
@masach NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.SanPham
	WHERE MaSach=@masach AND TrangThai='True'	
END
GO
EXEC pro_GetProductByID ms01


--Tìm sách theo Tên sách
ALTER PROCEDURE pro_GetProductByName
@tensach NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.SanPham
	WHERE TenSach = @tensach AND TrangThai ='True'
END
GO
EXEC pro_GetProductByName book1
--Tìm sách theo danh mục
ALTER PROCEDURE pro_GetProductByCategory
@danhmuc NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.SanPham
	WHERE Danhmuc = @danhmuc AND TrangThai='True';	
END
GO
EXEC pro_GetProductByCategory 1


--Tìm tất cả thông tin của khách hàng
ALTER PROCEDURE pro_GetAllInfoOfUser
AS
BEGIN
	SELECT * FROM dbo.KhachHang
END
GO

--Tìm khách hàng theo cmnd
ALTER PROCEDURE pro_GetUserByCMND
@cmnd NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.KhachHang
	WHERE CMND=@cmnd
END
GO
EXEC pro_GetUserByCMND @cmnd = '123'
--Tìm tất cả thông tin của Đơn hàng
ALTER PROCEDURE pro_GetAllInfoOfOrder
AS
BEGIN
	SELECT * FROM dbo.HoaDon
END
GO

--Tìm hóa đơn theo mã hóa đơn
CREATE PROCEDURE pro_GetOrderByID
@mahoadon NVARCHAR(50)
AS
BEGIN
	SELECT TenKH, NgayTao,TongTien
	FROM dbo.HoaDon
	WHERE MaHD =@mahoadon
END
GO
--Tìm Hóa đơn đã được thanh toán
ALTER PROCEDURE pro_GetOrderForPayment
@mahoadon NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM dbo.HoaDon
	WHERE @mahoadon = MaHD AND TrangThai = 'false'
END
GO

--Thêm Hoá đơn
ALTER PROCEDURE pro_AddOrder
@mahoadon NVARCHAR(50),@tenkhachhang NVARCHAR(50),@tongtien INT, @trangthai BIT, @ngaytao DATETIME
AS
BEGIN
	INSERT INTO dbo.HoaDon
	( MaHD,TenKH,TongTien,TrangThai,NgayTao
	)
	VALUES
	(@mahoadon, @tenkhachhang, @tongtien, 1,@ngaytao
	    )
END
GO
ALTER TABLE dbo.KhachHang ADD NgaySinh DATE
GO

--Them khach hang
ALTER PROC pro_AddUser
@cmnd NVARCHAR(15), @hovaten NVARCHAR(250), @ngaysinh DATE, @sdt nvarchar(10), @diachi nvarchar(250)
AS
BEGIN
	 INSERT INTO dbo.KhachHang
	 (CMND, HovaTen,NgaySinh,SDT,DiaChi)
	 VALUES
	 (@cmnd,@hovaten,@ngaysinh, @sdt, @diachi)
END
GO
EXEC pro_AddUser @cmnd='234',@hovaten = 'tai',@ngaysinh = '2000-12-12', @sdt='123', @diachi='1'

SELECT * FROM dbo.KhachHang
GO

--UPDATE khach hang
ALTER PROC pro_UpdateUser
@cmnd NVARCHAR(15), @hovaten NVARCHAR(250), @ngaysinh DATE, @sdt nvarchar(10), @diachi nvarchar(250)
AS
BEGIN
	UPDATE dbo.KhachHang
	SET HovaTen = @hovaten, NgaySinh = @ngaysinh, SDT = @sdt, DiaChi = @diachi
	WHERE @cmnd = CMND
END
GO

--Xoa khach hang---
CREATE PROC pro_DeleteUser
@cmnd NVARCHAR(15)
AS
BEGIN
	DELETE dbo.KhachHang
	WHERE @cmnd =CMND
END
GO

EXEC pro_UpdateUser @cmnd='123',@hovaten='tuong',@ngaysinh='2000-02-01',@sdt='012345',@diachi='quan 9'
EXEC pro_DeleteUser @cmnd='123'
GO

--Them san pham---
ALTER procedure pro_ThemSanPham @MaSach nvarchar(50), @TenSach nvarchar(50), @TacGia nvarchar(50),
@NXB nvarchar(100), @MoTa nvarchar(1000), @Danhmuc nvarchar(50), @SoLuongTon int, @Gia int 
as
Begin
Insert Into SanPham(MaSach,TenSach,TacGia,NXB,MoTa,Danhmuc,SoLuongTon,Gia,TrangThai)
values (@MaSach , @TenSach , @TacGia,
@NXB , @MoTa , @Danhmuc, @SoLuongTon , @Gia  , 1)
end
GO

exec pro_SuaSanPham @MaSach = '3', @TenSach = 'tuandei', @TacGia ='tuan',
@NXB = 'tuan', @MoTa= 'deptrai', @Danhmuc = 'fatashi', @SoLuongTon= 2, @Gia= 2000000 
GO
SELECT * FROM dbo.SanPham

--sửa thông tin Sach---
ALTER procedure pro_SuaSanPham 
@MaSach nvarchar(50), @TenSach nvarchar(50), @TacGia nvarchar(50),
@NXB nvarchar(100), @MoTa nvarchar(1000), @Danhmuc nvarchar(50), @SoLuongTon int, @Gia int 
as
Begin
	Update SanPham set TenSach = @TenSach ,TacGia = @TacGia,
	NXB=@NXB , MoTa=@MoTa , Danhmuc=@Danhmuc,SoLuongTon= @SoLuongTon ,Gia= @Gia
	where @MaSach = MaSach
end
GO

--Xoa Sach---
ALTER procedure pro_XoaSanPham @MaSach nvarchar(50)
as
Begin
	Delete SanPham
	Where MaSach = @MaSach
end
go