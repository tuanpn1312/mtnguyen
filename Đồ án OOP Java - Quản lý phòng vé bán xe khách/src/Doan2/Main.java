package Doan2;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class Main {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		int choose,choose1,choose2,choose3,choose4,choose5;
		ArrayList<LaiXe> dslaixe = new ArrayList<LaiXe>();
		BufferedReader input = new BufferedReader(new InputStreamReader(System.in));
		do
		{
			//Console.Clear();
			Menuchinh();
			choose = Integer.parseInt(input.readLine());
			switch (choose)
			{
				case 1:
					{
						do
						{
							//Console.Clear();
							MenuNhanvien();
							choose1 = Integer.parseInt(input.readLine());
							Nhanvien nv = new LaiXe();
							switch (choose1)
							{
								case 1:
									{
										do
										{
											//nv = new LaiXe();
											nv.DocfileNv("dslaixe.txt");
											//Console.Clear();
											MenuNhanvienlaixe();
											choose2 = Integer.parseInt(input.readLine());
											
											switch (choose2)
											{
												case 1:
												{
														nv.Them();
														nv.GhifileNv("dslaixe.txt");
														break;
												}
												case 2:
												{
														int temp;
														System.out.print("Nhập vị trí phần tử muốn xóa: ");
														temp = Integer.parseInt(input.readLine());
														nv.Xoa(temp);
														nv.GhifileNv("dslaixe.txt");
														break;
												}
												case 3:
												{
														int temp;
														System.out.print("Nhập vị trí phần tử muốn sửa: ");
														temp = Integer.parseInt(input.readLine());
														nv.Sua(temp);
														nv.GhifileNv("dslaixe.txt");
														break;
												}
												case 4:
												{
													do
													{

														//Console.Clear();
														TKNhanvienlaixe();
														choose1 = Integer.parseInt(input.readLine());
														switch (choose1)
														{
															case 1:
															{
																	//Console.Clear();
																	String enter;
																	nv.search();
																	System.out.print("Nhấn enter để tiếp tục ....");
																	enter = input.readLine();
																	break;
															}
															case 2:
															{
																	//Console.Clear();
																	String enter;
																	nv.luongmax();
																	System.out.print("Nhấn enter để tiếp tục ....");
																	enter = input.readLine();
																	break;
															}
															case 3:
															{
																	//Console.Clear();
																	String enter;
																	nv.luongmin();
																	System.out.print("Nhấn enter để tiếp tục ....");
																	enter = input.readLine();
																	break;
															}
															case 4:
															{
																	nv.sort();
																	break;
															}
															default:
															{
																	
																	break;
															}
														}
													} while (choose1 != 5);
													break;
												}
											default:
											{
													
													break;
											}
										}
									} while (choose2 != 5);
									break;
								}
							case 2:
							{
								nv = new BanVe();
								do
								{
									nv.DocfileNv("dsbanve.txt");
									//Console.Clear();
									MenuNhanvienbanve();
									choose2 = Integer.parseInt(input.readLine());
									switch (choose2)
									{
										case 1:
										{
												nv.Them();
												nv.GhifileNv("dsbanve.txt");
												break;
										}
										case 2:
										{
												int temp;
												System.out.print("Nhap vi tri phan tu ban muon xoa: ");
												temp = Integer.parseInt(input.readLine());
												nv.Xoa(temp);
												nv.GhifileNv("dsbanve.txt");
												break;
										}
										case 3:
										{
												int temp;
												System.out.print("Nhap vi tri phan tu ban muon sua: ");
												temp = Integer.parseInt(input.readLine());
												nv.Sua(temp);
												nv.GhifileNv("dsbanve.txt");
												break;
										}
										case 4:
										{

												do
												{

													//Console.Clear();
													TKNhanvienbanve();
													choose3 = Integer.parseInt(input.readLine());
													switch (choose2)
													{
														case 1:
														{
																//Console.Clear();
																String enter;
																nv.search();
																System.out.print("Nhấn enter để tiếp tục ....");
																enter = input.readLine();
																break;
														}
														case 2:
														{
																//Console.Clear();
																String enter;
																nv.luongmax();
																System.out.print("Nhấn enter để tiếp tục ....");
																enter = input.readLine();
																break;
														}
														case 3:
														{
																//Console.Clear();
																String enter;
																nv.luongmin();
																System.out.print("Nhấn enter để tiếp tục ....");
																enter = input.readLine();
																break;
														}
														case 4:
														{
																nv.sort();
																break;
														}
														default:
														{
																System.out.print("Nhập sai!!! Vui lòng nhập lại @.@");
																break;
														}
													}

												} while (choose3 != 5);
												break;
										}
										default:
										{
										
										}
									}
					            } while (choose2 != 5);
									break;
							}
							default:
							{
								break;
							}
																		}
							} while (choose1 != 3);
								break;
							}
															case 2:
															{
																	do
																	{
																		//Console.Clear();
																		Menuqlve();
																		choose3 = Integer.parseInt(input.readLine());
																		Vexe vx = new Vexe();
																		vx.DocfileTxt("dsvx.txt");
																		switch (choose3)
																		{
																			case 1:
																			{
																					//Console.Clear();
																					vx.Them();
																					vx.GhifileTxt("dsvx.txt");
																					break;
																			}
																			case 2:
																			{
																					int temp;
																					System.out.print("Nhap vi tri phan tu ban muon xoa: ");
																					temp = Integer.parseInt(input.readLine());
																					vx.Xoa(temp);
																					vx.GhifileTxt("dsvx.txt");
																					break;
																			}
																			case 3:
																			{
																					//Console.Clear();
																					String enter;
																					vx.Searchtheomachuyen();
																					System.out.print("Nhấn enter để tiếp tục  ");
																					enter = input.readLine();
																					break;
																			}
																			case 4:
																			{
																					//Console.Clear();
																					String enter;
																					vx.Searchnoiden();
																					System.out.print("Nhấn enter để tiếp tục  ");
																					enter = input.readLine();
																					break;
																			}
																			case 5:
																			{
																					vx.Sort();
																					break;
																			}
																			default:
																			{
																					System.out.print("Nhập sai!!! Vui lòng nhập lại @.@");
																					break;
																			}
																		}
																	} while (choose3 != 6);
																	break;
															}
										
															case 3:
															{
																do
																{
																	//Console.Clear();
																	quanlichuyen();
																	choose3 = Integer.parseInt(input.readLine());
																	Chuyenxe chuyen = new Ngoaithanh();
																	switch (choose3)
																	{
																		case 1:
																		{
																				do
																				{
																					//Ngoaithanh chuyen = new Ngoaithanh();
																					chuyen.DocfileTxt("dsngoaithanh.txt");
																					//Console.Clear();
																					quanlingoaithanh();
																					choose4 = Integer.parseInt(input.readLine());
																					switch (choose4)
																					{
																						case 1:
																						{
																								chuyen.Them();
																								chuyen.GhifileTxt("dsngoaithanh.txt");
																								break;
																						}
																						case 2:
																						{
																								int temp;
																								System.out.print("Nhập vị trí phần tử muốn xóa: ");
																								temp = Integer.parseInt(input.readLine());
																								chuyen.Xoa(temp);
																								chuyen.GhifileTxt("dsngoaithanh.txt");
																								break;
																						}
																						case 3:
																						{
																								int temp;
																								System.out.print("Nhập vị trí phần tử muốn sửa: ");
																								temp = Integer.parseInt(input.readLine());
																								chuyen.Sua(temp);
																								chuyen.GhifileTxt("dsngoaithanh.txt");
																								break;
																						}
																						case 4:
																						{
																								do
																								{

																									//Console.Clear();
																									TKngoaithanh();
																									choose5 = Integer.parseInt(input.readLine());
																									switch (choose5)
																									{
																										case 1:
																										{
																												//Console.Clear();
																												String enter;
																												chuyen.Search();
																												System.out.print("Nhấn enter để tiếp tục ....");
																												enter = input.readLine();
																												break;
																										}
																										case 2:
																										{
																												//Console.Clear();
																												String enter;
																												chuyen.chuyenmax();
																												System.out.print("Nhấn enter để tiếp tục ....");
																												enter = input.readLine();
																												break;
																										}
																										case 3:
																										{
																												//Console.Clear();
																												String enter;
																												chuyen.chuyenmin();
																												System.out.print("Nhấn enter để tiếp tục ....");
																												enter = input.readLine();
																												break;
																										}
																										case 4:
																										{
																												chuyen.Sort();
																												break;
																										}
																										default:
																										{
																												break;
																										}
																									}
																								} while (choose5 != 5);
																								break;
																						}
																						default:
																						{
													
																								break;
																						}
																					}
																				} while (choose4 != 5);
																				break;
																		}
																		case 2:
																		{
																			chuyen = new Noithanh();
																			do
																			{
																				chuyen.DocfileTxt("dsnoithanh.txt");
																				//Console.Clear();
																				quanlinoithanh();
																				choose4 = Integer.parseInt(input.readLine());
																				switch (choose4)
																				{
																					case 1:
																					{
																							chuyen.Them();
																							chuyen.GhifileTxt("dsnoithanh.txt");
																							break;
																					}
																					case 2:
																					{
																							int temp;
																							System.out.print("Nhập vị trí phần tử muốn xóa: ");
																							temp = Integer.parseInt(input.readLine());
																							chuyen.Xoa(temp);
																							chuyen.GhifileTxt("dsnoithanh.txt");
																							break;
																					}
																					case 3:
																					{
																							int temp;
																							System.out.print("Nhập vị trí phần tử muốn sửa: ");
																							temp = Integer.parseInt(input.readLine());
																							chuyen.Sua(temp);
																							chuyen.GhifileTxt("dsnoithanh.txt");
																							break;
																					}
																					case 4:
																					{

																							do
																							{

																								//Console.Clear();
																								TKnoithanh();
																								choose5 = Integer.parseInt(input.readLine());
																								switch (choose4)
																								{
																									case 1:
																									{
																											//Console.Clear();
																											String enter;
																											chuyen.Search();
																											System.out.print("Nhấn enter để tiếp tục ....");
																											enter = input.readLine();
																											break;
																									}
																									case 2:
																									{
																											//Console.Clear();
																											String enter;
																											chuyen.chuyenmax();
																											System.out.print("Nhấn enter để tiếp tục ....");
																											enter = input.readLine();
																											break;
																									}
																									case 3:
																									{
																											//Console.Clear();
																											String enter;
																											chuyen.chuyenmin();
																											System.out.print("Nhấn enter để tiếp tục ....");
																											enter = input.readLine();
																											break;
																									}
																									case 4:
																									{
																											chuyen.Sort();
																											break;
																									}
																									default:
																									{
																											break;
																									}
																								}
																							} while (choose5 != 5);
																							break;
																					}
																					default:
																					{
																							break;
																					}
																				}
																			} while (choose4 != 5);
																			break;
								}

																	default:
																	{
										
																			break;
																	}
																}
															} while (choose3 != 3);
															break;
														}
													default:
													{
															break;
													}
												}
											} while (choose != 0);
	}
	private static void Menuchinh()
	{
				System.out.println("     --------------------------------------------------QUẢN LÝ NHÀ XE BÁN VÉ TUẤN TÚ------------------------------------------------------------------------");
				System.out.println("                                                         1.Quản lý nhân viên\n");
				System.out.println("                                                         2.Quản lý vé\n");
				System.out.println("                                                         3.Quản lý chuyến xe\n");
				System.out.print("                                                         Nhập sự lựa chọn của bạn: ");
	}
			private static void MenuNhanvien()
			{
				System.out.println("     --------------------------------------------------------QUẢN LÍ NHÂN VIÊN--------------------------------------------------------------------------------\n");
				System.out.println("                                                         1.Nhân viên lái xe\n");
				System.out.println("                                                         2.Nhân viên bán vé\n");
				System.out.println("                                                         3.Quay về màn hình chính\n");
				System.out.print("                                                         Nhập sự lựa chọn của bạn: ");
			}
			private static void MenuNhanvienlaixe() throws IOException
			{
				LaiXe lx = new LaiXe();
				System.out.println("     ----------------------------------------------------QUẢN LÍ NHÂN VIÊN LÁI XE ----------------------------------------------------\n");
				lx.DocfileNv("dslaixe.txt");
				lx.Xuat();
				System.out.println("                                       1.Thêm nhân viên                           3.Cập nhập nhân viên\n");
				System.out.println("                                       2.Xóa nhân viên                            4.Thống kê nhân viên\n");
				System.out.println("                                                               5.Thoát\n");
				System.out.print("                                                             Sự lựa chọn của bạn: ");
			}
			private static void MenuNhanvienbanve() throws IOException
			{
				BanVe lx = new BanVe();
				System.out.println("     ----------------------------------------------------QUẢN LÍ NHÂN VIÊN BÁN VÉ--------------------------------------------------  -\n");
				lx.DocfileNv("dsbanve.txt");
				lx.Xuat();
				System.out.println("                                       1.Thêm nhân viên                          3.Cập nhập nhân viên\n");
				System.out.println("                                       2.Xóa nhân viên                           4.Thống kê nhân viên\n");
				System.out.println("                                                               5.Thoát\n");
				System.out.print("                                                             Sự chọn lựa của bạn: ");
			}
			private static void TKNhanvienbanve() throws IOException
			{
				BanVe lx = new BanVe();
				System.out.println("     --------------------------------------------------------THỐNG KÊ BÁN VÉ----------------------------------------------------------\n");
				lx.DocfileNv("dsbanve.txt");
				lx.Xuat();
				System.out.println("                              1.Tìm kiếm nhân viên bán vé                         4.Sắp xếp tăng dần theo lương\n");
				System.out.println("                              2.Nhân viên có lương max                            5.Thoát\n");
				System.out.println("                              3.Nhân viên có lương min                            \n");
				System.out.print("                                                              Sự lựa chọn của bạn: ");
			}
			private static void TKNhanvienlaixe() throws IOException
			{
				LaiXe lx = new LaiXe();
				System.out.println("     ------------------------------------------------------- THỐNG KÊ LÁI XE----------------------------------------------------------\n");
				lx.DocfileNv("dslaixe.txt");
				lx.Xuat();
				System.out.println("                              1.Tìm kiếm nhân viên                                4.Sắp xếp tăng dần theo lương\n");
				System.out.println("                              2.Nhân viên có lương max                            5.Thoát\n");
				System.out.println("                              3.Nhân viên có lương min                            \n");
				System.out.print("                                                             Sự lưa chọn của bạn: ");
			}
			private static void quanlichuyen()
			{

				System.out.println("     ---------------------------------------------------------------------------------------------QUẢN LÍ CHUYẾN XE----------------------------------------------------------------------------------\n");
				System.out.println("                                                                                                   1.Ngoại thành                            \n");
				System.out.println("                                                                                                   2.Nội thành                            \n");
				System.out.println("                                                                                                   3.Thoát\n");
				System.out.print("                                                                                                 Sự lưa chọn của bạn: ");
			}
			private static void quanlingoaithanh() throws FileNotFoundException, IOException
			{
				Ngoaithanh lx = new Ngoaithanh();
				System.out.println("     -----------------------------------------------------------------------------------------QUẢN LÍ CHUYẾN NGOẠI THÀNH-----------------------------------------------------------------------------\n");
				lx.DocfileTxt("dsngoaithanh.txt");
				lx.Xuat();
				System.out.println("                                                                               1.Thêm chuyến                           3.Cập nhập chuyến\n");
				System.out.println("                                                                               2.Xóa chuyến                            4.Thống kê chuyến\n");
				System.out.println("                                                                                                     5.Thoát\n");
				System.out.print("                                                                                                  Sự lưa chọn của bạn: ");
			}
			private static void quanlinoithanh() throws IOException
			{
				Noithanh lx = new Noithanh();
				System.out.println("     ----------------------------------------------------------------------------------------QUẢN LÍ CHUYẾN NỘI THÀNH--------------------------------------------------------------------------------\n");
				lx.DocfileTxt("dsnoithanh.txt");
				lx.Xuat();
				System.out.println("                                                                             1.Thêm chuyến                           3.Cập nhập chuyến\n");
				System.out.println("                                                                             2.Xóa chuyến                            4.Thống kê chuyến\n");
				System.out.println("                                                                                                  5.Thoát\n");
				System.out.print("                                                                                                 Sự lưa chọn của bạn: ");
			}
			private static void TKngoaithanh() throws FileNotFoundException, IOException
			{
				Ngoaithanh lx = new Ngoaithanh();
				System.out.println("     ----------------------------------------------------------------------------------------THỐNG KÊ NGOẠI THÀNH------------------------------------------------------------------------------------\n");
				lx.DocfileTxt("dsngoaithanh.txt");
				lx.Xuat();
				System.out.println("                                                                   1.Tìm kiếm chuyến                                   4.Sắp xếp tăng dần theo doanhthu\n");
				System.out.println("                                                                   2.Chuyến có doanh thu max                           5.Thoát\n");
				System.out.println("                                                                   3.Chuyến có doanh thu min                           \n");
				System.out.print("                                                                                                 Sự lựa chọn của bạn: ");
			}
			private static void TKnoithanh() throws IOException
			{
				Noithanh lx = new Noithanh();
				System.out.println("     ----------------------------------------------------------------------------------------THỐNG KÊ NỘI THÀNH-------------------------------------------------------------------------------------\n");
				lx.DocfileTxt("dsnoithanh.txt");
				lx.Xuat();
				System.out.println("                                                                 1.Tìm kiếm chuyến                                   4.Sắp xếp tăng dần theo doanhthu\n");
				System.out.println("                                                                 2.Chuyến có doanh thu max                           5.Thoát\n");
				System.out.println("                                                                 3.Chuyến có doanh thu min                           \n");
				System.out.print("                                                                                             Sự lựa chọn của bạn: ");
			}
			private static void Menuqlve() throws IOException
			{
				Vexe vx = new Vexe();
				vx.DocfileTxt("dsvx.txt");
				vx.Xuat();
				System.out.println("                                                                 1.Đăng ký vé                                   3.Tìm kiếm vé đã mua theo chuyến\n");
				System.out.println("                                                                 2.Xóa vé                                       4.Tìm kiếm vé đã mua theo nơi đến \n");
				System.out.println("                                                                 5.Sắp xếp theo thứ tự tăng dần mã chuyến       6.Thoát \n");
				System.out.print("                                                                                          Sự lựa chọn của bạn: ");
			}
}


