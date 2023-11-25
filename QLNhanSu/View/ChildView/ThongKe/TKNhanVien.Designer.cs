namespace QLNhanSu.View.ChildView.ThongKe
{
    partial class TKNhanVien
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
            dataGridView1 = new DataGridView();
            btnEx = new Button();
            cbPhong = new ComboBox();
            panel1 = new Panel();
            btnSearch = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 0;
            // 
            // btnEx
            // 
            btnEx.Location = new Point(171, 65);
            btnEx.Name = "btnEx";
            btnEx.Size = new Size(75, 23);
            btnEx.TabIndex = 1;
            btnEx.Text = "Export";
            btnEx.UseVisualStyleBackColor = true;
            btnEx.Click += btnEx_Click;
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(21, 22);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(121, 23);
            cbPhong.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(cbPhong);
            panel1.Controls.Add(btnEx);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(171, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(655, 21);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // TKNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "TKNhanVien";
            Text = "TKNhanVien";
            Load += TKNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEx;
        private ComboBox cbPhong;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSearch;
    }
}