using DoAn1.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1.PhieuNhap
{
    public class PhieuNhap
    {
        my_db mydb = new my_db();

        public bool insertPhieuNhap(int ID, DateTime date, string ncc, int sum)
        {
            SqlCommand command = new SqlCommand("EXEC pro_ThemPhieuNhap @id = @Id, @NgayNhap = @date, @NhaCungCap = @ncc, @TongSoLuong = @sum", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = date;
            command.Parameters.Add("@ncc", SqlDbType.NVarChar).Value = ncc;
            command.Parameters.Add("@sum", SqlDbType.Int).Value = sum;

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

        public bool updateTongSoLuong(int ID, int tong)
        {
            SqlCommand command = new SqlCommand("UPDATE PhieuNhap SET TongSoLuong = @tong WHERE ID = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@tong", SqlDbType.Int).Value = tong;

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

        public void layIDPhieuNhap()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP 1 ID FROM PhieuNhap ORDER BY ID DESC", mydb.getConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count >= 1)
            {
                int ID = Convert.ToInt32(table.Rows[0]["ID"].ToString());
                Global.Global.setMaPhieuNhap(ID + 1);
            }
            else
            {
                Global.Global.setMaPhieuNhap(1);
            }
        }
    }
}
