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
            this.DrawingArea = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RestartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PauseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawingArea
            // 
            this.DrawingArea.BackgroundImage = global::Vang_de_Volger.Properties.Resources.Background32x32;
            this.DrawingArea.Location = new System.Drawing.Point(0, 28);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(800, 800);
            this.DrawingArea.TabIndex = 0;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerTick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestartMenuItem,
            this.PauseMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RestartMenuItem
            // 
            this.RestartMenuItem.Name = "RestartMenuItem";
            this.RestartMenuItem.Size = new System.Drawing.Size(67, 24);
            this.RestartMenuItem.Text = "Restart";
            this.RestartMenuItem.Click += new System.EventHandler(this.RestartMenuItem_Click);
            // 
            // PauseMenuItem
            // 
            this.PauseMenuItem.Name = "PauseMenuItem";
            this.PauseMenuItem.Size = new System.Drawing.Size(58, 24);
            this.PauseMenuItem.Text = "Pause";
            this.PauseMenuItem.Click += new System.EventHandler(this.PauseMenuItem_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 528);
            this.Controls.Add(this.DrawingArea);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Angry Chicken";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.Shown += new System.EventHandler(this.GameWindow_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawingArea;
        
        private Timer gameTimer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem RestartMenuItem;
        private ToolStripMenuItem PauseMenuItem;
    }
}