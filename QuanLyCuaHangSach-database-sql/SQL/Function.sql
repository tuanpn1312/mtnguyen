-- tinh tong doanh thu
ALTER function fun_tinhtongdoanhthu()
returns int
as
begin
declare @tongdoanhthu int
select @tongdoanhthu  = sum(TongTien)
from HoaDon
return @tongdoanhthu
end
 GO
 
 -- tinh tong sach ban duoc
ALTER function fun_tinhtongsachbanduoc()
returns int
as
begin
declare @tongsachbanduoc int
select @tongsachbanduoc  = sum(ChitietHD.SoLuong)
from ChitietHD
return @tongsachbanduoc
end
go
--tinhs tong khach hang
ALTER function fun_tinhtongsokhachhang()
returns int
as
begin
declare @tongsokhachhang int
select @tongsokhachhang  = count(*)
from KhachHang
return @tongsokhachhang
END
GO
--Tính tuổi khách hàng
ALTER function fun_tinhtuoikhachhang(@CMND nvarchar)
returns int
as
begin
declare @tuoi int;
select @tuoi = DATEDIFF(year, NgaySinh, GETDATE())
from KhachHang
where CMND = @CMND;
return @tuoi;
END
GO

--Dang nhap
ALTER function Login_Check(@usr nvarchar(50), @pass nvarchar(50))
returns int
as
begin
	declare @chucvu nvarchar(50), @usrTemp nvarchar(50),@passTemp nvarchar(50);
	set @chucvu = -1
	select @usrTemp =DangNhap.TenDangNhap, @passTemp = DangNhap.MatKhau, @chucvu =DangNhap.ChucVu
	from DangNhap 
	where DangNhap.TenDangNhap = @usr AND DangNhap.MatKhau = @pass;
	if(@usrTemp !='' And @passTemp !='')
		begin 
			return @chucvu;
		end
		return @chucvu;
END
GO
  
--Lay so luong sach trong kho
CREATE FUNCTION GetAmout(@masach NVARCHAR(50))
RETURNS INT
AS
BEGIN
	DECLARE @masachTemp NVARCHAR(50), @soluong INT, @status BIT;
	SELECT @masachTemp = MaSach, @soluong = SoLuongTon
	FROM dbo.SanPham
	WHERE MaSach = @masach AND TrangThai = 'True';
	IF(@soluong > 0 )
	BEGIN
	    RETURN @soluong;
	END
		RETURN 0;
END
GO
SELECT dbo.GetAmout('ms01')