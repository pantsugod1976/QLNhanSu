using QLNhanSu.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.View.ChildView
{
    public partial class QLLuong : Form
    {
        private AdminViewModel viewModel = new AdminViewModel();
        public AdminForm parent_form;
        public QLLuong()
        {
            InitializeComponent();
        }

        private void QLLuong_Load(object sender, EventArgs e)
        {
            addPhong();
        }

        private void addPhong()
        {
            var list = viewModel.getListP();
            foreach (var item in list)
            {
                cbPhong.Items.Add(item);
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            var phong = cbPhong.Text;
            dataGridView1.DataSource = viewModel.queryLuong(dateTimePicker1.Value.Month, phong);
            dataGridView1.Refresh();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            var dt = dataGridView1.DataSource as DataTable;
            viewModel.DataToCsv(dt);
        }

        private void btnLuongP_Click(object sender, EventArgs e)
        {
            int sum = 0;
            DataTable dt = dataGridView1.DataSource as DataTable;
            foreach (DataRow row in dt.Rows)
            {
                int value = int.Parse(row["Lương"].ToString());
                sum += value;
            }
            MessageBox.Show("Tổng lương của phòng = " + sum);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int tong = viewModel.tongLuong();
            MessageBox.Show("Tổng lương: " + tong);
        }
    }
}
