/* cập nhật hàng trong kho sau khi đặt hàng hoặc cập nhật */
ALTER TRIGGER trg_DatHang ON dbo.ChitietHD
AFTER INSERT 
AS 
BEGIN
	UPDATE dbo.SanPham
	SET SoLuongTon = SoLuongTon - (
		SELECT Inserted.SoLuong
		FROM inserted
		WHERE MaSach = Inserted.MaSach
	)
	FROM dbo.SanPham JOIN inserted 
	ON SanPham.MaSach = inserted.MaSach
END
GO

/* cập nhật hàng trong kho sau khi cập nhật đặt hàng */
CREATE TRIGGER trg_CapNhatDatHang on ChitietHD 
AFTER update 
AS
BEGIN
   UPDATE dbo.SanPham SET SoLuongTon = SoLuongTon -
	   (SELECT SoLuong FROM inserted WHERE MaSach = SanPham.MaSach) +
	   (SELECT SoLuong FROM deleted WHERE MaSach = SanPham.MaSach)
   FROM SanPham 
   JOIN deleted ON SanPham.MaSach = deleted.MaSach
end
GO

/* cập nhật hàng trong kho sau khi hủy đặt hàng */
create TRIGGER trg_HuyDatHang ON ChitietHD 
FOR DELETE 
AS 
BEGIN
	UPDATE SanPham
	SET SoLuongTon = SoLuongTon + (SELECT SoLuong FROM deleted WHERE MaSach = SanPham.MaSach)
	FROM SanPham 
	JOIN deleted ON SanPham.MaSach = deleted.MaSach
END
GO

--trigger sau khi sua san pham
ALTER trigger trig_saukhisuaSP on SanPham
after update
as
begin
	declare @MaSach nvarchar(50),@SoLuongTon int, @TrangThai bit
	Select @MaSach=inserted.MaSach
	From inserted;
Select @SoLuongTon= SoLuongTon
	from SanPham
	Where SanPham.MaSach = @MaSach
	if (@SoLuongTon=0)
	begin
		UPDATE SanPham set TrangThai = 'False'
		WHERE MaSach = @MaSach
	END
    ELSE
		begin
		UPDATE SanPham set TrangThai = 'True'
		WHERE MaSach = @MaSach
	END  
END




