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
    public class ChiTiet
    {
        my_db mydb = new my_db();

        public bool insertChiTiet(string MaHD, string MaSach, int SoLuong, int Gia)
        {
            SqlCommand command = new SqlCommand("EXEC pro_ThemChiTietHoaDon @MaHD = @id, @MaSach = @ms, @SoLuong = @sl, @Gia = @gia", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.NVarChar).Value = MaHD;
            command.Parameters.Add("@ms", SqlDbType.NVarChar).Value = MaSach;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = SoLuong;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = Gia;

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
