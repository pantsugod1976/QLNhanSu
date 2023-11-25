namespace QLNhanSu.View
{
    partial class AdminForm
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            quảnLíToolStripMenuItem = new ToolStripMenuItem();
            nhânSựToolStripMenuItem = new ToolStripMenuItem();
            phòngBanToolStripMenuItem = new ToolStripMenuItem();
            chứcVụToolStripMenuItem = new ToolStripMenuItem();
            chấmCôngToolStripMenuItem = new ToolStripMenuItem();
            lươngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            nhânViênToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, thốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(888, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quảnLíToolStripMenuItem, thoátToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // quảnLíToolStripMenuItem
            // 
            quảnLíToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhânSựToolStripMenuItem, phòngBanToolStripMenuItem, chứcVụToolStripMenuItem, chấmCôngToolStripMenuItem, lươngToolStripMenuItem });
            quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            quảnLíToolStripMenuItem.Size = new Size(112, 22);
            quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // nhânSựToolStripMenuItem
            // 
            nhânSựToolStripMenuItem.Name = "nhânSựToolStripMenuItem";
            nhânSựToolStripMenuItem.Size = new Size(136, 22);
            nhânSựToolStripMenuItem.Text = "Nhân sự";
            nhânSựToolStripMenuItem.Click += nhânSựToolStripMenuItem_Click;
            // 
            // phòngBanToolStripMenuItem
            // 
            phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            phòngBanToolStripMenuItem.Size = new Size(136, 22);
            phòngBanToolStripMenuItem.Text = "Phòng ban";
            phòngBanToolStripMenuItem.Click += phòngBanToolStripMenuItem_Click;
            // 
            // chứcVụToolStripMenuItem
            // 
            chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            chứcVụToolStripMenuItem.Size = new Size(136, 22);
            chứcVụToolStripMenuItem.Text = "Chức vụ";
            chứcVụToolStripMenuItem.Click += chứcVụToolStripMenuItem_Click;
            // 
            // chấmCôngToolStripMenuItem
            // 
            chấmCôngToolStripMenuItem.Name = "chấmCôngToolStripMenuItem";
            chấmCôngToolStripMenuItem.Size = new Size(136, 22);
            chấmCôngToolStripMenuItem.Text = "Chấm công";
            chấmCôngToolStripMenuItem.Click += chấmCôngToolStripMenuItem_Click;
            // 
            // lươngToolStripMenuItem
            // 
            lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            lươngToolStripMenuItem.Size = new Size(136, 22);
            lươngToolStripMenuItem.Text = "Lương";
            lươngToolStripMenuItem.Click += lươngToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(112, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhânViênToolStripMenuItem });
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(68, 20);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // nhânViênToolStripMenuItem
            // 
            nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            nhânViênToolStripMenuItem.Size = new Size(180, 22);
            nhânViênToolStripMenuItem.Text = "Nhân Viên";
            nhânViênToolStripMenuItem.Click += nhânViênToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 458);
            panel1.TabIndex = 1;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 487);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosed += AdminForm_FormClosed;
            Load += AdminForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem quảnLíToolStripMenuItem;
        private ToolStripMenuItem nhânSựToolStripMenuItem;
        private ToolStripMenuItem phòngBanToolStripMenuItem;
        private ToolStripMenuItem chứcVụToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem chấmCôngToolStripMenuItem;
        private ToolStripMenuItem lươngToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem nhânViênToolStripMenuItem;
    }
}