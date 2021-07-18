package Doan2;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public abstract class Nhanvien
{
	protected int iManv;
	protected String sHoten;
	protected int iCMND;
	protected int iNamsinh;
	protected int iNgaycong;
	protected int iLuongcb;
	protected int iLuong;
	BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
	//
	public int getManv()
	{
		return this.iManv;
	}
	public void setManv(int value)
	{
		this.iManv = value;
	}
	public String getHoten()
	{
		return this.sHoten;
	}
	public void setHoten(String value)
	{
		this.sHoten = value;
	}
	public int getCMND()
	{
		return this.iCMND;
	}
	public void setCMND(int value)
	{
		this.iCMND = value;
	}
	public int getNamsinh()
	{
		return this.iNamsinh;
	}
	public void setNamsinh(int value)
	{
		this.iNamsinh = value;
	}
	public int getNgaycong()
	{
		return this.iNgaycong;
	}
	public void setNgaycong(int value)
	{
		this.iNgaycong = value;
	}
	public int getLuongcb()
	{
		return this.iLuongcb;
	}
	public void setLuongcb(int value)
	{
		this.iLuongcb = value;
	}
	public int getLuong()
	{
		return this.iLuong;
	}
	public void setLuong(int value)
	{
		this.iLuong = value;
	}
	//
	public Nhanvien()
	{

	}
	public Nhanvien(int manv, String hoten, int cmnd, int ngaycong, int namsinh, int luongcoban, int Luong)
	{
		this.iManv = manv;
		this.sHoten = hoten;
		this.iCMND = cmnd;
		this.iNgaycong = ngaycong;
		this.iNamsinh = namsinh;
		this.iLuongcb = luongcoban;
		this.iLuong = Luong;
	}
	public Nhanvien(int manv, String hoten, int cmnd, int ngaycong, int namsinh, int luongcoban)
	{
		this.iManv = manv;
		this.sHoten = hoten;
		this.iCMND = cmnd;
		this.iNgaycong = ngaycong;
		this.iNamsinh = namsinh;
		this.iLuongcb = luongcoban;
	}
	public Nhanvien(int manv, String hoten, int cmnd, int ngaycong, int namsinh)
	{
		this.iManv = manv;
		this.sHoten = hoten;
		this.iCMND = cmnd;
		this.iNamsinh = namsinh;
		this.iNgaycong = ngaycong;
	}
	public Nhanvien(int manv, String hoten, int cmnd, int ngaycong)
	{
		this.iManv = manv;
		this.sHoten = hoten;
		this.iCMND = cmnd;
		this.iNgaycong = ngaycong;
	}
	public Nhanvien(int manv, String hoten, int cmnd)
	{
		this.iManv = manv;
		this.sHoten = hoten;
		this.iCMND = cmnd;
	}
	public Nhanvien(int manv, String hoten)
	{
		this.iManv = manv;
		this.sHoten = hoten;
	}
	public Nhanvien(int manv)
	{
		this.iManv = manv;
	}
	public void Nhap() throws IOException
	{
		System.out.print("Nhập mã nhân viên: ");
		this.iManv = Integer.parseInt(input.readLine());
		System.out.print("Nhập họ và tên nhân viên: ");
		this.sHoten = input.readLine();
		System.out.print("Nhập cmnd: ");
		this.iCMND = Integer.parseInt(input.readLine());
		System.out.print("Nhập năm sinh: ");
		this.iNamsinh = Integer.parseInt(input.readLine());
		System.out.print("Nhập số ngày công: ");
		this.iNgaycong = Integer.parseInt(input.readLine());
		System.out.print("Nhập lương cơ bản: ");
		this.iLuongcb = Integer.parseInt(input.readLine());
	}
	//
	public abstract void Xuat();
	public abstract void GhifileNv(String filename) throws IOException;
	public abstract void DocfileNv(String filename) throws IOException;
	public abstract void Them() throws IOException;
	public abstract void Xoa(int temp);
	public abstract void Sua(int temp) throws IOException;
	public abstract int tinhluong();
	public abstract void sort() throws IOException; //sắp xếp tăng dần
	public abstract void search() throws IOException; //tìm kiếm theo tên
	public abstract void luongmax();
	public abstract void luongmin();
}