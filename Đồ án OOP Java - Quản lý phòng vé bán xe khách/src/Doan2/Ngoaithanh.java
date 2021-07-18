package Doan2;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;

public class Ngoaithanh extends Chuyenxe implements CapnhatDoanhthuvasove
	{
		private int iSovedaban;
		private int iHaophi;
		private String sNoidi;
		private String sNoiden;
		private String sThoigiandi;
		private String sNgaydi;
		private ArrayList<Ngoaithanh> dsNgoaithanh = new ArrayList<Ngoaithanh>();
		BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
		//
		public ArrayList<Ngoaithanh> getDsNgoaithanh()
		{
			return this.dsNgoaithanh;
		}
		public void setDsNgoaithanh(ArrayList<Ngoaithanh> value)
		{
			this.dsNgoaithanh = value;
		}
		public int getSovedaban()
		{
			return this.iSovedaban;
		}
		public void setSovedaban(int value)
		{
			this.iSovedaban = value;
		}
		public int getHaophi()
		{
			return this.iHaophi;
		}
		public void setHaophi(int value)
		{
			this.iHaophi = value;
		}
		public String getNoidi()
		{
			return this.sNoidi;
		}
		public void setNoidi(String value)
		{
			this.sNoidi = value;
		}
		public String getNoiden()
		{
			return this.sNoiden;
		}
		public void setNoiden(String value)
		{
			this.sNoiden = value;
		}
		public String getThoigiandi()
		{
			return this.sThoigiandi;
		}
		public void setThoigiandi(String value)
		{
			this.sThoigiandi = value;
		}
		public String getNgaydi()
		{
			return this.sNgaydi;
		}
		public void setNgaydi(String value)
		{
			this.sNgaydi = value;
		}
		public Ngoaithanh()
		{
			super();

		}
		public void Nhap() throws IOException
		{
			super.Nhap();
			System.out.print("Nhập nơi đi: ");
			this.sNoidi = input.readLine();
			System.out.print("Nhập nơi đến: ");
			this.sNoiden = input.readLine();
			System.out.print("Nhập thời gian đi: ");
			this.sThoigiandi = input.readLine();
			System.out.print("Nhập ngày đi: ");
			this.sNgaydi = input.readLine();
			this.iSovedaban = 0;
			System.out.print("Nhập hao phí: ");
			this.iHaophi = Integer.parseInt(input.readLine());
			this.iDoanhthu = 0;
			this.iDoanhthu = Tinhdoanhthu();
		}
		@Override
		public void Xuat()
		{
			System.out.println("     -----------------------------------------------------------------------------------DANH SÁCH CÁC CHUYẾN NGOẠI THÀNH---------------------------------------------------------------------------------");
			System.out.println("     ____________________________________________________________________________________________________________________________________________________________________________________________________");
			System.out.print(String.format("%1$8s |", "STT"));
			System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
			System.out.print(String.format(" %1$-19s |", "Tên tài xế "));
			System.out.print(String.format(" %1$-12s |", "Biển số"));
			System.out.print(String.format(" %1$-12s |", "Nơi đi"));
			System.out.print(String.format(" %1$-12s |", "Nơi đến"));
			System.out.print(String.format(" %1$-12s |", "Thời gian đi"));
			System.out.print(String.format(" %1$-12s |", "Ngày đi"));
			System.out.print(String.format(" %1$-12s |", "Gía vé"));
			System.out.print(String.format(" %1$-12s |", "Số vé"));
			System.out.print(String.format(" %1$-12s |", "Số vé đã bán"));
			System.out.print(String.format(" %1$-12s |", "Hao phí"));
			System.out.println(String.format(" %1$-12s |", "Doanh thu"));
			System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			for (int i = 0; i < dsNgoaithanh.size(); i++)
			{
				System.out.print(String.format("%1$8s |", i + 1));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iMaso));
				System.out.print(String.format(" %1$-19s |", dsNgoaithanh.get(i).sTentaixe));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sBienso));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sNoidi));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sNoiden));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sThoigiandi));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sNgaydi));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iGiave));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iSove));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iSovedaban));
				System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iHaophi));
				System.out.println(String.format(" %1$-12s |", dsNgoaithanh.get(i).iDoanhthu));
				System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			}
		}
		@Override
		public void Capnhatsaukhixoa(int machuyen, double giave) throws FileNotFoundException, IOException {
			// TODO Auto-generated method stub
			int temp;
			Ngoaithanh nt1 = new Ngoaithanh();
			Ngoaithanh nt2 = new Ngoaithanh();
			nt1.DocfileTxt("D:/dsngoaithanh.txt");
			temp = nt1.Searchmachuyen(machuyen);
			nt2 = nt1.ReturnNgoaithanh(temp + 1);
			nt2.iSovedaban = nt2.iSovedaban - 1;
			nt2.iDoanhthu = nt2.iDoanhthu - giave;
			nt1.Suasovedabanvadoanhthu(nt2, temp + 1);
			nt1.GhifileTxt("D:/dsngoaithanh.txt");

		}
		@Override
		public void Suasovedabanvadoanhthu(Ngoaithanh sua, int temp) {
			// TODO Auto-generated method stub
			for (int i = 0; i < dsNgoaithanh.size(); i++)
			{
							if (i == temp - 1)
							{
								dsNgoaithanh.set(i,sua);
							}
			}

		}
		@Override
		public int Searchmachuyen(int machuyen) {
			// TODO Auto-generated method stub
			int tam = 0;
            Ngoaithanh nt = new Ngoaithanh();
            for (int i = 0; i < dsNgoaithanh.size(); i++)
            {
                if (dsNgoaithanh.get(i).iMaso == machuyen) tam = i;
            }
            return tam;
		}
		@Override
		public Ngoaithanh ReturnNgoaithanh(int temp) {
			// TODO Auto-generated method stub
			Ngoaithanh tam = new Ngoaithanh();
			for (int i = 0; i < temp; i++)
			{
				tam = dsNgoaithanh.get(i);
			}
			return tam;
		}
		@Override
		public void GhifileTxt(String filename) throws IOException {
			// TODO Auto-generated method stub
			BufferedWriter swrite = new BufferedWriter(new FileWriter(filename)) ;
			for (int i = 0; i < dsNgoaithanh.size(); i++)
			{
				swrite.write(dsNgoaithanh.get(i).getMaso()+ "\n");
				swrite.write(dsNgoaithanh.get(i).getTentaixe()+ "\n");
				swrite.write(dsNgoaithanh.get(i).getBienso()+ "\n");
				swrite.write(dsNgoaithanh.get(i).getNoidi()+ "\n");
				swrite.write(dsNgoaithanh.get(i).getNoiden()+ "\n");
				swrite.write(dsNgoaithanh.get(i).getThoigiandi()+ "\n");
				swrite.write(dsNgoaithanh.get(i).getNgaydi()+ "\n");
				swrite.write(String.valueOf(dsNgoaithanh.get(i).getGiave())+ "\n");
				swrite.write(dsNgoaithanh.get(i).getSove()+ "\n");
				swrite.write(dsNgoaithanh.get(i).getSovedaban()+ "\n");
				swrite.write(dsNgoaithanh.get(i).getHaophi()+ "\n");
				swrite.write(String.valueOf(dsNgoaithanh.get(i).getDoanhthu())+ "\n");

			}
			swrite.close();
			dsNgoaithanh.clear();

		}
		@Override
		public void DocfileTxt(String filename) throws FileNotFoundException, IOException {
			// TODO Auto-generated method stub
			FileReader fp = new FileReader(filename);
			BufferedReader rd = new BufferedReader(fp);
			int dem = 0;
			while (rd.readLine() != null)
			{
				dem++;
			}
			int size = dem / 12;
			rd.close();
			fp.close();
			FileReader fp1 = new FileReader(filename);
			BufferedReader rd1 = new BufferedReader(fp1);
			for (int i = 0; i < size; i++)
			{
				Ngoaithanh lx = new Ngoaithanh();
				lx.setMaso(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
				lx.sTentaixe = rd1.readLine();
				lx.sBienso = rd1.readLine();
				lx.sNoidi = rd1.readLine();
				lx.sNoiden = rd1.readLine();
				lx.sThoigiandi = rd1.readLine();
				lx.sNgaydi = rd1.readLine();
				lx.setGiave(Double.parseDouble(rd1.readLine().replaceAll("\\uFEFF", "")));
				lx.setSove(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
				lx.setSovedaban(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
				lx.setHaophi(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
				lx.setDoanhthu(Double.parseDouble(rd1.readLine().replaceAll("\\uFEFF", "")));
				dsNgoaithanh.add(lx);
			}
			fp1.close();
			rd1.close();

		}
		@Override
		public double Tinhdoanhthu() {
			// TODO Auto-generated method stub
			 return this.iDoanhthu = this.iDoanhthu - this.iHaophi;
		}
		@Override
		public void Them() throws NumberFormatException, IOException {
			// TODO Auto-generated method stub
			int n;
			System.out.print("Số chuyến ngoại thành muốn nhập: ");
			n = Integer.parseInt(input.readLine());
			for (int i = 0; i < n; i++)
			{
				System.out.println("Chuyến thứ "+i);
				Ngoaithanh lx = new Ngoaithanh();
				lx.Nhap();
				dsNgoaithanh.add(lx);
			}

		}
		@Override
		public void Sua(int temp) throws IOException {
			// TODO Auto-generated method stub
			temp = temp - 1;
            Ngoaithanh lxmoi = new Ngoaithanh();
            lxmoi.Nhap();
            dsNgoaithanh.set(temp,lxmoi);
		}
		@Override
		public void Xoa(int temp) throws IOException {
			// TODO Auto-generated method stub
			ArrayList<Ngoaithanh> tm = new ArrayList<Ngoaithanh>();
			ArrayList<Ngoaithanh> tam = new ArrayList<Ngoaithanh>();
			tm = dsNgoaithanh;
			dsNgoaithanh = tam;
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
				Ngoaithanh TT = new Ngoaithanh();
				if (i != temp)
				{
					TT = tam.get(i);
					dsNgoaithanh.add(TT);
				}
				else
				{
					Vexe vx = new Vexe();
					vx.DocfileTxt("dsvx.txt");
					vx.Xoavexetheomachuyen(tam.get(i).iMaso);
					vx.GhifileTxt("dsvx.txt");
				}
			}

		}
		public static boolean opGreaterThan(Ngoaithanh a, Ngoaithanh b)
		{
			if (a.iDoanhthu < b.iDoanhthu)
			{
				return false;
			}
			return true;
		}
		public static boolean opLessThan(Ngoaithanh a, Ngoaithanh b)
		{
			if (a.iDoanhthu > b.iDoanhthu)
			{
				return false;
			}
			return true;
		}
		@Override
		public void Sort() throws IOException {
			// TODO Auto-generated method stub
			 Ngoaithanh t;
				for (int i = 0; i < dsNgoaithanh.size() - 1; i++)
				{
					for (int j = i + 1; j < dsNgoaithanh.size(); j++)
					{
						if (opGreaterThan(dsNgoaithanh.get(i), dsNgoaithanh.get(j)))
						{
							t = dsNgoaithanh.get(i);
							dsNgoaithanh.set(i, dsNgoaithanh.get(j));
							dsNgoaithanh.set(j,t);
						}
					}
				}
				GhifileTxt("dsngoaithanh.txt");
				dsNgoaithanh.clear();

		}
		@Override
		public void Search() throws NumberFormatException, IOException {
			// TODO Auto-generated method stub
			int dem1 = 0;
			System.out.println("Nhập mã chuyến cần tìm: ");
			int NV = Integer.parseInt(input.readLine());
			System.out.println("     ------------------------------------------------------------------------------------------DANH SÁCH TÌM KIẾM THEO MÃ CHUYẾN------------------------------------------------------------------------");
			System.out.println("     ___________________________________________________________________________________________________________________________________________________________________________________________________");
			System.out.print(String.format("%1$8s |", "STT"));
			System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
			System.out.print(String.format(" %1$-19s |", "Tên tài xế "));
			System.out.print(String.format(" %1$-12s |", "Biển số"));
			System.out.print(String.format(" %1$-12s |", "Nơi đi"));
			System.out.print(String.format(" %1$-12s |", "Nơi đến"));
			System.out.print(String.format(" %1$-12s |", "Thời gian đi"));
			System.out.print(String.format(" %1$-12s |", "Ngày đi"));
			System.out.print(String.format(" %1$-12s |", "Gía vé"));
			System.out.print(String.format(" %1$-12s |", "Số vé"));
			System.out.print(String.format(" %1$-12s |", "Số vé đã bán"));
			System.out.print(String.format(" %1$-12s |", "Hao phí"));
			System.out.println(String.format(" %1$-12s |", "Doanh thu"));
			System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			for (int i = 0; i < dsNgoaithanh.size(); i++)
			{
				if (dsNgoaithanh.get(i).iMaso == NV)
				{
					dem1++;
					System.out.print(String.format("%1$8s |", i + 1));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iMaso));
					System.out.print(String.format(" %1$-19s |", dsNgoaithanh.get(i).sTentaixe));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sBienso));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sNoidi));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sNoiden));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sThoigiandi));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).sNgaydi));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iGiave));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iSove));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iSovedaban));
					System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(i).iHaophi));
					System.out.println(String.format(" %1$-12s |", dsNgoaithanh.get(i).iDoanhthu));
					System.out.println("    ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
				}
			}
			if (dem1 == 0)
			{
				System.out.println("                                                                                      ---> không tìm thấy <--- ");
			}

		}
		@Override
		public void chuyenmax() {
			// TODO Auto-generated method stub
			System.out.println("     --------------------------------------------------------------------------------------CHUYẾN CÓ DOANH THU CAO NHẤT---------------------------------------------------------------------");
			System.out.println("     ___________________________________________________________________________________________________________________________________________________________________________________________________");
			System.out.print(String.format("%1$8s |", "STT"));
			System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
			System.out.print(String.format(" %1$-19s |", "Tên tài xế "));
			System.out.print(String.format(" %1$-12s |", "Biển số"));
			System.out.print(String.format(" %1$-12s |", "Nơi đi"));
			System.out.print(String.format(" %1$-12s |", "Nơi đến"));
			System.out.print(String.format(" %1$-12s |", "Thời gian đi"));
			System.out.print(String.format(" %1$-12s |", "Ngày đi"));
			System.out.print(String.format(" %1$-12s |", "Gía vé"));
			System.out.print(String.format(" %1$-12s |", "Số vé"));
			System.out.print(String.format(" %1$-12s |", "Số vé đã bán"));
			System.out.print(String.format(" %1$-12s |", "Hao phí"));
			System.out.println(String.format(" %1$-12s |", "Doanh thu"));
			System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

			double maxve = dsNgoaithanh.get(0).iDoanhthu;
			int vt = 0;
			for (int i = 0; i < dsNgoaithanh.size(); i++)
			{
				if (dsNgoaithanh.get(i).iDoanhthu > maxve)
				{
					maxve = dsNgoaithanh.get(i).iDoanhthu;
					vt = i;
				}
			}
			System.out.print(String.format("%1$8s |", vt + 1));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iMaso));
			System.out.print(String.format(" %1$-19s |", dsNgoaithanh.get(vt).sTentaixe));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sBienso));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sNoidi));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sNoiden));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sThoigiandi));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sNgaydi));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iGiave));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iSove));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iSovedaban));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iHaophi));
			System.out.println(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iDoanhthu));
			System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

		}
		@Override
		public void chuyenmin() {
			// TODO Auto-generated method stub
			System.out.println("     --------------------------------------------------------------------------------------CHUYẾN CÓ DOANH THU THẤP NHẤT---------------------------------------------------------------------");
			System.out.println("     ___________________________________________________________________________________________________________________________________________________________________________________________________");
			System.out.print(String.format("%1$8s |", "STT"));
			System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
			System.out.print(String.format(" %1$-19s |", "Tên tài xế "));
			System.out.print(String.format(" %1$-12s |", "Biển số"));
			System.out.print(String.format(" %1$-12s |", "Nơi đi"));
			System.out.print(String.format(" %1$-12s |", "Nơi đến"));
			System.out.print(String.format(" %1$-12s |", "Thời gian đi"));
			System.out.print(String.format(" %1$-12s |", "Ngày đi"));
			System.out.print(String.format(" %1$-12s |", "Gía vé"));
			System.out.print(String.format(" %1$-12s |", "Số vé"));
			System.out.print(String.format(" %1$-12s |", "Số vé đã bán"));
			System.out.print(String.format(" %1$-12s |", "Hao phí"));
			System.out.println(String.format(" %1$-12s |", "Doanh thu"));
			System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

			double maxve = dsNgoaithanh.get(0).iDoanhthu;
			int vt = 0;
			for (int i = 0; i < dsNgoaithanh.size(); i++)
			{
				if (dsNgoaithanh.get(i).iDoanhthu < maxve)
				{
					maxve = dsNgoaithanh.get(i).iDoanhthu;
					vt = i;
				}
			}
			System.out.print(String.format("%1$8s |", vt + 1));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iMaso));
			System.out.print(String.format(" %1$-19s |", dsNgoaithanh.get(vt).sTentaixe));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sBienso));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sNoidi));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sNoiden));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sThoigiandi));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).sNgaydi));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iGiave));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iSove));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iSovedaban));
			System.out.print(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iHaophi));
			System.out.println(String.format(" %1$-12s |", dsNgoaithanh.get(vt).iDoanhthu));
			System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

		}
	}

