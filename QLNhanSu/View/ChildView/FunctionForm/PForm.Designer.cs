namespace QLNhanSu.View.ChildView.FunctionForm
{
    partial class PForm
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
            tbSDT = new TextBox();
            label3 = new Label();
            tbDC = new TextBox();
            tbName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btCancel
            // 
            btCancel.Location = new Point(567, 142);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(112, 48);
            btCancel.TabIndex = 12;
            btCancel.Text = "Thoát";
            btCancel.UseVisualStyleBackColor = true;
            // 
            // btFunction
            // 
            btFunction.Location = new Point(107, 142);
            btFunction.Name = "btFunction";
            btFunction.Size = new Size(112, 48);
            btFunction.TabIndex = 11;
            btFunction.Text = "Button";
            btFunction.UseVisualStyleBackColor = true;
            btFunction.Click += btFunction_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSDT);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbDC);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 110);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // tbSDT
            // 
            tbSDT.Location = new Point(473, 22);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(193, 23);
            tbSDT.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(416, 30);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 18;
            label3.Text = "SĐT";
            // 
            // tbDC
            // 
            tbDC.Location = new Point(96, 62);
            tbDC.Name = "tbDC";
            tbDC.Size = new Size(193, 23);
            tbDC.TabIndex = 16;
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
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Địa chỉ";
            // 
            // PForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 202);
            Controls.Add(btCancel);
            Controls.Add(btFunction);
            Controls.Add(groupBox1);
            Name = "PForm";
            Text = "PForm";
            Load += PForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btCancel;
        private Button btFunction;
        private GroupBox groupBox1;
        private TextBox tbSDT;
        private Label label3;
        private TextBox tbDC;
        private TextBox tbName;
        private Label label2;
        private Label label1;
    }
}