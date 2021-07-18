package Doan2;
import java.util.*;
import javax.sound.sampled.AudioFormat.Encoding;
import java.io.*;
public class BanVe extends Nhanvien
	{
		protected int iSocalamviec;
		BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
		private ArrayList<BanVe> dsbanve = new ArrayList<BanVe>();
		//
		public int getSocalamviec()
		{
			return this.iSocalamviec;
		}
		public void setSocalamviec(int value)
		{
			this.iSocalamviec = value;
		}
		public ArrayList<BanVe> getDsbanve()
		{
			return this.dsbanve;
		}
		public void setDsbanve(ArrayList<BanVe> dsbanve)
		{
			this.dsbanve = dsbanve;
		}
		//
		public BanVe() 
		{
			super();

		}
		public BanVe(int Socalamviec, ArrayList<BanVe> dsbanve) {
			super();
			this.iSocalamviec = Socalamviec;
			this.dsbanve = dsbanve;
		}
		//
		public void Nhap() throws IOException
		{
			super.Nhap();
			System.out.print("Nhập số ca làm việc: ");
			this.iSocalamviec = Integer.parseInt(input.readLine());
			this.iLuong = tinhluong();
		}
		//
		@Override
		public void Xuat()
		{
			System.out.println("     -----------------------------------------------------DANH SÁCH NHÂN VIÊN BÁN VÉ---------------------------------------------------");
			System.out.println("     _________________________________________________________________________________________________________________________________________________________");
			System.out.print(String.format("%1$8s |", "STT"));
			System.out.print(String.format(" %1$-12s |", "Mã nhân viên"));
			System.out.print(String.format(" %1$-19s |", "Họ và tên "));
			System.out.print(String.format(" %1$-15s |", "Số CMND"));
			System.out.print(String.format(" %1$-12s |", "Năm sinh"));
			System.out.print(String.format(" %1$-12s |", "Ngày công"));
			System.out.print(String.format(" %1$-15s |", "Số ca làm việc"));
			System.out.print(String.format(" %1$-19s |", "Lương cơ bản"));
			System.out.println(String.format(" %1$-20s |", "Lương chính thức" + " $"));
			System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
			for (int i = 0; i < dsbanve.size(); i++)
			{
				System.out.print(String.format("%1$8s |", i + 1));
				System.out.print(String.format(" %1$-12s |", dsbanve.get(i).iManv));
				System.out.print(String.format(" %1$-19s |", dsbanve.get(i).sHoten));
				System.out.print(String.format(" %1$-15s |", dsbanve.get(i).iCMND));
				System.out.print(String.format(" %1$-12s |", dsbanve.get(i).iNamsinh));
				System.out.print(String.format(" %1$-12s |", dsbanve.get(i).iNgaycong));
				System.out.print(String.format(" %1$-15s |", dsbanve.get(i).iSocalamviec));
				System.out.print(String.format(" %1$-19s |", dsbanve.get(i).iLuongcb));
				System.out.println(String.format(" %1$-20s |", dsbanve.get(i).iLuong + " $"));
				System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
			}
		}

		@Override
		public void GhifileNv(String filename) throws IOException
		{
			BufferedWriter swrite = new BufferedWriter(new FileWriter(filename)) ;
			for (int i = 0; i < dsbanve.size(); i++)
			{
				swrite.write(dsbanve.get(i).getManv()+ "\n");
				swrite.write(dsbanve.get(i).getHoten()+ "\n");
				swrite.write(dsbanve.get(i).getCMND()+ "\n");
				swrite.write(dsbanve.get(i).getNamsinh()+ "\n");
				swrite.write(dsbanve.get(i).getNgaycong()+ "\n");
				swrite.write(dsbanve.get(i).getLuongcb()+ "\n");
				swrite.write(dsbanve.get(i).getSocalamviec()+ "\n");
				swrite.write(dsbanve.get(i).getLuong()+ "\n");
			}
			swrite.close();
			dsbanve.clear();
		}

	@Override
	public void DocfileNv(String filename) throws IOException
	{
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
					BanVe lx = new BanVe();
					lx.setManv(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
					lx.setHoten(rd1.readLine());
					lx.setCMND(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
					lx.setNamsinh(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
					lx.setNgaycong(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
					lx.setLuongcb(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
					lx.setSocalamviec(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
					lx.setLuong(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
					dsbanve.add(lx);
				}
				fp1.close();
				rd1.close();
	}

	@Override
	public void Them() throws IOException {
		// TODO Auto-generated method stub
		int n;
		System.out.print("Số nhân viên bán vé bạn muốn nhập: ");
		n = Integer.parseInt(input.readLine());
		for (int i = 0; i < n; i++)
		{
			BanVe bv = new BanVe();
			bv.Nhap();
			dsbanve.add(bv);
		}

	}
	@Override
	public void Xoa(int temp) {
		// TODO Auto-generated method stub
		ArrayList<BanVe> tm = new ArrayList<BanVe>();
		ArrayList<BanVe> tam = new ArrayList<BanVe>();
		tm = dsbanve;
		dsbanve= tam;
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
			BanVe TT = new BanVe();
			if (i != temp)
			{
				TT = tam.get(i);
				dsbanve.add(TT);
			}
		}

	}
	@Override
	public void Sua(int temp) throws IOException {
		// TODO Auto-generated method stub
		temp = temp - 1;
		BanVe bvmoi = new BanVe();
		bvmoi.Nhap();
		dsbanve.set(temp,bvmoi);
	}
	@Override
	public int tinhluong() {
		// TODO Auto-generated method stub
		return this.iLuong = this.iLuongcb + this.iSocalamviec * this.iNgaycong * 30000;
	}
	public static boolean opGreaterThan(BanVe a, BanVe b)
	{
		if (a.iLuong < b.iLuong)
		{
			return false;
		}
		return true;
	}
	public static boolean opLessThan(BanVe a, BanVe b)
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
		BanVe t;
		for (int i = 0; i < dsbanve.size() - 1; i++)
		{
			for (int j = i + 1; j < dsbanve.size(); j++)
			{
				if (opGreaterThan(dsbanve.get(i), dsbanve.get(j)))
				{
					t = dsbanve.get(i);
					dsbanve.set(i, dsbanve.get(j)); 
					dsbanve.set(j,t);
				}
			}
		}
		GhifileNv("dsbanve.txt");
		dsbanve.clear();
	}
	@Override
	public void search() throws IOException {
		// TODO Auto-generated method stub
		int dem1 = 0;
		System.out.println("Nhập tên Nhân Viên bán vé cần tìm: ");
		String NV = input.readLine();
		System.out.println("     -----------------------------------------------------DANH SACH NHAN VIEN BAN VE---------------------------------------------------");
		System.out.println("     _________________________________________________________________________________________________________________________________________________________");
		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã nhân viên"));
		System.out.print(String.format(" %1$-19s |", "Họ và tên "));
		System.out.print(String.format(" %1$-15s |", "Số CMND"));
		System.out.print(String.format(" %1$-12s |", "Năm sinh"));
		System.out.print(String.format(" %1$-12s |", "Ngày công"));
		System.out.print(String.format(" %1$-15s |", "Số ca làm việc"));
		System.out.print(String.format(" %1$-19s |", "Lương cơ bản"));
		System.out.println(String.format(" %1$-20s |", "Lương chính thức" + " $"));
		System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
	for (int i = 0; i < dsbanve.size(); i++)
	{
		if (NV.equals(dsbanve.get(i).sHoten))
		{
			dem1++;
			System.out.print(String.format("%1$8s |", i + 1));
			System.out.print(String.format(" %1$-12s |", dsbanve.get(i).iManv));
			System.out.print(String.format(" %1$-19s |", dsbanve.get(i).sHoten));
			System.out.print(String.format(" %1$-15s |", dsbanve.get(i).iCMND));
			System.out.print(String.format(" %1$-12s |", dsbanve.get(i).iNamsinh));
			System.out.print(String.format(" %1$-12s |", dsbanve.get(i).iNgaycong));
			System.out.print(String.format(" %1$-15s |", dsbanve.get(i).iSocalamviec));
			System.out.print(String.format(" %1$-19s |", dsbanve.get(i).iLuongcb));
			System.out.println(String.format(" %1$-20s |", dsbanve.get(i).iLuong + " $"));
			System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
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
		System.out.println("     _______________________________________________________________NHÂN VIÊN CÓ LƯƠNG CAO NHẤT_______________________________________________________________");
		System.out.print(String.format("%1$8s |", "STT"));
		System.out.print(String.format(" %1$-12s |", "Mã nhân viên"));
		System.out.print(String.format(" %1$-19s |", "Họ và tên "));
		System.out.print(String.format(" %1$-15s |", "Số CMND"));
		System.out.print(String.format(" %1$-12s |", "Năm sinh"));
		System.out.print(String.format(" %1$-12s |", "Ngày công"));
		System.out.print(String.format(" %1$-15s |", "Số ca làm việc"));
		System.out.print(String.format(" %1$-19s |", "Lương cơ bản"));
		System.out.println(String.format(" %1$-20s |", "Lương chính thức" + " $"));
		System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
		double maxve = 0;
		int vt = 0;
		for (int i = 0; i < dsbanve.size(); i++)
		{
			if (dsbanve.get(i).tinhluong() > maxve)
			{
				maxve = dsbanve.get(i).tinhluong();
				vt = i;
			}
		}
		System.out.print(String.format("%1$8s |", vt + 1));
		System.out.print(String.format(" %1$-12s |", dsbanve.get(vt).iManv));
		System.out.print(String.format(" %1$-19s |", dsbanve.get(vt).sHoten));
		System.out.print(String.format(" %1$-15s |", dsbanve.get(vt).iCMND));
		System.out.print(String.format(" %1$-12s |", dsbanve.get(vt).iNamsinh));
		System.out.print(String.format(" %1$-12s |", dsbanve.get(vt).iNgaycong));
		System.out.print(String.format(" %1$-15s |", dsbanve.get(vt).iSocalamviec));
		System.out.print(String.format(" %1$-19s |", dsbanve.get(vt).iLuongcb));
		System.out.println(String.format(" %1$-20s |", dsbanve.get(vt).iLuong + " $"));
		System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");

	}
	@Override
	public void luongmin() {
		// TODO Auto-generated method stub
		{
			System.out.println("     _______________________________________________________________NHÂN VIÊN CÓ LƯƠNG THẤP NHẤT______________________________________________________________");
			System.out.print(String.format("%1$8s |", "STT"));
			System.out.print(String.format(" %1$-12s |", "Mã nhân viên"));
			System.out.print(String.format(" %1$-19s |", "Họ và tên "));
			System.out.print(String.format(" %1$-15s |", "Số CMND"));
			System.out.print(String.format(" %1$-12s |", "Năm sinh"));
			System.out.print(String.format(" %1$-12s |", "Ngày công"));
			System.out.print(String.format(" %1$-15s |", "Số ca làm việc"));
			System.out.print(String.format(" %1$-19s |", "Lương cơ bản"));
			System.out.println(String.format(" %1$-20s |", "Lương chính thức" + " $"));
			System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");
			double maxve = dsbanve.get(0).tinhluong();
			int vt = 0;
			for (int i = 0; i < dsbanve.size(); i++)
			{
				if (dsbanve.get(i).tinhluong() < maxve)
				{
					maxve = dsbanve.get(i).tinhluong();
					vt = i;
				}
			}
			System.out.print(String.format("%1$8s |", vt + 1));
			System.out.print(String.format(" %1$-12s |", dsbanve.get(vt).iManv));
			System.out.print(String.format(" %1$-19s |", dsbanve.get(vt).sHoten));
			System.out.print(String.format(" %1$-15s |", dsbanve.get(vt).iCMND));
			System.out.print(String.format(" %1$-12s |", dsbanve.get(vt).iNamsinh));
			System.out.print(String.format(" %1$-12s |", dsbanve.get(vt).iNgaycong));
			System.out.print(String.format(" %1$-15s |", dsbanve.get(vt).iSocalamviec));
			System.out.print(String.format(" %1$-19s |", dsbanve.get(vt).iLuongcb));
			System.out.println(String.format(" %1$-20s |", dsbanve.get(vt).iLuong + " $"));
			System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------");


	}
	}
}
	


