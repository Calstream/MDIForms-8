namespace MDIForms_8
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.moveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.swapMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTile = new System.Windows.Forms.ToolStripMenuItem();
            this.vTile = new System.Windows.Forms.ToolStripMenuItem();
            this.cascade = new System.Windows.Forms.ToolStripMenuItem();
            this.arrange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu,
            this.closeMenu,
            this.closeAllMenu,
            this.exitMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveMenu,
            this.addMenu,
            this.swapMenu});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(152, 22);
            this.openMenu.Text = "Open...";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(152, 22);
            this.exitMenu.Text = "Exit";
            // 
            // moveMenu
            // 
            this.moveMenu.Enabled = false;
            this.moveMenu.Name = "moveMenu";
            this.moveMenu.Size = new System.Drawing.Size(152, 22);
            this.moveMenu.Text = "Move";
            this.moveMenu.Click += new System.EventHandler(this.moveMenu_Click);
            // 
            // addMenu
            // 
            this.addMenu.Enabled = false;
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(152, 22);
            this.addMenu.Text = "Add";
            this.addMenu.Click += new System.EventHandler(this.addMenu_Click);
            // 
            // swapMenu
            // 
            this.swapMenu.Enabled = false;
            this.swapMenu.Name = "swapMenu";
            this.swapMenu.Size = new System.Drawing.Size(152, 22);
            this.swapMenu.Text = "Swap";
            this.swapMenu.Click += new System.EventHandler(this.swapMenu_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.Enabled = false;
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(152, 22);
            this.closeMenu.Text = "Close";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // closeAllMenu
            // 
            this.closeAllMenu.Enabled = false;
            this.closeAllMenu.Name = "closeAllMenu";
            this.closeAllMenu.Size = new System.Drawing.Size(152, 22);
            this.closeAllMenu.Text = "Close All";
            this.closeAllMenu.Click += new System.EventHandler(this.closeAllMenu_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTile,
            this.vTile,
            this.cascade,
            this.arrange});
            this.windowToolStripMenuItem.Enabled = false;
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // hTile
            // 
            this.hTile.Name = "hTile";
            this.hTile.Size = new System.Drawing.Size(152, 22);
            this.hTile.Text = "HTile";
            this.hTile.Click += new System.EventHandler(this.change_layout);
            // 
            // vTile
            // 
            this.vTile.Name = "vTile";
            this.vTile.Size = new System.Drawing.Size(152, 22);
            this.vTile.Text = "VTile";
            this.vTile.Click += new System.EventHandler(this.change_layout);
            // 
            // cascade
            // 
            this.cascade.Name = "cascade";
            this.cascade.Size = new System.Drawing.Size(152, 22);
            this.cascade.Text = "Cascade";
            this.cascade.Click += new System.EventHandler(this.change_layout);
            // 
            // arrange
            // 
            this.arrange.Name = "arrange";
            this.arrange.Size = new System.Drawing.Size(152, 22);
            this.arrange.Text = "Arrange Icons";
            this.arrange.Click += new System.EventHandler(this.change_layout);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveMenu;
        private System.Windows.Forms.ToolStripMenuItem addMenu;
        private System.Windows.Forms.ToolStripMenuItem swapMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllMenu;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTile;
        private System.Windows.Forms.ToolStripMenuItem vTile;
        private System.Windows.Forms.ToolStripMenuItem cascade;
        private System.Windows.Forms.ToolStripMenuItem arrange;
    }
}

