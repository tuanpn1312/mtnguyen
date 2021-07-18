package Doan2;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStreamReader;

public abstract class Chuyenxe
{
	protected int iMaso;
	protected String sTentaixe;
	protected String sBienso;
	protected double iDoanhthu;
	protected double iGiave;
	protected int iSove;
	BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
	//
	public int getMaso()
	{
		return this.iMaso;
	}
	public void setMaso(int value)
	{
		this.iMaso = value;
	}
	public String getTentaixe()
	{
		return this.sTentaixe;
	}
	public void setTentaixe(String value)
	{
		this.sTentaixe = value;
	}
	public String getBienso()
	{
		return this.sBienso;
	}
	public void setBienso(String value)
	{
		this.sBienso = value;
	}
	public double getDoanhthu()
	{
		return this.iDoanhthu;
	}
	public void setDoanhthu(Double value)
	{
		this.iDoanhthu = value;
	}
	public double getGiave()
	{
		return this.iGiave;
	}
	public void setGiave(Double value)
	{
		this.iGiave = value;
	}
	public int getSove()
	{
		return this.iSove;
	}
	public void setSove(int value)
	{
		this.iSove = value;
	}
	//
	public Chuyenxe()
	{

	}
	//
	public void Nhap() throws  IOException
	{
		System.out.print("Nhập mã số tuyến : ");
		this.iMaso = Integer.parseInt(input.readLine());
		System.out.print("Nhập tên tài xế: ");
		this.sTentaixe = input.readLine();
		System.out.print("Nhập biển số: ");
		this.sBienso = input.readLine();
		System.out.print("Nhập giá vé: ");
		this.iGiave = Double.parseDouble(input.readLine());
		System.out.print("Nhập số vé: ");
		this.iSove = Integer.parseInt(input.readLine());
	}
	public abstract void Xuat();
	public abstract void GhifileTxt(String filename) throws IOException;
	public abstract void DocfileTxt(String filename) throws FileNotFoundException, IOException;
	public abstract double Tinhdoanhthu();
	public abstract void Them() throws NumberFormatException, IOException;
	public abstract void Sua(int temp) throws IOException;
	public abstract void Xoa(int temp) throws IOException;
	public abstract void Sort() throws IOException;
	public abstract void Search() throws NumberFormatException, IOException;
	public abstract void chuyenmax();
	public abstract void chuyenmin();

}
