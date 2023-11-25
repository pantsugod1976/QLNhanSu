using QLNhanSu.Model;
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

namespace QLNhanSu.View.ChildView.FunctionForm
{
    public partial class QLChamCong : Form
    {
        private AdminViewModel viewModel = new AdminViewModel();
        public AdminForm parent_form;
        public QLChamCong()
        {
            InitializeComponent();
        }

        private void GenerateTB(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void addPhong()
        {
            var list = viewModel.getListP();
            foreach (var item in list)
            {
                cbPhong.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent_form.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value;
            if (cbPhong.SelectedIndex == -1 && date.Month == DateTime.Now.Month)
            {
                GenerateTB(viewModel.queryChamCong());
                return;
            }

            if (cbPhong.SelectedIndex == -1)
            {
                GenerateTB(viewModel.queryChamCongDate(date.Month, date.Year));
                return;
            }
            var p = cbPhong.SelectedText.ToString();
            if (p != null)
            {
                GenerateTB(viewModel.queryChamCongDateP(date.Month, date.Year, p));
            }
        }

        private void QLChamCong_Load(object sender, EventArgs e)
        {
            var dt = viewModel.queryChamCong();
            dataGridView1.DataSource = dt;

            addPhong();
        }

        private void dataGridView1_EditModeChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var f = new DayChange();
            f.ma_nv = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.Columns["Mã nhân viên"].Index].Value.ToString());
            f.ShowDialog();
        }

        private void QLChamCong_Enter(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void QLChamCong_EnabledChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void QLChamCong_Shown(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void QLChamCong_Leave(object sender, EventArgs e)
        {

        }

        private void QLChamCong_Activated(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }
    }
}
