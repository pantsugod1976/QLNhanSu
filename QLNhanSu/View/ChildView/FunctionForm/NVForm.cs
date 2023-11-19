using QLNhanSu.Common;
using QLNhanSu.Model;
using QLNhanSu.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhanSu.View.ChildView.FunctionForm
{
    public partial class NVForm : Form
    {
        public string id = "";
        private bool isInsert = true;
        public bool isFromUser = false;
        public AdminListener listener;
        private AdminViewModel viewModel = new AdminViewModel();
        public NVForm()
        {
            InitializeComponent();
        }

        private void NVForm_Load(object sender, EventArgs e)
        {
            addCV();
            addPhong();

            if (id != "")
            {
                isInsert = false;
            }

            if (isInsert)
            {
                btFunction.Text = "Thêm";
            }
            else
            {
                cbCV.Enabled = !isFromUser;
                cbPhong.Enabled = !isFromUser;
                tbHS.Enabled = false;
                cbType.Enabled = !isFromUser;
                tbID.Enabled = !isFromUser;
                btnCC.Visible = !isFromUser;


                btFunction.Text = "Cập nhật";
                var ns = viewModel.queryNV(id);
                var cv = viewModel.queryCV(ns.Chuc_vu);
                var phong = viewModel.queryPhong(ns.Phong_ban);
                tbHT.Text = ns.HT;
                tbDC.Text = ns.DC;
                tbID.Text = ns.ID.ToString();
                tbQQ.Text = ns.QQ;
                tbSDT.Text = ns.SDT;
                dateTimePicker1.Text = ns.Ngaysinh.ToShortDateString();
                tbPass.Text = ns.Password;
                if (ns.User_type)
                {
                    cbType.SelectedIndex = 0;
                }
                else
                {
                    cbType.SelectedIndex = 1;
                }
                if (ns.GT == "nam")
                {
                    cbGT.SelectedIndex = 0;
                }
                else
                {
                    cbGT.SelectedIndex = 1;
                }
                tbHS.Text = cv.HS.ToString();
                cbCV.SelectedIndex = cbCV.Items.IndexOf(cv.TenCV);
                cbPhong.SelectedIndex = cbPhong.Items.IndexOf(phong.TenPhong);
            }
        }

        private void addCV()
        {
            var list = viewModel.getListCV();
            foreach (var item in list)
            {
                cbCV.Items.Add(item);
            }
        }

        private void addPhong()
        {
            var list = viewModel.getListP();
            foreach (var item in list)
            {
                cbPhong.Items.Add(item);
            }
        }

        private void btFunction_Click(object sender, EventArgs e)
        {
            string format = "dd/MM/yyyy";
            CultureInfo customCulture = new CultureInfo("vi-VN");
            customCulture.DateTimeFormat.ShortDatePattern = format;

            var type = false;

            if (cbType.SelectedIndex == 0)
            {
                type = true;
            }

            var tmp = new NhanSu
            {
                HT = tbHT.Text,
                GT = cbGT.Text.ToLower(),
                DC = tbDC.Text,
                SDT = tbSDT.Text,
                Ngaysinh = DateTime.Parse(dateTimePicker1.Text, customCulture, DateTimeStyles.None),
                QQ = tbQQ.Text,
                Chuc_vu = cbCV.SelectedIndex,
                Password = tbPass.Text,
                Phong_ban = cbPhong.SelectedIndex,
                User_type = type
            };

            if (isInsert)
            {
                viewModel.InsertNV(tmp);
            }
            else
            {
                viewModel.UpdateNV(tmp);
            }
            listener.UpdateView();
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
