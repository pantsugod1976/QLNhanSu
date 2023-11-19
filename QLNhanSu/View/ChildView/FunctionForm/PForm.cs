using QLNhanSu.Common;
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
    public partial class PForm : Form
    {
        public string id = "";
        private bool isInsert = true;
        public AdminListener listener;
        private AdminViewModel viewModel = new AdminViewModel();
        public PForm()
        {
            InitializeComponent();
        }

        private void btFunction_Click(object sender, EventArgs e)
        {
            if (isInsert)
            {
                var tmp = new Phong
                {
                    TenPhong = tbName.Text,
                    DiaChi = tbDC.Text,
                    SDT = tbSDT.Text
                };
                viewModel.InsertP(tmp);
            }
            else
            {
                var tmp = new Phong
                {
                    Id = Convert.ToInt32(id),
                    TenPhong = tbName.Text,
                    DiaChi = tbDC.Text,
                    SDT = tbSDT.Text
                };
                viewModel.UpdateP(tmp);
            }
        }

        private void PForm_Load(object sender, EventArgs e)
        {
            if (id != "")
            {
                isInsert = false;
            }

            if (isInsert)
            {
                btFunction.Text = "Insert";
            }
            else
            {
                btFunction.Text = "Update";
                var tmp = viewModel.queryPhong(Convert.ToInt32(id));
                tbName.Text = tmp.TenPhong;
                tbDC.Text = tmp.DiaChi;
                tbSDT.Text = tmp.SDT;
            }
        }
    }
}
