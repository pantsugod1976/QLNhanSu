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
        private string database = "qlnhansu";
        private string datasource = "localhost";
        private string _connectionString;

        public SQLConnect()
        {
            _connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=true", datasource, database);
        }

        public SqlConnection getSQLConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
