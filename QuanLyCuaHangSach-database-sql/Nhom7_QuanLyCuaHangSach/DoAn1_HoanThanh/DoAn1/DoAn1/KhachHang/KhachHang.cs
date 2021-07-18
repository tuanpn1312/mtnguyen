using DoAn1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.KhachHang
{
    public class KhachHang
    {
        my_db mydb = new my_db();

        public bool insertCustomer(string CMND, string ten, DateTime ngaysinh, string dienthoai, string diachi)
        {
            SqlCommand command = new SqlCommand("EXEC pro_AddUser @cmnd = @CMND, @hovaten = @Ten,@ngaysinh = @Ngaysinh, @sdt = @SDT,@diachi = @Diachi", mydb.getConnection);
            command.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = CMND;
            command.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = dienthoai;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;

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

        public bool updateCustomer(string CMND, string ten, DateTime ngaysinh, string dienthoai, string diachi)
        {
            SqlCommand command = new SqlCommand("EXEC pro_UpdateUser @cmnd = @CMND, @hovaten = @Ten,@ngaysinh = @Ngaysinh, @sdt = @SDT,@diachi = @Diachi", mydb.getConnection);
            command.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = CMND;
            command.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = ten;
            command.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = ngaysinh;
            command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = dienthoai;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diachi;

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

        public bool deleteCustomer(string CMND)
        {
            SqlCommand command = new SqlCommand("EXEC pro_DeleteUser @cmnd = @CMND", mydb.getConnection);
            command.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = CMND;


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

        public DataTable getAllUser()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM All_User_View", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllUserPro()
        {
            SqlCommand command = new SqlCommand("Exec pro_GetAllInfoOfUser", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getUserByCMND(string CMND)
        {
            SqlCommand command = new SqlCommand("EXEC pro_GetUserByCMND @cmnd", mydb.getConnection);
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = CMND;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getTongKhachHang()
        {
            SqlCommand command = new SqlCommand("SELECT dbo.fun_tinhtongsokhachhang()", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getTuoiKhachHang(string CMND)
        {
            SqlCommand command = new SqlCommand("SELECT dbo.tinhtuoikhachhang(@cmnd)", mydb.getConnection);
            command.Parameters.Add("@cmnd", SqlDbType.NVarChar).Value = CMND;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
      
    }
}
