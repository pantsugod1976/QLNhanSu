using QLNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.ViewModel
{
    internal class UserViewModel : BaseViewModel
    {
        private SQLConnect connection = new SQLConnect();

        public void addChamCong(NhanSu ns, int songay)
        {
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var date = DateTime.Now;
                var thang = date.Month;
                var nam = date.Year;
                var sql = "MERGE ChamCong AS [Target] " +
                    "\nUSING (SELECT ma_nv = @id, thang = @thang, nam = @nam) AS [Source] " +
                    "\nON [Target].ma_nv = [Source].ma_nv AND [Target].thang = [Source].thang AND [Target].nam = [Source].nam " +
                    "\nWHEN MATCHED THEN " +
                    "\nUPDATE SET [Target].so_ngay = @so_ngay " +
                    "\nWHEN NOT MATCHED THEN " +
                    "\nINSERT VALUES ([Source].ma_nv, [Source].thang, [Source].nam, @so_ngay);";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", ns.ID);
                cmd.Parameters.AddWithValue("thang", thang);
                cmd.Parameters.AddWithValue("nam", nam);
                cmd.Parameters.AddWithValue("so_ngay", songay);
                cmd.ExecuteNonQuery();
            }
        }

        public int soNgayChamCong(int user_id)
        {
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var date = DateTime.Now;
                var thang = date.Month;
                var nam = date.Year;
                var sql = "SELECT * FROM ChamCong WHERE ma_nv = @id AND thang = @thang AND nam = @nam";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", user_id);
                cmd.Parameters.AddWithValue("thang", thang);
                cmd.Parameters.AddWithValue("nam", nam);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return (int)reader.GetValue(4);
                        }  
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }
    }
}
