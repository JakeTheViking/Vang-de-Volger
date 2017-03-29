using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    public partial class GameWindow : Form
    {
        public const int GAMEWINDOW_HEIGHT = Entity.ASSET_SIZE * Level.LEVEL_HEIGHT;
        public const int GAMEWINDOW_WIDTH = Entity.ASSET_SIZE * Level.LEVEL_WIDTH;
        public const int FORM_HEIGHT = 382;
        public const int FORM_WIDTH = 336;
        private int pauseCount;
        private bool paused;
        private Level _level;
        private Graphics g;
        public GameWindow()
        {
            InitializeComponent();
            Start();
        }
        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {

        }
        private void gameTimerTick(object sender, EventArgs e)
        {
        }
        
        private void Start()
        {
            g = DrawingArea.CreateGraphics();
            DrawingArea.Size = new Size(GAMEWINDOW_WIDTH, GAMEWINDOW_HEIGHT);
            this.Size = new Size(FORM_WIDTH, FORM_HEIGHT);
            _level = new Level(g, this.TopLevelControl, Level.LEVEL_WIDTH, Level.LEVEL_HEIGHT);
        }
        private void Restart()
        {
            paused = false;
        }
        private void Reset()
        {
            DrawingArea.BackgroundImage = new Bitmap(Vang_de_Volger.Properties.Resources.Background32x32);
        }

        private void GameWindow_Shown(object sender, EventArgs e)
        {
            _level.DrawEntities();
        }

        private void SmallMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            DrawingArea.Size = new Size(GAMEWINDOW_WIDTH, GAMEWINDOW_HEIGHT);
            this.Size = new Size(FORM_WIDTH, FORM_HEIGHT);
            _level.ChangeSize(1, 1);
        }

        private void MediumMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            DrawingArea.Size = new Size(GAMEWINDOW_WIDTH * 2, GAMEWINDOW_HEIGHT * 2);
            this.Size = new Size(FORM_WIDTH * 2, FORM_HEIGHT * 2);
            g = DrawingArea.CreateGraphics();
            _level.ChangeSize(2, 2);
        }

        private void LargeMenuItem_Click(object sender, EventArgs e)
        {
            //Reset();
            //DrawingArea.Size = new Size(GAMEWINDOW_WIDTH * 3, GAMEWINDOW_HEIGHT * 2);
            //this.Size = new Size(FORM_WIDTH * 3, FORM_HEIGHT * 2);
            //g = DrawingArea.CreateGraphics();
            //_level.ChangeSize(3, 2);
        }

    }
}
