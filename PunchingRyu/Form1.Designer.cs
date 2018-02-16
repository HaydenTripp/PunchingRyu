namespace PunchingRyu
{
    partial class frmRyu
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
            this.pictureRyu = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ryuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRyu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureRyu
            // 
            this.pictureRyu.Image = global::PunchingRyu.Properties.Resources.stand;
            this.pictureRyu.Location = new System.Drawing.Point(45, 83);
            this.pictureRyu.Name = "pictureRyu";
            this.pictureRyu.Size = new System.Drawing.Size(253, 223);
            this.pictureRyu.TabIndex = 0;
            this.pictureRyu.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ryuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ryuToolStripMenuItem
            // 
            this.ryuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.punchToolStripMenuItem,
            this.standToolStripMenuItem});
            this.ryuToolStripMenuItem.Name = "ryuToolStripMenuItem";
            this.ryuToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.ryuToolStripMenuItem.Text = "Ryu";
            // 
            // punchToolStripMenuItem
            // 
            this.punchToolStripMenuItem.Name = "punchToolStripMenuItem";
            this.punchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.punchToolStripMenuItem.Text = "Punch";
            this.punchToolStripMenuItem.Click += new System.EventHandler(this.punchToolStripMenuItem_Click);
            // 
            // standToolStripMenuItem
            // 
            this.standToolStripMenuItem.Name = "standToolStripMenuItem";
            this.standToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.standToolStripMenuItem.Text = "Stand";
            this.standToolStripMenuItem.Click += new System.EventHandler(this.standToolStripMenuItem_Click);
            // 
            // frmRyu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 349);
            this.Controls.Add(this.pictureRyu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRyu";
            this.Text = "Punch";
            ((System.ComponentModel.ISupportInitialize)(this.pictureRyu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRyu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ryuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standToolStripMenuItem;
    }
}

