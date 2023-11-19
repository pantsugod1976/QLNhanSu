using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic.Logging;
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
    internal class LoginViewModel
    {
        private SQLConnect connection = new SQLConnect();

        public NhanSu SignIn(string id, string password)
        {
            var temp = new NhanSu();
            using (SqlConnection conn = connection.getSQLConnection())
            {
                conn.Open();
                var sql = "SELECT * FROM NhanVien WHERE ma_nv = @id AND mk = @pass";
                var cmd = new SqlCommand(sql, conn);
                int ID = Convert.ToInt32(id);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("pass", password);
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
    }
}
