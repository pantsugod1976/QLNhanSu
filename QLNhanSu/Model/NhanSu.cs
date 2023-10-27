using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Model
{
    internal class NhanSu
    {
        private int id;
        private string name;
        private bool gt;
        private DateTime ngaysinh;
        private string chuc_vu;
        private string phong_ban;
        private string address;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public bool GT
        {
            get { return gt; }
            set { gt = value; }
        }

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public string Chuc_vu
        {
            get { return chuc_vu; }
            set { chuc_vu = value; }
        }

        public string Phong_ban
        {
            get { return phong_ban; }
            set { phong_ban = value; }
        }
        public NhanSu()
        {
        }

        public NhanSu(int id, string name, bool gt, string address, DateTime ngaysinh, string chuc_vu, string phong_ban)
        {
            Random rd = new Random();
            this.id = rd.Next(100, 1000);
            this.name = name;
            this.gt = gt;
            this.address = address;
            this.ngaysinh = ngaysinh;
            this.chuc_vu = chuc_vu;
            this.phong_ban = phong_ban;
        }
    }
}
