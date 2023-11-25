using QLNhanSu.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.View.ChildView.FunctionForm
{
    public partial class DayChange : Form
    {
        public int ma_nv;
        private AdminViewModel viewModel = new AdminViewModel();
        public DayChange()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumber.Text))
            {
                this.Close();
            }
            viewModel.updateChamCong(ma_nv, int.Parse(tbNumber.Text));
            this.Close();
        }
    }
}
