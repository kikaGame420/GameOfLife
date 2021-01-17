using LifeLib;
using System.Drawing;
using System.Windows.Forms;

namespace Window
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private GameEngine gameEngine;
        private int resolution;

        public Form1()
        {
            InitializeComponent();
        }

        void StartGame()
        {
            if (timer.Enabled)
                return;

            numResolution.Enabled = false;
            numDensity.Enabled = false;

            resolution = (int)numResolution.Value;

            gameEngine = new GameEngine(
                rows: Window.Width / resolution,
                columns: Window.Height / resolution,
                density: (int)numDensity.Value
            );

            Text = $"Generation: {gameEngine.Generation}";

            Window.Image = new Bitmap(Window.Width, Window.Height);
            graphics = Graphics.FromImage(Window.Image);
            timer.Start();
        }

        void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);

            gameEngine.NextGeneration();
            var field = gameEngine.GetGeneration();

            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x,y])
                        graphics.FillRectangle(Brushes.Crimson, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }    
            }                

            Window.Refresh();
            Text = $"Generation: {gameEngine.Generation}";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
             StartGame();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            numResolution.Enabled = true;
            numDensity.Enabled = true;

            graphics.Clear(Color.Black);

            timer.Stop();

            Text = $"Generation: 0";           
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            DrawNextGeneration();
        }
    }
}
