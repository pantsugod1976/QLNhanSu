using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu.Model
{
    public class NhanSu
    {
        private int id;
        private string ho_ten;
        private string gt;
        private DateTime ngaysinh;
        private string dia_chi;
        private string sdt;
        private string qq;
        private int phong_ban;
        private int chuc_vu;
        private string password;
        private bool user_type;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string HT
        {
            get { return ho_ten; }
            set { ho_ten = value; }
        }

        public string DC
        {
            get { return dia_chi; }
            set { dia_chi = value; }
        }

        public string GT
        {
            get { return gt; }
            set { gt = value; }
        }

        public string QQ
        {
            get { return qq; }
            set { qq = value; }
        }

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public int Chuc_vu
        {
            get { return chuc_vu; }
            set { chuc_vu = value; }
        }

        public int Phong_ban
        {
            get { return phong_ban; }
            set { phong_ban = value; }
        }

        public bool User_type
        {
            get { return user_type; }
            set { user_type = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public NhanSu()
        {
        }

        public NhanSu(int id, string ho_ten, string gt, DateTime ngaysinh, string dia_chi, string sdt, string qq, int phong_ban, int chuc_vu, bool user_type, string password)
        {
            this.id = id;
            this.ho_ten = ho_ten;
            this.gt = gt;
            this.ngaysinh = ngaysinh;
            this.dia_chi = dia_chi;
            this.sdt = sdt;
            this.qq = qq;
            this.phong_ban = phong_ban;
            this.chuc_vu = chuc_vu;
            this.user_type = user_type;
            this.password = password;
        }

        public NhanSu(string ho_ten, string gt, DateTime ngaysinh, string dia_chi, string sdt, string qq, int phong_ban, int chuc_vu, bool user_type, string password)
        {
            this.ho_ten = ho_ten;
            this.gt = gt;
            this.ngaysinh = ngaysinh;
            this.dia_chi = dia_chi;
            this.sdt = sdt;
            this.qq = qq;
            this.phong_ban = phong_ban;
            this.chuc_vu = chuc_vu;
            this.user_type = user_type;
            this.password = password;
        }
    }
}
