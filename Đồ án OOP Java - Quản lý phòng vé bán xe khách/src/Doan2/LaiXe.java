package Doan2;

import java.util.*;


import java.io.*;

public class LaiXe extends Nhanvien
{
	protected int iPhucap;
	protected ArrayList<LaiXe> dslaixe = new ArrayList<LaiXe>();
	BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
	//
	public int getPhucap()
	{
		return this.iPhucap;
	}
	public void setPhucap(int value)
	{
		this.iPhucap = value;
	}
	public ArrayList<LaiXe> getdslaixe()
	{
		return this.dslaixe;
	}
	public void setDslaixe(ArrayList<LaiXe> value)
	{
		this.dslaixe = value;
	}
	public LaiXe()
	{
		super();

	}
	//
	public void Nhap() throws IOException
	{
		super.Nhap();
		System.out.print("Nhập phụ cấp: ");
		this.iPhucap = Integer.parseInt(input.readLine());
		this.iLuong = tinhluong();
	}
	//
	@Override
	public void Xuat()
	{
		System.out.println("     -----------------------------------------------------DANH SÁCH NHÂN VIÊN LÁI XE-------------------------------------------------------");
		System.out.println("     ______________________________________________________________________________________________________________________________________");
		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã nhân viên"));
		System.out.print(String.format(" %1$-19s |", "Họ và tên "));
		System.out.print(String.format(" %1$-15s |", "Số CMND"));
		System.out.print(String.format(" %1$-12s |", "Năm sinh"));
		System.out.print(String.format(" %1$-12s |", "Ngày công"));
		System.out.print(String.format(" %1$-19s |", "Lương cơ bản"));
		System.out.println(String.format(" %1$-20s |", "Lương chính thức" + " $"));
		System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------");
		for (int i = 0; i < dslaixe.size(); i++)
		{
			System.out.print(String.format("%1$8s |", i + 1));
			System.out.print(String.format(" %1$-12s |", dslaixe.get(i).iManv));
			System.out.print(String.format(" %1$-19s |", dslaixe.get(i).sHoten));
			System.out.print(String.format(" %1$-15s |", dslaixe.get(i).iCMND));
			System.out.print(String.format(" %1$-12s |", dslaixe.get(i).iNamsinh));
			System.out.print(String.format(" %1$-12s |", dslaixe.get(i).iNgaycong));
			System.out.print(String.format(" %1$-19s |", dslaixe.get(i).iLuongcb));
			System.out.println(String.format(" %1$-20s |", dslaixe.get(i).iLuong + " $"));
			System.out.println("    ------------------------------------------------------------------------------------------------------------------------------------------");
		}
	}
	//
	@Override
	public int tinhluong()
	{
		this.iLuong = this.iNgaycong * this.getPhucap() + this.iLuong;
		return this.iLuong;
	}
	@Override
	public void GhifileNv(String filename) throws IOException
	{
		BufferedWriter pw = new BufferedWriter(new FileWriter(filename)) ;
		for(int i=0;i<dslaixe.size();i++)
		{
			pw.write(dslaixe.get(i).getManv()+ "\n");
			pw.write(dslaixe.get(i).getHoten() + "\n");
			pw.write(dslaixe.get(i).getCMND()+ "\n");
			pw.write(dslaixe.get(i).getNamsinh()+ "\n");
			pw.write(dslaixe.get(i).getNgaycong()+ "\n");
			pw.write(dslaixe.get(i).getLuongcb()+ "\n");
			pw.write(dslaixe.get(i).getPhucap()+ "\n");
			pw.write(dslaixe.get(i).getLuong()+ "\n");
		}
		pw.close();
		dslaixe.clear();	
	}
	@Override
	public void DocfileNv(String filename) throws IOException {
		// TODO Auto-generated method stub
		FileReader fp = new FileReader(filename);
		BufferedReader rd = new BufferedReader(fp);
		int dem = 0;
		while (rd.readLine() != null)
		{
			dem++;
		}
		int size = dem / 8;
		rd.close();
		fp.close();
		FileReader fp1 = new FileReader(filename);
		BufferedReader rd1 = new BufferedReader(fp1);
		for (int i = 0; i < size; i++)
		{
			LaiXe lx = new LaiXe();
			lx.setManv(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setHoten(rd1.readLine());
			lx.setCMND(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setNamsinh(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setNgaycong(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setLuongcb(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setPhucap(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setLuong(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			dslaixe.add(lx);
		}
		fp1.close();
		rd1.close();

	}
	@Override
	public void Them() throws IOException {
		// TODO Auto-generated method stub
		int n;
		System.out.print("Số nhân viên lái xe muốn nhập: ");
		n = Integer.parseInt(input.readLine());
		for (int i = 0; i < n; i++)
		{
			LaiXe lx = new LaiXe();
			lx.Nhap();
			dslaixe.add(lx);
		}

	}
	@Override
	public void Xoa(int temp) {
		// TODO Auto-generated method stub
		ArrayList<LaiXe> tm = new ArrayList<LaiXe>();
		ArrayList<LaiXe> tam = new ArrayList<LaiXe>();
		tm = dslaixe;
		dslaixe = tam;
		tam = tm;
		temp = temp - 1;
		// Neu temp <= 0 => Xoa dau
		if (temp < 0)
		{
			temp = 0;
		}
		// Neu temp >= n => Xoa cuoi
		else if (temp >= tam.size())
		{
			temp = tam.size() - 1;
		}
		// Dich chuyen mang
		for (int i = 0; i < tam.size(); i++)
		{
			LaiXe TT = new LaiXe();
			if (i != temp)
			{
				TT = tam.get(i);
				dslaixe.add(TT);
			}
		}

	}
	@Override
	public void Sua(int temp) throws IOException {
		// TODO Auto-generated method stub
		temp = temp - 1;
		LaiXe lxmoi = new LaiXe();
		lxmoi.Nhap();
		dslaixe.set(temp, lxmoi);

	}
	public static boolean opGreaterThan(LaiXe a, LaiXe b)
	{
			if (a.iLuong < b.iLuong)
				{
					return false;
				}
				return true;
	}
	public static boolean opLessThan(LaiXe a, LaiXe b)
	{
			if (a.iLuong > b.iLuong)
				{
					return false;
				}
				return true;
	}

	@Override
	public void sort() throws IOException {
		// TODO Auto-generated method stub
		LaiXe t;
		for (int i = 0; i < dslaixe.size() - 1; i++)
		{
			for (int j = i + 1; j < dslaixe.size(); j++)
			{
				if (opGreaterThan(dslaixe.get(i), dslaixe.get(j)))
				{
					t = dslaixe.get(i);
					dslaixe.set(i, dslaixe.get(j));
					//dslaixe.get(i).equals(dslaixe.get(j));
					dslaixe.set(j, t);
				}
			}
		}
		GhifileNv("dslaixe.txt");
		dslaixe.clear();
	}
	@Override
	public void search() throws IOException {
		// TODO Auto-generated method stub
		int dem1 = 0;
		System.out.println("Nhập họ và tên nhân viên lái xe cần tìm: ");
		String NV = input.readLine();
		System.out.println("     _________________________________________________________________________________________________________________________________________");
		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã nhân viên"));
		System.out.print(String.format(" %1$-19s |", "Họ và tên "));
		System.out.print(String.format(" %1$-15s |", "Số CMND"));
		System.out.print(String.format(" %1$-12s |", "Năm sinh"));
		System.out.print(String.format(" %1$-12s |", "Ngày công"));
		System.out.print(String.format(" %1$-19s |", "Lương cơ bản"));
		System.out.println(String.format(" %1$-20s |", "Lương chính thức" + " $"));
		System.out.println("    ------------------------------------------------------------------------------------------------------------------------------------------");
		for (int i = 0; i < dslaixe.size(); i++)
		{
			if (NV.equals(dslaixe.get(i).sHoten))
			{
				dem1++;
				System.out.print(String.format("%1$8s |", i + 1));
				System.out.print(String.format(" %1$-12s |", dslaixe.get(i).iManv));
				System.out.print(String.format(" %1$-19s |", dslaixe.get(i).sHoten));
				System.out.print(String.format(" %1$-15s |", dslaixe.get(i).iCMND));
				System.out.print(String.format(" %1$-12s |", dslaixe.get(i).iNamsinh));
				System.out.print(String.format(" %1$-12s |", dslaixe.get(i).iNgaycong));
				System.out.print(String.format(" %1$-19s |", dslaixe.get(i).iLuongcb));
				System.out.println(String.format(" %1$-20s |", dslaixe.get(i).iLuong + " $"));
				System.out.println("   ----------------------------------------------------------------------------------------------------------------------------------");
			}
		}
			if (dem1 == 0)
			{
				System.out.println("---> không tìm thấy <--- ");
			}

	}
	@Override
	public void luongmax() {
		// TODO Auto-generated method stub
		System.out.println("     _____________________________________________________NHÂN VIÊN CÓ LƯƠNG CAO NHẤT_______________________________________________________");

		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã nhân viên"));
		System.out.print(String.format(" %1$-19s |", "Họ và tên "));
		System.out.print(String.format(" %1$-15s |", "Số CMND"));
		System.out.print(String.format(" %1$-12s |", "Năm sinh"));
		System.out.print(String.format(" %1$-12s |", "Ngày công"));
		System.out.print(String.format(" %1$-19s |", "Lương cơ bản"));
		System.out.println(String.format(" %1$-20s |", "Lương chính thức" + " $"));
		System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------");
		double maxve = 0;
		int vt = 0;
		for (int i = 0; i < dslaixe.size(); i++)
		{
			if (dslaixe.get(i).tinhluong() > maxve)
			{
				maxve = dslaixe.get(i).tinhluong();
				vt = i;
			}
		}
		System.out.print(String.format("%1$8s |", vt + 1));
		System.out.print(String.format(" %1$-12s |", dslaixe.get(vt).iManv));
		System.out.print(String.format(" %1$-19s |", dslaixe.get(vt).sHoten));
		System.out.print(String.format(" %1$-15s |", dslaixe.get(vt).iCMND));
		System.out.print(String.format(" %1$-12s |", dslaixe.get(vt).iNamsinh));
		System.out.print(String.format(" %1$-12s |", dslaixe.get(vt).iNgaycong));
		System.out.print(String.format(" %1$-19s |", dslaixe.get(vt).iLuongcb));
		System.out.println(String.format(" %1$-20s |", dslaixe.get(vt).iLuong + " $"));
		System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------");

	}
	@Override
	public void luongmin() {
		// TODO Auto-generated method stub
		System.out.println("     ______________________________________________________NHÂN VIÊN CÓ LƯƠNG THẤP NHẤT_____________________________________________________");

		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã nhân viên"));
		System.out.print(String.format(" %1$-19s |", "Họ và tên "));
		System.out.print(String.format(" %1$-15s |", "Số CMND"));
		System.out.print(String.format(" %1$-12s |", "Năm sinh"));
		System.out.print(String.format(" %1$-12s |", "Ngày công"));
		System.out.print(String.format(" %1$-19s |", "Lương cơ bản"));
		System.out.println(String.format(" %1$-20s |", "Lương chính thức" + " $"));
		System.out.println("    ---------------------------------------------------------------------------------------------------------------------------------------");
		double maxve = dslaixe.get(0).tinhluong();
		int vt = 0;
		for (int i = 0; i < dslaixe.size(); i++)
		{
			if (dslaixe.get(i).tinhluong() < maxve)
			{
				maxve = dslaixe.get(i).tinhluong();
				vt = i;
			}
		}
		System.out.print(String.format("%1$8s |", vt + 1));
		System.out.print(String.format(" %1$-12s |", dslaixe.get(vt).iManv));
		System.out.print(String.format(" %1$-19s |", dslaixe.get(vt).sHoten));
		System.out.print(String.format(" %1$-15s |", dslaixe.get(vt).iCMND));
		System.out.print(String.format(" %1$-12s |", dslaixe.get(vt).iNamsinh));
		System.out.print(String.format(" %1$-12s |", dslaixe.get(vt).iNgaycong));
		System.out.print(String.format(" %1$-19s |", dslaixe.get(vt).iLuongcb));
		System.out.println(String.format(" %1$-20s |", dslaixe.get(vt).iLuong + " $"));
		System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------");

	}
}
