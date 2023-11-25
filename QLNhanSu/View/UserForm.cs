using QLNhanSu.Common;
using QLNhanSu.Model;
using QLNhanSu.View.ChildView.FunctionForm;
using QLNhanSu.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.View
{
    public partial class UserForm : Form, AdminListener
    {
        private NhanSu nhansu = new NhanSu();
        private Phong phong = new Phong();
        private Chucvu chucvu = new Chucvu();
        private int songay = 0;

        private UserViewModel viewModel = new UserViewModel();
        public UserForm()
        {
            InitializeComponent();
        }

        public void setData(NhanSu ns)
        {
            nhansu = ns;
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(686, 560);
            ngayChamCong();
            GenerateView();
        }

        private void GenerateView()
        {
            lblName.Text = nhansu.HT;
            lblDC.Text = nhansu.DC;
            lblSDT.Text = nhansu.SDT;
            lblGT.Text = nhansu.GT;
            lblDate.Text = nhansu.Ngaysinh.ToShortDateString();
            lblQQ.Text = nhansu.QQ;
            lblID.Text = nhansu.ID.ToString();

            phong = viewModel.queryPhong(nhansu.Phong_ban);
            chucvu = viewModel.queryCV(nhansu.Chuc_vu);
            lblCV.Text = chucvu.TenCV;
            lblPhong.Text = phong.TenPhong;
            lblHS.Text = chucvu.HS.ToString();
        }

        private void ngayChamCong()
        {
            var ngayCC = viewModel.soNgayChamCong(nhansu.ID);
            songay = ngayCC;
            var date = DateTime.Now;
            lblCC.Text = "Đã chấm công " + ngayCC.ToString() + " trong tháng " + date.Month + "/" + date.Year;
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["LoginForm"].Show();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value;
            if (date.Month == DateTime.Now.Month && date.Year == DateTime.Now.Year) {
                MessageBox.Show("Tháng làm việc chưa kết thúc");
                return;
            }
            if(date.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Chọn năm hợp lệ");
                return;
            }
            int manv = Convert.ToInt32(lblID.Text);
            var luong = viewModel.GetLuong(manv, date.Month, date.Year);
            if (luong != null)
            {
                lblCalLuong.Text = luong.luong.ToString() + "đ";
            }
            else
            {
                MessageBox.Show("Information not found");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var f = new NVForm();
            f.id = nhansu.ID.ToString();
            f.isFromUser = true;
            f.listener = this;
            f.ShowDialog();
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            songay++;
            var hs = Convert.ToDouble(lblHS.Text);
            viewModel.addChamCong(nhansu, songay, hs);
            ngayChamCong();
        }

        public void UpdateView()
        {
            GenerateView();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = viewModel.queryChamCongNV(nhansu.ID);
            var f = new TTChamCong();
            f.dt = dt;
            f.ShowDialog(this);
        }
    }
}
