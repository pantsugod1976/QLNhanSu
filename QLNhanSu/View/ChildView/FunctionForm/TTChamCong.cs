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
    public partial class TTChamCong : Form
    {
        public TTChamCong()
        {
            InitializeComponent();
        }

        public DataTable dt;

        private void TTChamCong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
        }
    }
}
