using Microsoft.VisualBasic.Logging;
using QLNhanSu.Common;
using QLNhanSu.Model;
using QLNhanSu.View.ChildView.FunctionForm;
using QLNhanSu.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.View.ChildView
{
    public partial class QLNhanVien : Form, AdminListener
    {
        private AdminViewModel viewModel = new AdminViewModel();
        private SQLConnect connection = new SQLConnect();
        private DataTable dt = new DataTable();
        public AdminForm parentForm;

        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void GenerateTB()
        {
            dt.Clear();
            var sql = "SELECT ma_nv as 'ID', ho_ten as 'Họ tên', gt as 'Giới tính', ngay_sinh as 'Ngày sinh', dia_chi as 'Địa chỉ', so_dien_thoai as 'Số điện thoại', que_quan as 'Quê quán', ma_phong as 'Phòng', ma_cv as 'Chức vụ', mk as 'Password', user_type as 'Type' FROM NhanVien";
            dt = viewModel.queryAll(sql);

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            GenerateTB();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var f = new NVForm();
            f.listener = this;
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var f = new NVForm();
            f.listener = this;
            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.Columns["ID"].Index].Value.ToString();
            f.id = ID;
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.Columns["ID"].Index].Value.ToString();
            viewModel.DeleteNV(Convert.ToInt32(ID));
            GenerateTB();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }

        public void UpdateView()
        {
            GenerateTB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
