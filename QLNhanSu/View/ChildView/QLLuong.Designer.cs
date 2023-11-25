namespace QLNhanSu.View.ChildView
{
    partial class QLLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSum = new Button();
            btnLuongP = new Button();
            btnEx = new Button();
            btnCal = new Button();
            dateTimePicker1 = new DateTimePicker();
            cbPhong = new ComboBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSum);
            panel1.Controls.Add(btnLuongP);
            panel1.Controls.Add(btnEx);
            panel1.Controls.Add(btnCal);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cbPhong);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 428);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 100);
            panel1.TabIndex = 0;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(467, 17);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(119, 48);
            btnSum.TabIndex = 9;
            btnSum.Text = "Tổng lương";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // btnLuongP
            // 
            btnLuongP.Location = new Point(308, 17);
            btnLuongP.Name = "btnLuongP";
            btnLuongP.Size = new Size(119, 48);
            btnLuongP.TabIndex = 8;
            btnLuongP.Text = "Lương của phòng";
            btnLuongP.UseVisualStyleBackColor = true;
            btnLuongP.Click += btnLuongP_Click;
            // 
            // btnEx
            // 
            btnEx.Location = new Point(1016, 40);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(119, 48);
            btnEx.TabIndex = 4;
            btnEx.Text = "Export";
            btnEx.UseVisualStyleBackColor = true;
            btnEx.Click += btnEx_Click;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(159, 17);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(119, 48);
            btnCal.TabIndex = 3;
            btnCal.Text = "Tính lương";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(12, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(12, 17);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(121, 23);
            cbPhong.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1147, 428);
            panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1147, 428);
            dataGridView1.TabIndex = 0;
            // 
            // QLLuong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 528);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "QLLuong";
            Text = "QLLuong";
            Load += QLLuong_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCal;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbPhong;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button btnEx;
        private Button btnSum;
        private Button btnLuongP;
    }
}