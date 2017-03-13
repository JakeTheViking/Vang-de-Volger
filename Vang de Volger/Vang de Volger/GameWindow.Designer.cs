namespace Vang_de_Volger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.DrawingArea = new System.Windows.Forms.Panel();
            this.RestartGUI = new System.Windows.Forms.Button();
            this.PauzeGUI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawingArea
            // 
            this.DrawingArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DrawingArea.Location = new System.Drawing.Point(-9, 50);
            this.DrawingArea.Name = "DrawingArea";
            this.DrawingArea.Size = new System.Drawing.Size(800, 653);
            this.DrawingArea.TabIndex = 0;
            this.DrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingArea_Paint);
            // 
            // RestartGUI
            // 
            this.RestartGUI.Location = new System.Drawing.Point(90, 743);
            this.RestartGUI.Name = "RestartGUI";
            this.RestartGUI.Size = new System.Drawing.Size(72, 32);
            this.RestartGUI.TabIndex = 4;
            this.RestartGUI.Text = "Restart";
            this.RestartGUI.UseVisualStyleBackColor = true;
            this.RestartGUI.Click += new System.EventHandler(this.RestartGUI_Click);
            // 
            // PauzeGUI
            // 
            this.PauzeGUI.Location = new System.Drawing.Point(12, 743);
            this.PauzeGUI.Name = "PauzeGUI";
            this.PauzeGUI.Size = new System.Drawing.Size(72, 32);
            this.PauzeGUI.TabIndex = 3;
            this.PauzeGUI.Text = "Pauze";
            this.PauzeGUI.UseVisualStyleBackColor = true;
            this.PauzeGUI.Click += new System.EventHandler(this.PauzeGUI_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(Game.CANVAS_HEIGHT, Game.CANVAS_WIDTH);
            this.Controls.Add(this.RestartGUI);
            this.Controls.Add(this.PauzeGUI);
            this.Controls.Add(this.DrawingArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vang de Volger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyDown);
            this.ResumeLayout(false);

        }

        private void DrawingArea_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel DrawingArea;
        private System.Windows.Forms.Button RestartGUI;
        private System.Windows.Forms.Button PauzeGUI;
    }
}