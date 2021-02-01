using LifeLib;
using System.Drawing;
using System.Windows.Forms;

namespace Window
{
    public partial class Form1 : Form
    {
        private Graphics graphics;        
        private int resolution;

        private GameEngine gameEngine;

        /// <summary>
        /// Флаг для кнопки Pause/Resume
        /// </summary>
        private bool isPause;

        /// <summary>
        /// Флаг для кнопок Start и Stop
        /// </summary>
        private bool isStart;

        public Form1()
        {
            InitializeComponent();
        }

        void StartGame()
        {
            //проверка таймера
            if (timer.Enabled)
                return;

            //выключение NumericUpDown
            numResolution.Enabled = false;
            numDensity.Enabled = false;

            resolution = (int)numResolution.Value;

            //инициализация движка
            gameEngine = new GameEngine(
                rows: Window.Width / resolution,
                columns: Window.Height / resolution,
                density: (int)numDensity.Value
            );

            label3.Text = $"Generation: {gameEngine.Generation}";

            isPause = true;
            isStart = false;

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
            label3.Text = $"Generation: {gameEngine.Generation}";
        }

        #region Events

        //Кнопка Старт
        private void button1_Click(object sender, System.EventArgs e)
        {
            StartGame();
            isStart = true;
        }

        //Кнопка Стоп
        private void button2_Click(object sender, System.EventArgs e)
        {
            //активируем NumericUpDown
            numResolution.Enabled = true;
            numDensity.Enabled = true;

            //сбрасывает параметры кнопки Пауза
            button3.Text = "Пауза";
            isStart = false;            

            //очищаем и обновляем окно 
            graphics.Clear(Color.Black);
            Window.Refresh();

            timer.Stop();

            label3.Text = $"Generation: 0";           
        }

        //Кнопка Пауза/Продолжить
        private void button3_Click(object sender, System.EventArgs e)
        {
            if(isStart) {
                if (isPause)
                {
                    isPause = false;
                    button3.Text = "Продолжить";
                    timer.Stop();
                }
                else {
                    isPause = true;
                    button3.Text = "Пауза";
                    timer.Start();
                }
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            DrawNextGeneration();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                gameEngine.DrawCell(e.Location.X, e.Location.Y, resolution);
            }

            if (e.Button == MouseButtons.Right)
            {
                gameEngine.ClearCell(e.Location.X, e.Location.Y, resolution);
            }
        }

        private void Window_Click(object sender, System.EventArgs e)
        {

        }

        #endregion

        //TODO: Добавить возможность создавать новые поля
        //TODO: Добавить паузу !?
        //TODO: Добавить редактор карты. С инструментами: добавления, удаления, очищения и тд.

    }
}
