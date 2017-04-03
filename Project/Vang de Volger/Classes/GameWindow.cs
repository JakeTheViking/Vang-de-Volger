using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Vang_de_Volger.Classes
{
    public partial class GameWindow : Form
    {
        public const int GAMEWINDOW_HEIGHT = Entity.ASSET_SIZE * Level.LEVEL_HEIGHT;
        public const int GAMEWINDOW_WIDTH = Entity.ASSET_SIZE * Level.LEVEL_WIDTH;
        public const int FORM_HEIGHT = 382;
        public const int FORM_WIDTH = 336;
        private bool paused = false;
        private Level _level;
        private Graphics g;
        private Bitmap background;
        public GameWindow()
        {
            InitializeComponent();
            if (background == null)
            {
                background = Vang_de_Volger.Properties.Resources.Background32x32;
            }
            Start();
        }
        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {

        }
        private void gameTimerTick(object sender, EventArgs e)
        {
            _level.DrawEntities(background);
        }

        private void Start()
        {
            DrawingArea.Size = new Size(GAMEWINDOW_WIDTH * 3, GAMEWINDOW_HEIGHT * 2);
            g = DrawingArea.CreateGraphics();

            _level = new Level(g, this.TopLevelControl, paused);

            MediumMenuItem.PerformClick();
        }
        private void Restart()
        {
            if(SmallMenuItem.Checked == true)
            {
                ChangeLevel(1, 1);
            } else if(MediumMenuItem.Checked == true)
            {
                ChangeLevel(2, 2);
            } else if (LargeMenuItem.Checked == true)
            {
                ChangeLevel(3, 2);
            }
        }
        private void Pause()
        {

        }
        private void GameWindow_Shown(object sender, EventArgs e)
        {
            _level.DrawEntities(background);
        }
        private void SmallMenuItem_Click(object sender, EventArgs e)
        {
            SmallMenuItem.Checked = true;
            MediumMenuItem.Checked = false;
            LargeMenuItem.Checked = false;
            DrawingArea.Size = new Size(GAMEWINDOW_WIDTH, GAMEWINDOW_HEIGHT);
            this.Size = new Size(FORM_WIDTH, FORM_HEIGHT);
            ChangeLevel(1, 1);
        }
        private void MediumMenuItem_Click(object sender, EventArgs e)
        {
            SmallMenuItem.Checked = false;
            MediumMenuItem.Checked = true;
            LargeMenuItem.Checked = false;
            DrawingArea.Size = new Size(GAMEWINDOW_WIDTH * 2, GAMEWINDOW_HEIGHT * 2);
            this.Size = new Size(FORM_WIDTH * 2, FORM_HEIGHT * 2);
            ChangeLevel(2, 2);
        }
        private void LargeMenuItem_Click(object sender, EventArgs e)
        {
            SmallMenuItem.Checked = false;
            MediumMenuItem.Checked = false;
            LargeMenuItem.Checked = true;
            DrawingArea.Size = new Size(GAMEWINDOW_WIDTH * 3, GAMEWINDOW_HEIGHT * 2);
            this.Size = new Size(FORM_WIDTH * 3, FORM_HEIGHT * 2);
            ChangeLevel(3, 2);
        }
        private void ChangeLevel(int width, int height)
        {
            int rows = width * Level.LEVEL_WIDTH;
            int columns = height * Level.LEVEL_HEIGHT;
            _level.Reset();
            _level.ChangeSize(rows, columns);
            _level.DrawEntities(background);
        }

        private void PauseMenuItem_Click(object sender, EventArgs e)
        {
            if (paused == false)
            {
                background = Vang_de_Volger.Properties.Resources.Paused;
                _level.ChangePause(paused);
                _level.DrawEntities(background);
                paused = true;
            }
            else
            {
                background = Vang_de_Volger.Properties.Resources.Background32x32;
                _level.ChangePause(paused);
                paused = false;
            }
        }

        private void RestartMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private static Bitmap TransparentImage(Image image, Byte Alpha)
        {
            Bitmap original = new Bitmap(image);
            Bitmap transparentImage = new Bitmap(image.Width, image.Height);

            Color c = Color.Black;
            Color v = Color.Black;

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    c = original.GetPixel(x, y);
                    v = Color.FromArgb(Alpha, c.R, c.G, c.B);
                    transparentImage.SetPixel(x, y, v);
                }
            }

            return transparentImage;
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://lmgtfy.com/?q=I+don%27t+know+ask+Vincent+-+Tim");
        }

        private void ControlsMenuItem_Click(object sender, EventArgs e)
        {
            paused = true;
        }

    }
}
