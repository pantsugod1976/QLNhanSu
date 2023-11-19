namespace QLNhanSu.View.ChildView.FunctionForm
{
    partial class CVForm
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
            btCancel = new Button();
            btFunction = new Button();
            groupBox1 = new GroupBox();
            tbHS = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btCancel
            // 
            btCancel.Location = new Point(229, 160);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(112, 48);
            btCancel.TabIndex = 9;
            btCancel.Text = "Thoát";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btFunction
            // 
            btFunction.Location = new Point(25, 160);
            btFunction.Name = "btFunction";
            btFunction.Size = new Size(112, 48);
            btFunction.TabIndex = 8;
            btFunction.Text = "Button";
            btFunction.UseVisualStyleBackColor = true;
            btFunction.Click += btFunction_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbHS);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 110);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // tbHS
            // 
            tbHS.Location = new Point(96, 62);
            tbHS.Name = "tbHS";
            tbHS.Size = new Size(193, 23);
            tbHS.TabIndex = 16;
            // 
            // tbName
            // 
            tbName.Location = new Point(95, 22);
            tbName.Name = "tbName";
            tbName.Size = new Size(193, 23);
            tbName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên chức vụ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Hệ số phụ cấp";
            // 
            // CVForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 228);
            Controls.Add(btCancel);
            Controls.Add(btFunction);
            Controls.Add(groupBox1);
            Name = "CVForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CVForm";
            Load += CVForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btCancel;
        private Button btFunction;
        private GroupBox groupBox1;
        private ComboBox cbType;
        private Label lblType;
        private TextBox tbPass;
        private Label lblPass;
        private ComboBox cbPhong;
        private ComboBox cbCV;
        private TextBox tbHS;
        private TextBox tbID;
        private TextBox tbQQ;
        private TextBox tbDC;
        private TextBox tbSDT;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbGT;
        private TextBox tbName;
        private Label label7;
        private Label label6;
        private Label label19;
        private Label label5;
        private Label label4;
        private Label label17;
        private Label label3;
        private Label label2;
        private Label label15;
        private Label label1;
    }
}