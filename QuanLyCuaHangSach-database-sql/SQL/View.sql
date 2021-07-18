-- View Tat ca sach -- 
ALTER VIEW Tat_ca_sach_view AS
SELECT * 
FROM dbo.SanPham
WHERE TrangThai = 'True'
GO
SELECT * FROM Tat_ca_sach_rutgon_view
GO

--View sach Rut gon--
ALTER VIEW Tat_ca_sach_rutgon_view
AS
SELECT MaSach,TenSach,SoLuongTon,Gia
FROM dbo.SanPham
WHERE TrangThai='True'
GO
-- View Phan loai theo the loai -- 
CREATE VIEW Phan_loai_theo_SachThieuNhi_view AS 
SELECT *
FROM dbo.SanPham
WHERE Danhmuc = 'SachThieuNhi' AND TrangThai = 'true'
GO 

-- Tat ca khach hang -- 
CREATE VIEW Tat_ca_khach_hang_view AS 
SELECT *
FROM dbo.KhachHang
GO 

-- Don hang chua hoan thanh --
CREATE VIEW Don_hang_chua_hoan_thanh_view AS
SELECT *
FROM dbo.HoaDon
WHERE TrangThai = 'true'
GO

-- Top 5 sach duoc mua nhieu nhat --
CREATE VIEW Top_5_sach_duoc_mua_nhieu_nhat_view AS 
SELECT SanPham.MaSach, TenSach
FROM dbo.SanPham, (SELECT TOP(5) MaSach, COUNT(MaSach) AS Soluong FROM dbo.ChitietHD GROUP BY MaSach ORDER BY Soluong DESC) k
WHERE k.MaSach = SanPham.MaSach
GO

CREATE VIEW All_User_View
AS
SELECT * FROM dbo.KhachHang
GO

