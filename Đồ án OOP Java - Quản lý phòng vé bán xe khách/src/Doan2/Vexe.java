package Doan2;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class Vexe {
	private int iMave;
	private String sTenkhachhang;
	private String sLoaiKH;
	private int iCMND;
	private int iNamsinh;
	private int iMachuyen;
	private int iSoghe;
	private double iGiave;
	private String sNoidi;
	private String sNoiden;
	private String sNgaydi;
	private String sThoigiandi;
	private String sBienso;
	private ArrayList<Vexe> dsvx = new ArrayList<Vexe>();
	private ArrayList<Ngoaithanh> ldsnt = new ArrayList<Ngoaithanh>();
	private Ngoaithanh nt = new Ngoaithanh();
	BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
	//
	public ArrayList<Vexe> getDsvx()
	{
		return this.dsvx;
	}
	public void setDsvx(ArrayList<Vexe> value)
	{
		this.dsvx = value;
	}
	public int getMave()
	{
		return this.iMave;
	}
	public void setMave(int value)
	{
		this.iMave = value;
	}
	public String getTenkhachhang()
	{
		return this.sTenkhachhang;
	}
	public void setTenkhachhang(String value)
	{
		this.sTenkhachhang = value;
	}
	public String getLoaiKh()
	{
		return this.sLoaiKH;
	}
	public void setLoaiKh(String value)
	{
		this.sLoaiKH = value;
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
	public int getMachuyen()
	{
		return this.iMachuyen;
	}
	public void setMachuyen(int value)
	{
		this.iMachuyen = value;
	}
	public int getSoghe()
	{
		return this.iSoghe;
	}
	public void setSoghe(int value)
	{
		this.iSoghe = value;
	}
	public double getGiave()
	{
		return this.iGiave;
	}
	public void setGiave(double value)
	{
		this.iGiave = value;
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
	public String getNgaydi()
	{
		return this.sNgaydi;
	}
	public void setNgaydi(String value)
	{
		this.sNgaydi = value;
	}
	public String getThoigiandi()
	{
		return this.sThoigiandi;
	}
	public void setThoigiandi(String value)
	{
		this.sThoigiandi = value;
	}
	public String getBienso()
	{
		return this.sBienso;
	}
	public void setBienso(String value)
	{
		this.sBienso = value;
	}
	public  void Nhap() throws NumberFormatException, IOException
	{
				int kiemtra;
				System.out.print("Nhập mã vé: ");
				this.iMave = Integer.parseInt(input.readLine());
				System.out.print("Nhập tên khách hàng: ");
				this.sTenkhachhang = input.readLine();
				System.out.print("Nhập CMND: ");
				this.iCMND = Integer.parseInt(input.readLine());
				System.out.print("Nhập năm sinh: ");
				this.iNamsinh = Integer.parseInt(input.readLine());
				System.out.println("Chế độ giảm giá vé: ");
				System.out.println("NL: Người lớn (0%)    TE/NG: Trẻ em/Người già (50%)  SV: Sinh viên (30%)     KT: Khuyết tật (70%)");
				System.out.print("Nhập loại khách hàng: ");
				this.sLoaiKH = input.readLine();
				//Console.Clear();
				nt.DocfileTxt("dsngoaithanh.txt"); //đọc ds ngoại thành vào nt để xuất ra màn hình để chọn
				nt.Xuat();
				System.out.print("Chọn chuyến xe muốn đi: ");
				int temp = Integer.parseInt(input.readLine());
				Ngoaithanh nt1 = new Ngoaithanh();
				nt1 = nt.ReturnNgoaithanh(temp); // hàm returnNgoaithanh sẽ trả về đối tượng Ngoại thành mà bạn đã chọn
				this.iMachuyen = nt1.iMaso; //gán giá trị của đối tượn ngoại thành đã chọn vào Vé xe
				this.iSoghe = nt1.getSovedaban() + 1;
				nt1.setSovedaban(nt1.getSovedaban()+1); // cập nhật lại giá trị số vé đã bán, mỗi lần bán thì tăng lên 1

					if (this.sLoaiKH.equals("SV"))
					{
						this.iGiave = nt1.iGiave * 0.7; //điều kiện giảm giá vé
					}
					if (this.sLoaiKH.equals("KT"))
					{
						this.iGiave = nt1.iGiave * 0.3;
					}
					if (this.sLoaiKH.equals("TE") || this.sLoaiKH.equals("NG"))
					{
						this.iGiave = nt1.iGiave * 0.5;
					}
					if (this.sLoaiKH.equals("NL"))
					{
						this.iGiave = nt1.iGiave;
					}
					nt1.iDoanhthu = nt1.iDoanhthu + this.iGiave; // cập nhật lại doanh thu chuyến ngoại thành
					this.sNoidi = nt1.getNoidi();
					this.sNoiden = nt1.getNoiden();
					this.sNgaydi = nt1.getNgaydi();
					this.sThoigiandi = nt1.getThoigiandi();
					this.sBienso = nt1.sBienso;
					nt.Suasovedabanvadoanhthu(nt1, temp); //hàm cập nhật lại đối tượng ngoại thành đã chọn ở trên trong danh sách Chuyến ngoại thành
					nt.GhifileTxt("..\\dsngoaithanh.txt");

	}
	public  void Xuat()
	{
				System.out.println("     ------------------------------------------------------------------------------------------DANH SÁCH VÉ XE-------------------------------------------------------------------------------------------");
				System.out.println("     ____________________________________________________________________________________________________________________________________________________________________________________________________");
				System.out.print(String.format("%1$8s |", "STT"));
				System.out.print(String.format(" %1$-12s |", "Mã vé"));
				System.out.print(String.format(" %1$-19s |", "Tên khách hàng "));
				System.out.print(String.format(" %1$-12s |", "CMND"));
				System.out.print(String.format(" %1$-12s |", "Năm sinh"));
				System.out.print(String.format(" %1$-12s |", "Loại KH"));
				System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
				System.out.print(String.format(" %1$-12s |", "Biển số xe"));
				System.out.print(String.format(" %1$-12s |", "Số ghế"));
				System.out.print(String.format(" %1$-12s |", "Giá vé"));
				System.out.print(String.format(" %1$-12s |", "Nơi đi"));
				System.out.print(String.format(" %1$-12s |", "Nơi đến"));
				System.out.print(String.format(" %1$-12s |", "Ngày đi"));
				System.out.println(String.format(" %1$-12s |", "Thời gian đi"));
				System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
				for (int i = 0; i < dsvx.size(); i++)
				{
					System.out.print(String.format("%1$8s |", i + 1));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).iMave));
					System.out.print(String.format(" %1$-19s |", dsvx.get(i).sTenkhachhang));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).iCMND));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).iNamsinh));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).sLoaiKH));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).iMachuyen));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).sBienso));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).iSoghe));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).iGiave));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).sNoidi));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).sNoiden));
					System.out.print(String.format(" %1$-12s |", dsvx.get(i).sNgaydi));
					System.out.println(String.format(" %1$-12s |", dsvx.get(i).sThoigiandi));
					System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
				}
	}
	public void Them() throws NumberFormatException, IOException
	{
				int kiemtra;
				Vexe vx = new Vexe();
				vx.Nhap();
				dsvx.add(vx);

	}

			public void Xoa(int temp) throws FileNotFoundException, IOException
			{
				ArrayList<Vexe> tm = new ArrayList<Vexe>();
				ArrayList<Vexe> tam = new ArrayList<Vexe>();
				tm = dsvx;
				dsvx = tam;
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
					if (i != temp)
					{
						Vexe TT = new Vexe();
						TT = tam.get(i);
						dsvx.add(TT);

					}
					else
					{
						int tt = tam.get(i).iMachuyen; // trả về mã chuyến của vé xe đã xóa
						double temp1 = tam.get(i).iGiave; // trả về giá vé của vé xe đã xóa
						nt.Capnhatsaukhixoa(tt,temp1); //tiến hành cập nhật lại doanh thu và số vé đã bán trong danh sách chuyến đi

					}
				}

			}

			public void Sua(int temp) throws NumberFormatException, IOException
			{
				temp = temp - 1;
				Vexe bvmoi = new Vexe();
				bvmoi.Nhap();
				dsvx.set(temp,bvmoi);
			}
			public void GhifileTxt(String filename) throws IOException
			{
				BufferedWriter swrite = new BufferedWriter(new FileWriter(filename)) ;
				for (int i = 0; i < dsvx.size(); i++)
				{
					swrite.write(dsvx.get(i).getMave()+ "\n");
					swrite.write(dsvx.get(i).getTenkhachhang()+ "\n");
					swrite.write(dsvx.get(i).getCMND()+ "\n");
					swrite.write(dsvx.get(i).getNamsinh()+ "\n");
					swrite.write(dsvx.get(i).getLoaiKh()+ "\n");
					swrite.write(dsvx.get(i).getMachuyen()+ "\n");
					swrite.write(dsvx.get(i).getBienso()+ "\n");
					swrite.write(dsvx.get(i).getSoghe()+ "\n");
					swrite.write(String.valueOf(dsvx.get(i).getGiave())+ "\n");
					swrite.write(dsvx.get(i).getNoidi()+ "\n");
					swrite.write(dsvx.get(i).getNoiden()+ "\n");
					swrite.write(dsvx.get(i).getNgaydi()+ "\n");
					swrite.write(dsvx.get(i).getThoigiandi()+ "\n");
				}
				swrite.close();
				dsvx.clear();
			}
			public void DocfileTxt(String filename) throws IOException
			{
					FileReader fp = new FileReader(filename);
					BufferedReader rd = new BufferedReader(fp);
						int dem = 0;
						while (rd.readLine() != null)
						{
							dem++;
						}
						int size = dem / 13;
						rd.close();
						fp.close();
						FileReader fp1 = new FileReader(filename);
						BufferedReader rd1 = new BufferedReader(fp1);
						for (int i = 0; i < size; i++)
						{
							Vexe lx = new Vexe();
							lx.setMave(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
							lx.setTenkhachhang(rd1.readLine());
							lx.setCMND(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
							lx.setNamsinh(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
							lx.setLoaiKh(rd1.readLine());
							lx.setMachuyen(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
							lx.setBienso(rd1.readLine());
							lx.setSoghe(Integer.parseInt(rd1.readLine().replaceAll("\\uFEFF", "")));
							lx.setGiave(Double.parseDouble(rd1.readLine().replaceAll("\\uFEFF", "")));
							lx.setNoidi(rd1.readLine());
							lx.setNoiden(rd1.readLine());
							lx.setNgaydi(rd1.readLine());
							lx.setThoigiandi(rd1.readLine());
							dsvx.add(lx);
						}
						fp1.close();
						rd1.close();
			}
					public void Searchtheomachuyen() throws NumberFormatException, IOException
					{
						int dem1 = 0;
						System.out.print("Nhập mã vé cần tìm: ");
						int NV = Integer.parseInt(input.readLine());
						System.out.println("     ------------------------------------------------------------------------------------------DANH SÁCH VÉ XE-------------------------------------------------------------------------------------------");
						System.out.println("     ____________________________________________________________________________________________________________________________________________________________________________________________________");
						System.out.print(String.format("%1$8s |", "STT"));
						System.out.print(String.format(" %1$-12s |", "Mã vé"));
						System.out.print(String.format(" %1$-19s |", "Tên khách hàng "));
						System.out.print(String.format(" %1$-12s |", "CMND"));
						System.out.print(String.format(" %1$-12s |", "Năm sinh"));
						System.out.print(String.format(" %1$-12s |", "Loại KH"));
						System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
						System.out.print(String.format(" %1$-12s |", "Biển số xe"));
						System.out.print(String.format(" %1$-12s |", "Số ghế"));
						System.out.print(String.format(" %1$-12s |", "Giá vé"));
						System.out.print(String.format(" %1$-12s |", "Nơi đi"));
						System.out.print(String.format(" %1$-12s |", "Nơi đến"));
						System.out.print(String.format(" %1$-12s |", "Ngày đi"));
						System.out.println(String.format(" %1$-12s |", "Thời gian đi"));
						System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
						for (int i = 0; i < dsvx.size(); i++)
						{
							if (dsvx.get(i).iMave == NV)
							{
								dem1++;
								System.out.print(String.format("%1$8s |", i + 1));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).iMave));
								System.out.print(String.format(" %1$-19s |", dsvx.get(i).sTenkhachhang));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).iCMND));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).iNamsinh));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).sLoaiKH));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).iMachuyen));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).sBienso));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).iSoghe));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).iGiave));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).sNoidi));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).sNoiden));
								System.out.print(String.format(" %1$-12s |", dsvx.get(i).sNgaydi));
								System.out.println(String.format(" %1$-12s |", dsvx.get(i).sThoigiandi));
								System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
							}
						}
						if (dem1 == 0)
						{
							System.out.println("                                                                                       ---> không tìm thấy <--- ");
						}
					}
					public final void Searchnoiden() throws IOException
					{
								int dem1 = 0;
								System.out.print("Nhập nơi đến cần tìm: ");
								String NV = input.readLine();
								System.out.println("     ------------------------------------------------------------------------------------------DANH SÁCH VÉ XE-------------------------------------------------------------------------------------------");
								System.out.println("     ____________________________________________________________________________________________________________________________________________________________________________________________________");
								System.out.print(String.format("%1$8s |", "STT"));
								System.out.print(String.format(" %1$-12s |", "Mã vé"));
								System.out.print(String.format(" %1$-19s |", "Tên khách hàng "));
								System.out.print(String.format(" %1$-12s |", "CMND"));
								System.out.print(String.format(" %1$-12s |", "Năm sinh"));
								System.out.print(String.format(" %1$-12s |", "Loại KH"));
								System.out.print(String.format(" %1$-12s |", "Mã chuyến"));
								System.out.print(String.format(" %1$-12s |", "Biển số xe"));
								System.out.print(String.format(" %1$-12s |", "Số ghế"));
								System.out.print(String.format(" %1$-12s |", "Giá vé"));
								System.out.print(String.format(" %1$-12s |", "Nơi đi"));
								System.out.print(String.format(" %1$-12s |", "Nơi đến"));
								System.out.print(String.format(" %1$-12s |", "Ngày đi"));
								System.out.println(String.format(" %1$-12s |", "Thời gian đi"));
								System.out.println("    ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
								for (int i = 0; i < dsvx.size(); i++)
								{
									if (NV.equals(dsvx.get(i).sNoiden))
									{
										dem1++;
										System.out.print(String.format("%1$8s |", i + 1));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).iMave));
										System.out.print(String.format(" %1$-19s |", dsvx.get(i).sTenkhachhang));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).iCMND));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).iNamsinh));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).sLoaiKH));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).iMachuyen));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).sBienso));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).iSoghe));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).iGiave));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).sNoidi));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).sNoiden));
										System.out.print(String.format(" %1$-12s |", dsvx.get(i).sNgaydi));
										System.out.println(String.format(" %1$-12s |", dsvx.get(i).sThoigiandi));
										System.out.println("    --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
									}
								}
								if (dem1 == 0)
								{
									System.out.println("                                                                                      ---> không tìm thấy <--- ");
								}
					}
							public final void ChiXoavexe(int dem, int[] a)
							{
								int flag = 0;
								ArrayList<Vexe> tm = new ArrayList<Vexe>();
								ArrayList<Vexe> tam = new ArrayList<Vexe>();
								tm = dsvx;
								dsvx = tam;
								tam = tm;
								// Dich chuyen mang
								for (int i = 0; i < tam.size(); i++)
								{
									for (int j = 0; j <= dem; j++)
									{
										if (i == a[j])
										{
											flag = 1;
											break;
										}
									}
									if (flag == 0)
									{
										dsvx.add(tam.get(i));
									}
									flag = 0;
								}
							}
							public final void Xoavexetheomachuyen(int machuyen)
							{
								int dem = 0;
								int[] a = new int[100];
								for (int i = 0; i < dsvx.size(); i++)
								{
									if (dsvx.get(i).iMachuyen == machuyen)
									{
										a[dem] = i;
										dem++;
									}
								}
								ChiXoavexe(dem, a);

							}
							public static boolean opGreaterThan(Vexe a, Vexe b)
							{
								if (a.iMachuyen < b.iMachuyen)
								{
									return false;
								}
								return true;
							}
							public static boolean opLessThan(Vexe a, Vexe b)
							{
								if (a.iMachuyen > b.iMachuyen)
								{
									return false;
								}
								return true;
							}
							public final void Sort() throws IOException
							{
								Vexe t;
								for (int i = 0; i < dsvx.size() - 1; i++)
								{
									for (int j = i + 1; j < dsvx.size(); j++)
									{
										if (opGreaterThan(dsvx.get(i), dsvx.get(j)))
										{
											t = dsvx.get(i);
											dsvx.set(i, dsvx.get(j));
											dsvx.add(j,t);
										}
									}
								}

								GhifileTxt("dsvx.txt");
								dsvx.clear();
							}
			
		

}
