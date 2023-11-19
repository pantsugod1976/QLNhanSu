using QLNhanSu.Common;
using QLNhanSu.View.ChildView.FunctionForm;
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
    public partial class QLPhongban : Form, AdminListener
    {
        public AdminForm parentForm;
        private AdminViewModel viewModel = new AdminViewModel();
        public QLPhongban()
        {
            InitializeComponent();
        }

        private void QLPhongban_Load(object sender, EventArgs e)
        {
            GenerateTB();
        }

        private void GenerateTB()
        {
            var sql = "SELECT ma_phong as 'ID', ten_phong as 'Phòng', dia_chi as 'Địa chỉ', so_dien_thoai as 'Số điện thoại' FROM Phong";
            dataGridView1.DataSource = viewModel.queryAll(sql);
            dataGridView1.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var f = new PForm();
            f.listener = this;
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.Columns["ID"].Index].Value.ToString();
            viewModel.DeleteP(Int32.Parse(ID));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var f = new PForm();
            f.listener = this;
            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.Columns["ID"].Index].Value.ToString();
            f.id = ID;
            f.ShowDialog();
        }

        public void UpdateView()
        {
            GenerateTB();
        }
    }
}
