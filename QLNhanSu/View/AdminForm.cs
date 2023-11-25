using QLNhanSu.View.ChildView;
using QLNhanSu.View.ChildView.FunctionForm;
using QLNhanSu.View.ChildView.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.View
{
    public partial class AdminForm : Form
    {
        private Form cur_childForm;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open_ChildForm(new QLNhanVien());
        }

        private void open_ChildForm(Form child_form)
        {
            if (cur_childForm != null)
            {
                cur_childForm.Close();
            }
            cur_childForm = child_form;
            child_form.TopLevel = false;
            child_form.FormBorderStyle = FormBorderStyle.None;
            child_form.Dock = DockStyle.Fill;
            panel1.Controls.Add(child_form);
            panel1.Tag = child_form;
            child_form.BringToFront();
            child_form.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1163, 567);
            var f = new QLNhanVien();
            f.parentForm = this;
            open_ChildForm(f);
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new QLPhongban();
            f.parentForm = this;
            open_ChildForm(f);
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new QLChucvu();
            f.parentForm = this;
            open_ChildForm(f);
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms["LoginForm"].Show();
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new QLChamCong();
            f.parent_form = this;
            open_ChildForm(f);
        }

        private void lươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new QLLuong();
            f.parent_form = this;
            open_ChildForm(f);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new TKNhanVien();
            f.ShowDialog();
        }

        private void bảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
