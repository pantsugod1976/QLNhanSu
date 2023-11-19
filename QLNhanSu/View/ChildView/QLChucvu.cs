using QLNhanSu.Common;
using QLNhanSu.Model;
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
    public partial class QLChucvu : Form, AdminListener
    {
        public AdminForm parentForm;
        private AdminViewModel viewModel = new AdminViewModel();
        public QLChucvu()
        {
            InitializeComponent();
        }

        private void QLChucvu_Load(object sender, EventArgs e)
        {
            GenerateTB();
        }

        private void GenerateTB()
        {
            var sql = "SELECT ma_cv as 'ID', ten_cv as 'Chức vụ', hs_phu_cap as 'Phụ cấp' FROM ChucVu";
            dataGridView1.DataSource = viewModel.queryAll(sql);
            dataGridView1.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var f = new CVForm();
            f.listener = this;
            f.ShowDialog();
        }

        public void UpdateView()
        {
            GenerateTB();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.Columns["ID"].Index].Value.ToString();
            viewModel.DeleteCV(Int32.Parse(ID));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var f = new CVForm();
            string ID = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.Columns["ID"].Index].Value.ToString();
            f.listener = this;
            f.id = ID;
            f.ShowDialog();
        }
    }
}
