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
    public class ChiTiet
    {
        my_db mydb = new my_db();

        public bool insertChiTiet(int ID, string MaSach, int SoLuong)
        {
            SqlCommand command = new SqlCommand("EXEC pro_ThemChiTietPhieuNhap @id = @Id, @masach = @ms, @soluong = @sl", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.NVarChar).Value = ID;
            command.Parameters.Add("@ms", SqlDbType.NVarChar).Value = MaSach;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = SoLuong;

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
    }
}
