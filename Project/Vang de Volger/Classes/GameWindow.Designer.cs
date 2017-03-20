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
            this.pauseButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DrawingArea
            // 
            this.DrawingArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DrawingArea.Location = new System.Drawing.Point(128, 64);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(512, 512);
            this.DrawingArea.TabIndex = 0;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(128, 632);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(80, 32);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.TabStop = false;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseClick);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(224, 632);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(80, 32);
            this.restartButton.TabIndex = 0;
            this.restartButton.TabStop = false;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartClick);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerTick);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 721);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.DrawingArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vang de Volger";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.ResumeLayout(false);

        }

        private void DrawingArea_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel DrawingArea;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Timer gameTimer;
    }
}