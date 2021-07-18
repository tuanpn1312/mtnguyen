package Doan2;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class Noithanh extends Chuyenxe{

	private String sLotrinh;
	private String sTenbanve;
	protected int iSokm;
	private int iSovebanduoc;
	private ArrayList<Noithanh> dsNoithanh = new ArrayList<Noithanh>();
	BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
	//
	public int getSokm()
	{
		return this.iSokm;
	}
	public void setSokm(int value)
	{
		this.iSokm = value;
	}
	public String getTenbanve()
	{
		return this.sTenbanve;
	}
	public void setTenbanve(String value)
	{
		this.sTenbanve = value;
	}
	public String getLotrinh()
	{
		return this.sLotrinh;
	}
	public void setLotrinh(String value)
	{
		this.sLotrinh = value;
	}
	public int getSovebanduoc()
	{
		return this.iSovebanduoc;
	}
	public void setSovebanduoc(int value)
	{
		this.iSovebanduoc = value;
	}
	public ArrayList<Noithanh> getDsNoithanh()
	{
		return this.dsNoithanh;
	}
	public void setDsNoithanh(ArrayList<Noithanh> value)
	{
		this.dsNoithanh = value;
	}
	//
	public Noithanh()
	{
		super();

	}
	public void Nhap() throws IOException
	{
		super.Nhap();
		System.out.print("Nhập lộ trình: ");
		this.sLotrinh = input.readLine();
		System.out.print("Nhập chiều dài quãng đường: ");
		this.iSokm = Integer.parseInt(input.readLine());
		System.out.print("Nhập tên nhân viên bán vé: ");
		this.sTenbanve = input.readLine();
		System.out.print("Nhập số vé bán được: ");
		this.iSovebanduoc = Integer.parseInt(input.readLine());
		this.iDoanhthu = Tinhdoanhthu();
	}
	@Override
	public void Xuat() {
		// TODO Auto-generated method stub
		System.out.println("     -------------------------------------------------------------------------------------DANH SÁCH CÁC CHUYẾN NỘI THÀNH---------------------------------------------------------------------");
		System.out.println("     ________________________________________________________________________________________________________________________________________________________________________________________");
		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
		System.out.print(String.format(" %1$-19s |", "Tên tài xế "));
		System.out.print(String.format(" %1$-15s |", "Biển số"));
		System.out.print(String.format(" %1$-18s |", "Lộ trình"));
		System.out.print(String.format(" %1$-15s |", "Quãng đường"));
		System.out.print(String.format(" %1$-12s |", "Gía vé"));
		System.out.print(String.format(" %1$-12s |", "Số vé"));
		System.out.print(String.format(" %1$-15s |", "Số vé bán được"));
		System.out.print(String.format(" %1$-18s |", "Tên bán vé"));
		System.out.println(String.format(" %1$-12s |", "Doanh thu"));
		System.out.println("    -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
		for (int i = 0; i < dsNoithanh.size(); i++)
		{
			System.out.print(String.format("%1$8s |", i + 1));
			System.out.print(String.format(" %1$-12s |", dsNoithanh.get(i).iMaso));
			System.out.print(String.format(" %1$-19s |", dsNoithanh.get(i).sTentaixe));
			System.out.print(String.format(" %1$-15s |", dsNoithanh.get(i).sBienso));
			System.out.print(String.format(" %1$-18s |", dsNoithanh.get(i).sLotrinh));
			System.out.print(String.format(" %1$-15s |", dsNoithanh.get(i).iSokm));
			System.out.print(String.format(" %1$-12s |", dsNoithanh.get(i).iGiave));
			System.out.print(String.format(" %1$-12s |", dsNoithanh.get(i).iSove));
			System.out.print(String.format(" %1$-15s |", dsNoithanh.get(i).iSovebanduoc));
			System.out.print(String.format(" %1$-18s |", dsNoithanh.get(i).sTenbanve));
			System.out.println(String.format(" %1$-12s |", dsNoithanh.get(i).iDoanhthu));
			System.out.println("    -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
		}

	}

	@Override
	public void GhifileTxt(String filename) throws IOException {
		// TODO Auto-generated method stub
		BufferedWriter swrite = new BufferedWriter(new FileWriter(filename)) ;
		for (int i = 0; i < dsNoithanh.size(); i++)
		{
			swrite.write(dsNoithanh.get(i).getMaso()+ "\n");
			swrite.write(dsNoithanh.get(i).getTentaixe()+ "\n");
			swrite.write(dsNoithanh.get(i).getBienso()+ "\n");
			swrite.write(dsNoithanh.get(i).getLotrinh()+ "\n");
			swrite.write(dsNoithanh.get(i).getSokm()+ "\n");
			swrite.write(dsNoithanh.get(i).getGiave()+ "\n");
			swrite.write(dsNoithanh.get(i).getSove()+ "\n");
			swrite.write(dsNoithanh.get(i).getSovebanduoc()+ "\n");
			swrite.write(dsNoithanh.get(i).getTenbanve()+ "\n");
			swrite.write(dsNoithanh.get(i).getDoanhthu()+ "\n");
		}
		swrite.close();
		dsNoithanh.clear();
	}

	@Override
	public void DocfileTxt(String filename) throws IOException {
		// TODO Auto-generated method stub
		FileReader fp = new FileReader(filename);
		BufferedReader rd = new BufferedReader(fp);
		int dem = 0;
		while (rd.readLine()!= null)
		{
			dem++;
		}
		int size = dem / 10;
		rd.close();
		fp.close();
		FileReader fp1 = new FileReader(filename);
		BufferedReader rd1 = new BufferedReader(fp1);
		for (int i = 0; i < size; i++)
		{
			Noithanh lx = new Noithanh();
			lx.setMaso(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setTentaixe(rd1.readLine());
			lx.setBienso(rd1.readLine());
			lx.setLotrinh(rd1.readLine());
			lx.setSokm(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setGiave(Double.parseDouble(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setSove(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setSovebanduoc(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
			lx.setTenbanve(rd1.readLine());
			lx.setDoanhthu(Double.parseDouble(rd1.readLine().replaceAll("\\uFEFF", "")));
			dsNoithanh.add(lx);
		}
		fp1.close();
		rd1.close();

	}

	@Override
	public double Tinhdoanhthu() {
		// TODO Auto-generated method stub
		return this.iSovebanduoc * this.iGiave;
	}

	@Override
	public void Them() throws NumberFormatException, IOException {
		// TODO Auto-generated method stub
		int n;
		System.out.print("Số chuyến xe nội thành muốn nhập: ");
		n = Integer.parseInt(input.readLine());
		for (int i = 0; i < n; i++)
		{
			System.out.println("Chuyến số :" + i);
			Noithanh lx = new Noithanh();
			lx.Nhap();
			dsNoithanh.add(lx);
		}
	}

	@Override
	public void Sua(int temp) throws IOException {
		// TODO Auto-generated method stub
		temp = temp - 1;
        Noithanh lxmoi = new Noithanh();
        lxmoi.Nhap();
        dsNoithanh.set(temp,lxmoi);
	}

	@Override
	public void Xoa(int temp) {
		// TODO Auto-generated method stub
		ArrayList<Noithanh> tm = new ArrayList<Noithanh>();
		ArrayList<Noithanh> tam = new ArrayList<Noithanh>();
		tm = dsNoithanh;
		dsNoithanh = tam;
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
			Noithanh TT = new Noithanh();
			if (i != temp)
			{
				TT = tam.get(i);
				dsNoithanh.add(TT);
			}
		}

	}


	 public static boolean opGreaterThan(Noithanh a, Noithanh b)
	 {
				if (a.Tinhdoanhthu() < b.Tinhdoanhthu())
				{
					return false;
				}
				return true;
	 }
			public static boolean opLessThan(Noithanh a, Noithanh b)
			{
				if (a.Tinhdoanhthu() > b.Tinhdoanhthu())
				{
					return false;
				}
				return true;
			}

	@Override
	public void Sort() throws IOException {
		// TODO Auto-generated method stub
		Noithanh t;
		for (int i = 0; i < dsNoithanh.size() - 1; i++)
		{
			for (int j = i + 1; j < dsNoithanh.size(); j++)
			{
				if (opGreaterThan(dsNoithanh.get(i), dsNoithanh.get(j)))
				{
					t = dsNoithanh.get(i);
					dsNoithanh.set(i, dsNoithanh.get(j));
					dsNoithanh.set(j,t);
				}
			}
		}
		GhifileTxt("dsnoithanh.txt");
		dsNoithanh.clear();
	}

	@Override
	public void Search() throws NumberFormatException, IOException {
		// TODO Auto-generated method stub
		int dem1 = 0;
		System.out.println("Nhập mã chuyến cần tìm: ");
		int NV = Integer.parseInt(input.readLine());
		System.out.println("     ------------------------------------------------------------------------------------DANH SÁCH CÁC CHUYẾN NỘI THÀNH---------------------------------------------------------------");
		System.out.println("     _______________________________________________________________________________________________________________________________________________________________________________________________");
		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
		System.out.print(String.format(" %1$-19s |", "Tên tài xế "));
		System.out.print(String.format(" %1$-15s |", "Biển số"));
		System.out.print(String.format(" %1$-18s |", "Lộ trình"));
		System.out.print(String.format(" %1$-15s |", "Quãng đường"));
		System.out.print(String.format(" %1$-12s |", "Gía vé"));
		System.out.print(String.format(" %1$-12s |", "Số vé"));
		System.out.print(String.format(" %1$-15s |", "Số vé bán được"));
		System.out.print(String.format(" %1$-18s |", "Tên bán vé"));
		System.out.println(String.format(" %1$-12s |", "Doanh thu"));
		System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
		for (int i = 0; i < dsNoithanh.size(); i++)
		{
			if (dsNoithanh.get(i).iMaso == NV)
			{
				dem1++;
				System.out.print(String.format("%1$8s |", i + 1));
				System.out.print(String.format(" %1$-12s |", dsNoithanh.get(i).iMaso));
				System.out.print(String.format(" %1$-19s |", dsNoithanh.get(i).sTentaixe));
				System.out.print(String.format(" %1$-15s |", dsNoithanh.get(i).sBienso));
				System.out.print(String.format(" %1$-18s |", dsNoithanh.get(i).sLotrinh));
				System.out.print(String.format(" %1$-15s |", dsNoithanh.get(i).iSokm));
				System.out.print(String.format(" %1$-12s |", dsNoithanh.get(i).iGiave));
				System.out.print(String.format(" %1$-12s |", dsNoithanh.get(i).iSove));
				System.out.print(String.format(" %1$-15s |", dsNoithanh.get(i).iSovebanduoc));
				System.out.print(String.format(" %1$-18s |", dsNoithanh.get(i).sTenbanve));
				System.out.println(String.format(" %1$-12s |", dsNoithanh.get(i).iDoanhthu));
				System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

			}
		}
		if (dem1 == 0)
		{
			System.out.println("---> không tìm thấy <--- ");
		}

	}

	@Override
	public void chuyenmax() {
		// TODO Auto-generated method stub
		System.out.println("     ------------------------------------------------------------------------------------CHUYẾN NỘI THÀNH CÓ DOANH THU CAO NHẤT-------------------------------------------------------");
		System.out.println("     _______________________________________________________________________________________________________________________________________________________________________________________________");
		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
		System.out.print(String.format(" %1$-19s |", "Tên tài xế "));
		System.out.print(String.format(" %1$-15s |", "Biển số"));
		System.out.print(String.format(" %1$-18s |", "Lộ trình"));
		System.out.print(String.format(" %1$-15s |", "Quãng đường"));
		System.out.print(String.format(" %1$-12s |", "Gía vé"));
		System.out.print(String.format(" %1$-12s |", "Số vé"));
		System.out.print(String.format(" %1$-15s |", "Số vé bán được"));
		System.out.print(String.format(" %1$-18s |", "Tên bán vé"));
		System.out.println(String.format(" %1$-12s |", "Doanh thu"));
		System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

		double maxve = dsNoithanh.get(0).iDoanhthu;
		int vt = 0;
		for (int i = 0; i < dsNoithanh.size(); i++)
		{
			if (dsNoithanh.get(i).iDoanhthu > maxve)
			{
				maxve = dsNoithanh.get(i).iDoanhthu;
				vt = i;
			}
		}
		System.out.print(String.format("%1$8s |", vt + 1));
		System.out.print(String.format(" %1$-12s |", dsNoithanh.get(vt).iMaso));
		System.out.print(String.format(" %1$-19s |", dsNoithanh.get(vt).sTentaixe));
		System.out.print(String.format(" %1$-15s |", dsNoithanh.get(vt).sBienso));
		System.out.print(String.format(" %1$-18s |", dsNoithanh.get(vt).sLotrinh));
		System.out.print(String.format(" %1$-15s |", dsNoithanh.get(vt).iSokm));
		System.out.print(String.format(" %1$-12s |", dsNoithanh.get(vt).iGiave));
		System.out.print(String.format(" %1$-12s |", dsNoithanh.get(vt).iSove));
		System.out.print(String.format(" %1$-15s |", dsNoithanh.get(vt).iSovebanduoc));
		System.out.print(String.format(" %1$-18s |", dsNoithanh.get(vt).sTenbanve));
		System.out.println(String.format(" %1$-12s |", dsNoithanh.get(vt).iDoanhthu));
		System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

	}

	@Override
	public void chuyenmin() {
		// TODO Auto-generated method stub
		System.out.println("     ------------------------------------------------------------------------------------CHUYẾN NỘI THÀNH CÓ DOANH THU THẤP NHẤT-------------------------------------------------------");
		System.out.println("     _______________________________________________________________________________________________________________________________________________________________________________________________");
		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
		System.out.print(String.format(" %1$-19s |", "Tên tài xế "));
		System.out.print(String.format(" %1$-15s |", "Biển số"));
		System.out.print(String.format(" %1$-18s |", "Lộ trình"));
		System.out.print(String.format(" %1$-15s |", "Quãng đường"));
		System.out.print(String.format(" %1$-12s |", "Gía vé"));
		System.out.print(String.format(" %1$-12s |", "Số vé"));
		System.out.print(String.format(" %1$-15s |", "Số vé bán được"));
		System.out.print(String.format(" %1$-18s |", "Tên bán vé"));
		System.out.println(String.format(" %1$-12s |", "Doanh thu"));
		System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

		double maxve = dsNoithanh.get(0).iDoanhthu;
		int vt = 0;
		for (int i = 0; i < dsNoithanh.size(); i++)
		{
			if (dsNoithanh.get(i).iDoanhthu < maxve)
			{
				maxve = dsNoithanh.get(i).iDoanhthu;
				vt = i;
			}
		}
		System.out.print(String.format("%1$8s |", vt + 1));
		System.out.print(String.format(" %1$-12s |", dsNoithanh.get(vt).iMaso));
		System.out.print(String.format(" %1$-19s |", dsNoithanh.get(vt).sTentaixe));
		System.out.print(String.format(" %1$-15s |", dsNoithanh.get(vt).sBienso));
		System.out.print(String.format(" %1$-18s |", dsNoithanh.get(vt).sLotrinh));
		System.out.print(String.format(" %1$-15s |", dsNoithanh.get(vt).iSokm));
		System.out.print(String.format(" %1$-12s |", dsNoithanh.get(vt).iGiave));
		System.out.print(String.format(" %1$-12s |", dsNoithanh.get(vt).iSove));
		System.out.print(String.format(" %1$-15s |", dsNoithanh.get(vt).iSovebanduoc));
		System.out.print(String.format(" %1$-18s |", dsNoithanh.get(vt).sTenbanve));
		System.out.println(String.format(" %1$-12s |", dsNoithanh.get(vt).iDoanhthu));
		System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

	}

}
