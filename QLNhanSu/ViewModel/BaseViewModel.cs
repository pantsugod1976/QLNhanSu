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
    internal class BaseViewModel
    {
        private SQLConnect connection = new SQLConnect();

        public void UpdateNV(NhanSu ns)
        {
            var sql = "UPDATE NhanVien SET ho_ten = @ht, gt = @gt, ngay_sinh = @ns, dia_chi = @dc, so_dien_thoai = @sdt, que_quan = @qq, ma_phong = @phong, ma_cv = @cv, mk = @pass, user_type = @type WHERE ma_nv = @id";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", ns.ID);
                cmd.Parameters.AddWithValue("ht", ns.HT);
                cmd.Parameters.AddWithValue("gt", ns.GT);
                cmd.Parameters.AddWithValue("ns", ns.Ngaysinh.ToShortDateString());
                cmd.Parameters.AddWithValue("dc", ns.DC);
                cmd.Parameters.AddWithValue("sdt", ns.SDT);
                cmd.Parameters.AddWithValue("qq", ns.QQ);
                cmd.Parameters.AddWithValue("phong", ns.Phong_ban);
                cmd.Parameters.AddWithValue("cv", ns.Chuc_vu);
                cmd.Parameters.AddWithValue("pass", ns.Password);
                cmd.Parameters.AddWithValue("type", ns.User_type);
                cmd.ExecuteNonQuery();
            }
        }

        public Chucvu queryCV(int ID)
        {
            var id = ID;
            var sql = "SELECT * FROM ChucVu WHERE ma_cv = @id";
            var temp = new Chucvu();
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return temp;
                    }
                    while (reader.Read())
                    {
                        temp = new Chucvu
                        {
                            ID = Convert.ToInt32(reader.GetValue(0)),
                            TenCV = reader.GetValue(1).ToString(),
                            HS = Convert.ToDouble(reader.GetValue(2))
                        };
                    }
                }
                return temp;
            }
        }

        public Phong queryPhong(int ID)
        {
            var id = ID;
            var sql = "SELECT * FROM Phong WHERE ma_phong = @id";
            var temp = new Phong();
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return temp;
                    }
                    while (reader.Read())
                    {
                        temp = new Phong
                        {
                            Id = Convert.ToInt32(reader.GetValue(0)),
                            TenPhong = reader.GetValue(1).ToString(),
                            DiaChi = reader.GetValue(2).ToString(),
                            SDT = reader.GetValue(3).ToString()
                        };
                    }
                }
                return temp;
            }
        }

        public DataTable queryChamCong()
        {
            var sql = "SELECT * FROM ChamCong";
            var temp = new DataTable();
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand (sql, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    temp.Load(reader);
                }
            }
            return (temp);
        }
    }
}
