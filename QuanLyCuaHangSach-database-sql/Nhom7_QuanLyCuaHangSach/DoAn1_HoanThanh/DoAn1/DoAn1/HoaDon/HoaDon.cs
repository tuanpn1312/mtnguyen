using DoAn1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.HoaDon
{
    public class HoaDon
    {
        my_db mydb = new my_db();

        public bool insertHoaDon(string ID, string name, int sum, bool trangThai, DateTime date)
        {
            SqlCommand command = new SqlCommand("EXEC pro_ThemHoaDon @MaHD = @id, @TenKH = @name, @TongTien = @sum, @TrangThai = @tt, @NgayTao = @date", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@sum", SqlDbType.Int).Value = sum;
            command.Parameters.Add("@tt", SqlDbType.Bit).Value = trangThai;
            command.Parameters.Add("@tt", SqlDbType.DateTime).Value = date;

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

        public DataTable getDonHangChuaHoanThanh()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Don_hang_chua_hoan_thanh_view", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getTongSachBanDc()
        {
            SqlCommand command = new SqlCommand("SELECT dbo.fun_tinhtonsachbandc()", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getTongDoanhThu()
        {
            SqlCommand command = new SqlCommand("SELECT dbo.fun_tinhtongdoanhthu()", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getALlInfoOfOrder()
        {
            SqlCommand command = new SqlCommand("Exec pro_GetAllInfoOfOrder", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getOrderByID()
        {
            SqlCommand command = new SqlCommand("Exec pro_GetOrderByID", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
