using QLNhanSu.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.ViewModel
{
    internal class AdminViewModel : BaseViewModel
    {
        private SQLConnect connection = new SQLConnect();
        private int count;

        public DataTable queryAll(string sql)
        {
            var dt = new DataTable();
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    var reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    return dt;
                }
            };
        }

        //Chuc vu
        public List<string> getListCV()
        {
            var l = new List<string>();
            var sql = "SELECT ma_cv as 'ID', ten_cv as 'Chức vụ', hs_phu_cap as 'Phụ cấp' FROM ChucVu";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        l.Add(reader.GetString(1));
                    }
                }
            }
            return l;
        }

        public void InsertCV(Chucvu cv)
        {
            var sql = "INSERT INTO ChucVU VALUES (@ten, @hs)";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ten", cv.TenCV);
                cmd.Parameters.AddWithValue("hs", cv.HS);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCV(int ID)
        {
            var sql =
                "DELETE FROM ChucVu WHERE ma_cv = @id";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", ID);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCV(Chucvu cv)
        {
            var sql = "UPDATE ChucVu SET ten_cv = @ten, hs_phu_cap = @hs where ma_cv = @id";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand (sql, conn);
                cmd.Parameters.AddWithValue("ten", cv.TenCV);
                cmd.Parameters.AddWithValue("id", cv.ID);
                cmd.Parameters.AddWithValue("hs", cv.HS);
                cmd.ExecuteNonQuery();
            }
        }

        //Phong
        public List<string> getListP()
        {
            var l = new List<string>();
            var sql = "SELECT ma_phong as 'ID', ten_phong as 'Phòng', dia_chi as 'Địa chỉ', so_dien_thoai as 'Số điện thoại' FROM Phong";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        l.Add(reader.GetString(1));
                    }
                }
            }
            return l;
        }

        public void InsertP(Phong p)
        {
            var sql = "INSERT INTO Phong VALUES (@ten, @dc, @sdt)";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ten", p.TenPhong);
                cmd.Parameters.AddWithValue("dc", p.DiaChi);
                cmd.Parameters.AddWithValue("sdt", p.SDT);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteP(int ID)
        {
            var sql =
                "DELETE FROM ChucVu WHERE ma_phong = @id";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", ID);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateP(Phong p)
        {
            var sql = "UPDATE Phong SET ten_phong = @ten, dia_chi = @dc, so_dien_thoai = @sdt where ma_phong = @id";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("ten", p.TenPhong);
                cmd.Parameters.AddWithValue("id", p.Id);
                cmd.Parameters.AddWithValue("dc", p.DiaChi);
                cmd.Parameters.AddWithValue("sdt", p.SDT);
                cmd.ExecuteNonQuery();
            }
        }

        //Nhan vien

        public NhanSu queryNV(string ID)
        {
            var temp = new NhanSu();
            using (SqlConnection conn = connection.getSQLConnection())
            {
                conn.Open();
                var sql = "SELECT * FROM NhanVien WHERE ma_nv = @id";
                var cmd = new SqlCommand(sql, conn);
                var id = Convert.ToInt32(ID);   
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return temp;
                    }
                    while (reader.Read())
                    {
                        string format = "dd/MM/yyyy";
                        CultureInfo customCulture = new CultureInfo("vi-VN");
                        customCulture.DateTimeFormat.ShortDatePattern = format;
                        temp = new NhanSu
                        {
                            ID = Convert.ToInt32(reader.GetValue(0)),
                            HT = reader.GetValue(1).ToString(),
                            GT = reader.GetValue(2).ToString(),
                            Ngaysinh = DateTime.Parse(reader.GetValue(3).ToString(), customCulture, DateTimeStyles.None),
                            DC = reader.GetValue(4).ToString(),
                            SDT = reader.GetValue(5).ToString(),
                            QQ = reader.GetValue(6).ToString(),
                            Phong_ban = Convert.ToInt32(reader.GetValue(7)),
                            Chuc_vu = Convert.ToInt32(reader.GetValue(8)),
                            User_type = Convert.ToInt32(reader.GetValue(10)) == 1 ? true : false,
                            Password = reader.GetValue(9).ToString(),
                        };
                    }
                }
                return temp;
            }
        }

        public void InsertNV(NhanSu ns)
        {
            var sql = "INSERT INTO NhanVien VALUES (@ht, @gt, @ns, @dc, @sdt, @qq, @phong, @cv, @pass, @type)";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
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

        public void DeleteNV(int ID)
        {
            var sql =
                "DELETE FROM NhanVien WHERE ma_nv = @id";
            using (var conn = connection.getSQLConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
