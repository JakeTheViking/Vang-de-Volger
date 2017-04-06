namespace Vang_de_Volger.Classes
{
    partial class Game
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.GameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameMenuItem,
            this.speedToolStripMenuItem,
            this.HelpMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(750, 28);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // GameMenuItem
            // 
            this.GameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SizeMenuItem});
            this.GameMenuItem.Name = "GameMenuItem";
            this.GameMenuItem.Size = new System.Drawing.Size(60, 24);
            this.GameMenuItem.Text = "Game";
            // 
            // SizeMenuItem
            // 
            this.SizeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmallMenuItem,
            this.MediumMenuItem,
            this.LargeMenuItem});
            this.SizeMenuItem.Name = "SizeMenuItem";
            this.SizeMenuItem.Size = new System.Drawing.Size(139, 26);
            this.SizeMenuItem.Text = "Size";
            // 
            // SmallMenuItem
            // 
            this.SmallMenuItem.Name = "SmallMenuItem";
            this.SmallMenuItem.Size = new System.Drawing.Size(139, 26);
            this.SmallMenuItem.Text = "Small";
            this.SmallMenuItem.Click += new System.EventHandler(this.SmallMenuItem_Click);
            // 
            // MediumMenuItem
            // 
            this.MediumMenuItem.Name = "MediumMenuItem";
            this.MediumMenuItem.Size = new System.Drawing.Size(139, 26);
            this.MediumMenuItem.Text = "Medium";
            this.MediumMenuItem.Click += new System.EventHandler(this.MediumMenuItem_Click);
            // 
            // LargeMenuItem
            // 
            this.LargeMenuItem.Name = "LargeMenuItem";
            this.LargeMenuItem.Size = new System.Drawing.Size(139, 26);
            this.LargeMenuItem.Text = "Large";
            this.LargeMenuItem.Click += new System.EventHandler(this.LargeMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(53, 24);
            this.HelpMenuItem.Text = "Help";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.Image = global::Vang_de_Volger.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(31, 49);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(221, 223);
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.fastToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.slowToolStripMenuItem.Text = "Slow";
            this.slowToolStripMenuItem.Click += new System.EventHandler(this.slowToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.fastToolStripMenuItem.Text = "Fast";
            this.fastToolStripMenuItem.Click += new System.EventHandler(this.fastToolStripMenuItem_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 214);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.Text = "Angry Chicken";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem GameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MediumMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LargeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
    }
}