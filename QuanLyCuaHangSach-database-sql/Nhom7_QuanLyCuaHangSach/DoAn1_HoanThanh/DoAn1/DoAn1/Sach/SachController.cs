using DoAn1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.Sach
{
    public class SachController
    {
        my_db mydb = new my_db();

        public bool insertBook(string ID, string name, string tacGia, string NXB, string moTa, string cate, int quantity, int price)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SanPham (MaSach, TenSach, TacGia, NXB, MoTa, Danhmuc, SoLuongTon, Gia) VALUES (@id, @name, @tg, @nxb, @mota, @dm, @sl, @gia)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@tg", SqlDbType.NVarChar).Value = tacGia;
            command.Parameters.Add("@nxb", SqlDbType.NVarChar).Value = NXB;
            command.Parameters.Add("@mota", SqlDbType.NVarChar).Value = moTa;
            command.Parameters.Add("@dm", SqlDbType.NVarChar).Value = cate;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = price;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateBook(string ID, string name, string tacGia, string NXB, string moTa, string cate, int quantity, int price)
        {
            SqlCommand command = new SqlCommand("exec pro_SuaSanPham @MaSach = @id, @TenSach = @name, @TacGia =@tg, @NXB = @nxb, @Mota = @mota, @Danhmuc = @dm, @SoLuongTon = @sl, @Gia = @gia", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@tg", SqlDbType.NVarChar).Value = tacGia;
            command.Parameters.Add("@nxb", SqlDbType.NVarChar).Value = NXB;
            command.Parameters.Add("@mota", SqlDbType.NVarChar).Value = moTa;
            command.Parameters.Add("@dm", SqlDbType.NVarChar).Value = cate;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = quantity;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = price;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteBook(string ID)
        {
            SqlCommand command = new SqlCommand("EXEC pro_XoaSanPham @MaSach = @ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID;


            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateQuantity(string ID, int quantity)
        {
            SqlCommand command = new SqlCommand("UPDATE SanPham SET SoLuongTon = @quantity WHERE MaSach = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int LaySoLuongSachTon(string ID)
        {
            SqlCommand command = new SqlCommand("SELECT dbo.GetAmout(@id)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;

            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            mydb.closeConnection();
            return Convert.ToInt32(table.Rows[0][0]);
        }

        public bool checkIDBook(string ID)
        {
            SqlCommand command = new SqlCommand("EXEC pro_GetProductByID @ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
          
            DataTable table = new DataTable();
            adapter.Fill(table);
            mydb.openConnection();

            if (table.Rows.Count >= 1)
            {
                Global.Global.setTenSach(table.Rows[0]["TenSach"].ToString());
                Global.Global.setTacGia(table.Rows[0]["TacGia"].ToString());
                Global.Global.setNXB(table.Rows[0]["NXB"].ToString());
                Global.Global.setMoTa(table.Rows[0]["MoTa"].ToString());
                Global.Global.setDanhMuc(table.Rows[0]["DanhMuc"].ToString());
                Global.Global.setSoLuong(Convert.ToInt32(table.Rows[0]["SoLuongTon"].ToString()));
                Global.Global.setStatus(Convert.ToBoolean(table.Rows[0]["TrangThai"].ToString()));
                Global.Global.setGia(Convert.ToInt32(table.Rows[0]["Gia"].ToString()));

                mydb.closeConnection();          
                return false;
            }
            return true;
        }

        public DataTable getAllBook()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Tat_ca_sach_view", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllBookProc()
        {
            SqlCommand command = new SqlCommand("EXEC pro_GetAllProducts", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getBookByID(string ID)
        {
            SqlCommand command = new SqlCommand("EXEC pro_GetProductByID @ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = ID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getBookByName(string Name)
        {
            SqlCommand command = new SqlCommand("EXEC pro_GetProductByName @Name", mydb.getConnection);
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = Name;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getBookByCate(string Cate)
        {
            SqlCommand command = new SqlCommand("EXEC pro_GetProductByCategory @Cate", mydb.getConnection);
            command.Parameters.Add("@Cate", SqlDbType.NVarChar).Value = Cate;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
