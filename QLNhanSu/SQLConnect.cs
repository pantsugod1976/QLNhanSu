using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLNhanSu.Model;

namespace QLNhanSu
{
    internal class SQLConnect
    {
        private string database = "DESKTOP-RG3MHSF";
        private string datasource = "nhansu";
        private string _connectionString;

        public SQLConnect()
        {
            _connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", datasource, database);
        }

        public List<NhanSu> getAll()
        {
            List<NhanSu> list = new List<NhanSu>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var sql = "SELECT * FROM nhansu";
                SqlCommand cmd = new SqlCommand(sql, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var gt = reader["GT"].ToString().Equals("Nam");
                        var date = DateTime.Parse(reader["date"].ToString());
                        
                        list.Add(
                            new NhanSu(
                                Convert.ToInt32(reader["ID"]), 
                                reader["hoten"].ToString(), 
                                gt, 
                                reader["diachi"].ToString(), 
                                date, 
                                reader["chucvu"].ToString(), 
                                reader["phongban"].ToString())
                            );
                    }
                }
            }
            return list;
        }

        public void Insert(NhanSu ns)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                var gt = ns.GT ? "Nam" : "Nu";
                var sql = string.Format("INSERT into nhansu VALUES({0}, {1}, {2}, {3}, {4}, {5}, {6})", ns.ID, ns.Name, gt, ns.Address, ns.Ngaysinh.ToString(), ns.Chuc_vu, ns.Phong_ban);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public void Delete(NhanSu ns)
        {
            using (var con = new SqlConnection(_connectionString))
            {
                con.Open();
                var sql = string.Format("DELETE FROM nhansu WHERE ID = {0}", ns.ID);
                var cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public void Update(NhanSu ns)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var gt = ns.GT ? "Nam" : "Nu";
                var sql = string.Format("UPDATE nhansu " +
                    "SET hoten = {1}, GT = {2}, diachi = {3}, date = {4}, chucvu = {5}, phongban = {6}" +
                    " WHERE ID = {0}", ns.ID, ns.Name, gt, ns.Address, ns.Ngaysinh.ToString(), ns.Chuc_vu, ns.Phong_ban);
                var cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public NhanSu Detail(NhanSu ns)
        {
            var res = new NhanSu();
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var sql = string.Format("SELECT * FROM nhansu WHERE id = {0}", ns.ID);
                var cmd = new SqlCommand(sql, conn);
                using (var reader =  cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var gt = reader["GT"].ToString().Equals("Nam");
                        var date = DateTime.Parse(reader["date"].ToString());
                        res = new NhanSu(
                                Convert.ToInt32(reader["ID"]),
                                reader["hoten"].ToString(),
                                gt,
                                reader["diachi"].ToString(),
                                date,
                                reader["chucvu"].ToString(),
                                reader["phongban"].ToString())
                            ;
                    }
                }
            }
            return res;
        }
    }
}
