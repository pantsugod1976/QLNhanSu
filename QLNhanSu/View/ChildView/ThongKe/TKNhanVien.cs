using QLNhanSu.Model;
using QLNhanSu.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.View.ChildView.ThongKe
{
    public partial class TKNhanVien : Form
    {
        private AdminViewModel viewModel = new AdminViewModel();
        private DataTable dt = new DataTable();
        public TKNhanVien()
        {
            InitializeComponent();
        }

        private void addPhong()
        {
            var list = viewModel.getListP();
            foreach (var item in list)
            {
                cbPhong.Items.Add(item);
            }
        }

        private void TKNhanVien_Load(object sender, EventArgs e)
        {
            addPhong();
            dt.Clear();
            var sql = "SELECT ma_nv as 'ID', ho_ten as 'Họ tên', gt as 'Giới tính', ngay_sinh as 'Ngày sinh', dia_chi as 'Địa chỉ', so_dien_thoai as 'Số điện thoại', que_quan as 'Quê quán', ma_phong as 'Phòng', ma_cv as 'Chức vụ', mk as 'Password', user_type as 'Type' FROM NhanVien";
            dt = viewModel.queryAll(sql);
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            viewModel.DataToCsv(dt);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = viewModel.queryNVP(cbPhong.Text);
            dataGridView1.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
