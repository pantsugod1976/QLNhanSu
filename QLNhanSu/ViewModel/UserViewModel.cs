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

        public void addChamCong(NhanSu ns, int songay, double hs)
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
                updadteLuong(songay, hs, ns.ID, ns.HSL);
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

        public void updadteLuong(int songay, double hs, int manv, decimal hsl)
        {
            double luong = ((double)hsl) * 1500000 + songay*hs*200000;
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var date = DateTime.Now;
                var thang = date.Month;
                var nam = date.Year;
                var sql =
                    "MERGE Luong AS [Target] " +
                    "\nUSING (SELECT ma_nv = @id, thang = @thang, nam = @nam) AS [Source] " +
                    "\nON [Target].ma_nv = [Source].ma_nv AND [Target].thang = [Source].thang AND [Target].nam = [Source].nam " +
                    "\nWHEN MATCHED THEN " +
                    "\nUPDATE SET [Target].Luong = @luong " +
                    "\nWHEN NOT MATCHED THEN " +
                    "\nINSERT VALUES ([Source].ma_nv, [Source].thang, [Source].nam, @luong);";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", manv);
                cmd.Parameters.AddWithValue("thang", thang);
                cmd.Parameters.AddWithValue("nam", nam);
                cmd.Parameters.AddWithValue("luong", luong);
                cmd.ExecuteNonQuery();
            }
        }

        public Luong GetLuong(int manv, int thang, int nam)
        {
            var temp = new Luong();
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var sql = "SELECT Luong.ma_nv, Luong.thang, Luong.nam, Luong, so_ngay FROM Luong " +
                    "join ChamCong on Luong.ma_nv = ChamCong.ma_nv AND Luong.thang = ChamCong.thang AND Luong.nam = ChamCong.nam " +
                    "WHERE Luong.ma_nv = @id AND Luong.thang = @thang AND Luong.nam = @nam";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", manv);
                cmd.Parameters.AddWithValue("thang", thang);
                cmd.Parameters.AddWithValue("nam", nam);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        temp = new Luong
                        {
                            manv = (int)reader.GetValue(0),
                            thang = (int)reader.GetValue(1),
                            nam = (int)reader.GetValue(2),
                            luong = (int)reader.GetValue(3)
                        };

                        if (reader.GetInt32(4) < 20)
                        {
                            temp.luong -= (20 - reader.GetInt32(4)) * 500000;
                        }

                        if (temp.luong > 10000000)
                        {
                            temp.luong -= temp.luong * 10 / 100;
                        }
                    }
                }
            }
            return temp;
        }
    }
}
