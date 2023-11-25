namespace QLNhanSu.View.ChildView.FunctionForm
{
    partial class QLChamCong
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
            panel1 = new Panel();
            btnSearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            cbPhong = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
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
            dataGridView1.Size = new Size(1147, 528);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cbPhong);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 428);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 100);
            panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(200, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(12, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(12, 21);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(165, 23);
            cbPhong.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1013, 30);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(804, 30);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 46);
            btnSave.TabIndex = 0;
            btnSave.Text = "Change";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // QLChamCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 528);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "QLChamCong";
            Text = "QLChamCong";
            Activated += QLChamCong_Activated;
            Load += QLChamCong_Load;
            Shown += QLChamCong_Shown;
            EnabledChanged += QLChamCong_EnabledChanged;
            Enter += QLChamCong_Enter;
            Leave += QLChamCong_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnCancel;
        private Button btnSave;
        private Button btnSearch;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbPhong;
    }
}