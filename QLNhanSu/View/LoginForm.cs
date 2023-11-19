using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNhanSu.View.ChildView.FunctionForm;
using QLNhanSu.ViewModel;

namespace QLNhanSu.View
{
    public partial class LoginForm : Form
    {
        private LoginViewModel viewModel = new LoginViewModel();
        public LoginForm()
        {
            InitializeComponent();
            tbPass.PasswordChar = '*';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var id = tbID.Text;
            var pass = tbPass.Text;

            if (id == "\r\n" || string.IsNullOrEmpty(id))
            {
                tbID.Focus();
                return;
            }

            if (pass == "\r\n" || string.IsNullOrEmpty(pass))
            {
                tbPass.Focus();
                return;
            }

            var account = viewModel.SignIn(id, pass);
            if (account != null)
            {
                if (account.HT == null)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    return;
                }

                if (account.User_type)
                {
                    this.Hide();
                    var f = new AdminForm();
                    f.ShowDialog();
                }
                else
                {
                    this.Hide();
                    var f = new UserForm();
                    f.setData(account);
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập lại");
                return;
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(686, 560);
            panel1.BackColor = ColorTranslator.FromHtml("#005ab7");
            pictureBox1.BackColor = ColorTranslator.FromHtml("#005ab7");
            lblTitle.ForeColor = ColorTranslator.FromHtml("#005ab7");
        }

        private void tbID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tbPass.Focus();
            }
        }

        private void tbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '*')
            {
                tbPass.PasswordChar = '\0';
            }
            else tbPass.PasswordChar = '*';
        }
    }
}
