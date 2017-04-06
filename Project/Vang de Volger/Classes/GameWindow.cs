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
        public const int GAMEWINDOW_HEIGHT = Entity.ASSET_SIZE * Level.LEVEL_HEIGHT; //Constant value which is the value of the Panel's height. It is calculated by how many tiles in height (level_height) there are on load (by default 10) multiplied by the asset size.
        public const int GAMEWINDOW_WIDTH = Entity.ASSET_SIZE * Level.LEVEL_WIDTH; //Constant value which is the value of the Panel's width. It is calculated by how many tiles in width (level_width) there are on load (by default 10) multiplied by the asset size.
        public const int FORM_HEIGHT = 382; //Form height was a size that was best fit. This constant had to be scaled depending on size of the gameboard. Through testing this number gave the least white space around the edges. Menu bar is included here so that the menu bar is not overlapped by the panel.
        public const int FORM_WIDTH = 336;
        public bool paused = true; //A boolean that keeps the levels pause stored. This will be passed to the entities allowing them to move or not move. Also changed through the menu bar item "Pause".
        private Level _level; //Creates one level class.
        private Graphics g; //Graphics used to draw the images on the board.
        public GameWindow(int width, int height, int formWidth, int formHeight, int speed)
        {
            InitializeComponent();
            //On start set the background to a default grass texture if no other texture is given.
            //Run a start method which instantiates the level
            gameTimer.Interval = speed;
            this.Width = formWidth;
            this.Height = formHeight;
            Start(width, height);
        }
        /// <summary>
        /// This is a timer that on every tick draws the entities on their tiles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimerTick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// This method is used at the loading and start of the game. It sets the size of the panel to the largest it will be then creates the Graphics according to its max size.
        /// Then it creates the level and performs a click of Medium size in the toolbar on its own.
        /// The panel needs to be this big or else the Graphics will be cut off when the user changes the size later to a bigger size.
        /// </summary>
        private void Start(int width, int height)
        {
            DrawingArea.Size = new Size(GAMEWINDOW_WIDTH * 3, GAMEWINDOW_HEIGHT * 2);
            g = DrawingArea.CreateGraphics();

            _level = new Level(width, height, this, this.gameTimer, g, this.TopLevelControl);
        }
        
        /// <summary>
        /// Takes a bitmap and an alpha value.
        /// Creates a second bitmap with transparency using RGB.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="Alpha"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Fun little joke that if the user clicks on the HelpMenuItem it googles something funny.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void GameWindow_Shown(object sender, EventArgs e)
        {
            
            _level.DrawEntities();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.UserPaint,
                true);
        }
        public void Restart()
        {
            this.Close();
        }
        private void RestartMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }
        private void PauseMenuItem_Click(object sender, EventArgs e)
        {
            if (paused == true)
            {
                gameTimer.Stop();
                paused = false;
            }
            else
            {
                gameTimer.Start();
                paused = true;
            }
        }
    }
}
