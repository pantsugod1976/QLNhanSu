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
    public partial class CVForm : Form
    {
        public string id = "";
        public AdminListener listener;
        private bool isInsert = true;
        private AdminViewModel viewModel = new AdminViewModel();

        public CVForm()
        {
            InitializeComponent();
        }

        private void CVForm_Load(object sender, EventArgs e)
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

                var temp = viewModel.queryCV(Convert.ToInt32(id));
                tbName.Text = temp.TenCV;
                tbHS.Text = temp.HS.ToString();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btFunction_Click(object sender, EventArgs e)
        {
            if (isInsert)
            {
                var temp = new Chucvu
                {
                    TenCV = tbName.Text,
                    HS = Convert.ToDouble(tbHS.Text)
                };
                viewModel.InsertCV(temp);
            }
            else
            {
                var temp = new Chucvu
                {
                    ID = Convert.ToInt32(id),
                    TenCV = tbName.Text,
                    HS = Convert.ToDouble(tbHS.Text)
                };
                viewModel.UpdateCV(temp);
            }
            listener.UpdateView();
            this.Close();
        }
    }
}
