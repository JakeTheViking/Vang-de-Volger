using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    partial class GameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.GameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MediumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LargeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RestartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.DrawingArea = new System.Windows.Forms.Panel();
            this.PauseForm = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            this.DrawingArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PauseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameMenuItem,
            this.OptionsMenuItem,
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
            this.SizeMenuItem,
            this.ControlsMenuItem});
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
            this.SizeMenuItem.Size = new System.Drawing.Size(181, 26);
            this.SizeMenuItem.Text = "Size";
            // 
            // SmallMenuItem
            // 
            this.SmallMenuItem.Name = "SmallMenuItem";
            this.SmallMenuItem.Size = new System.Drawing.Size(181, 26);
            this.SmallMenuItem.Text = "Small";
            this.SmallMenuItem.Click += new System.EventHandler(this.SmallMenuItem_Click);
            // 
            // MediumMenuItem
            // 
            this.MediumMenuItem.Name = "MediumMenuItem";
            this.MediumMenuItem.Size = new System.Drawing.Size(181, 26);
            this.MediumMenuItem.Text = "Medium";
            this.MediumMenuItem.Click += new System.EventHandler(this.MediumMenuItem_Click);
            // 
            // LargeMenuItem
            // 
            this.LargeMenuItem.Name = "LargeMenuItem";
            this.LargeMenuItem.Size = new System.Drawing.Size(181, 26);
            this.LargeMenuItem.Text = "Large";
            this.LargeMenuItem.Click += new System.EventHandler(this.LargeMenuItem_Click);
            // 
            // ControlsMenuItem
            // 
            this.ControlsMenuItem.Name = "ControlsMenuItem";
            this.ControlsMenuItem.Size = new System.Drawing.Size(181, 26);
            this.ControlsMenuItem.Text = "Controls";
            this.ControlsMenuItem.Click += new System.EventHandler(this.ControlsMenuItem_Click);
            // 
            // OptionsMenuItem
            // 
            this.OptionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PauseMenuItem,
            this.RestartMenuItem});
            this.OptionsMenuItem.Name = "OptionsMenuItem";
            this.OptionsMenuItem.Size = new System.Drawing.Size(73, 24);
            this.OptionsMenuItem.Text = "Options";
            // 
            // PauseMenuItem
            // 
            this.PauseMenuItem.Name = "PauseMenuItem";
            this.PauseMenuItem.Size = new System.Drawing.Size(130, 26);
            this.PauseMenuItem.Text = "Pause";
            this.PauseMenuItem.Click += new System.EventHandler(this.PauseMenuItem_Click);
            // 
            // RestartMenuItem
            // 
            this.RestartMenuItem.Name = "RestartMenuItem";
            this.RestartMenuItem.Size = new System.Drawing.Size(130, 26);
            this.RestartMenuItem.Text = "Restart";
            this.RestartMenuItem.Click += new System.EventHandler(this.RestartMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(53, 24);
            this.HelpMenuItem.Text = "Help";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerTick);
            // 
            // DrawingArea
            // 
            this.DrawingArea.BackgroundImage = global::Vang_de_Volger.Properties.Resources.Background32x32;
            this.DrawingArea.Controls.Add(this.PauseForm);
            this.DrawingArea.Location = new System.Drawing.Point(0, 28);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(800, 800);
            this.DrawingArea.TabIndex = 0;
            // 
            // PauseForm
            // 
            this.PauseForm.BackColor = System.Drawing.Color.Transparent;
            this.PauseForm.BackgroundImage = global::Vang_de_Volger.Properties.Resources.Pause;
            this.PauseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseForm.Location = new System.Drawing.Point(0, 0);
            this.PauseForm.Name = "PauseForm";
            this.PauseForm.Size = new System.Drawing.Size(64, 64);
            this.PauseForm.TabIndex = 0;
            this.PauseForm.TabStop = false;
            this.PauseForm.Visible = false;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 528);
            this.Controls.Add(this.DrawingArea);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vang de Volger";
            this.Shown += new System.EventHandler(this.GameWindow_Shown);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.DrawingArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PauseForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingArea;
        private System.Windows.Forms.Timer gameTimer;
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem GameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SizeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmallMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MediumMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LargeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ControlsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PauseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RestartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private PictureBox PauseForm;
    }
}