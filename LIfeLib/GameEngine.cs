using System;
using System.Drawing;

namespace LifeLib
{
    public struct Cell
    {  
        /// <summary>
        /// Коородината Х.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Коородината Y.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Флаг: живая или мертвая клетка
        /// </summary>
        public bool IsAlive { get; set; }

        public Brush Brush { get; set; }

        /// <summary>
        /// Инициализировать клетку.
        /// </summary>
        /// <param name="x">Координата Х</param>
        /// <param name="y">Координата Y</param>
        /// <param name="color">Цвет клетки</param>
        /// <param name="isAlive">Флаг: живая или мертвая клетка</param>
        public Cell(int x, int y, bool isAlive, Brush brush)
        {
            X = x;
            Y = y;
            IsAlive = isAlive;
            Brush = Brushes.White;
        }
    }

    public class GameEngine
    {
        #region Fields
        /// <summary>
        /// Игровое поле
        /// </summary>
        private bool[,] Field;
        
        /// <summary>
        /// Кол-во клеток на поле
        /// </summary>
        private Cell[] Cells;

        /// <summary>
        /// Ширина поля.
        /// </summary>
        private readonly int Rows;

        /// <summary>
        /// Высота поля.
        /// </summary>
        private readonly int Columns;

        /// <summary>
        /// Кол-во генераций
        /// </summary>
        public uint Generation { get; private set; }

        /// <summary>
        /// Генератор псевдослучайных чисел
        /// </summary>
        Random random;

        #endregion

        /// <summary>
        /// Инициализация движка и клеток
        /// </summary>
        /// <param name="color">Цвет клетки.</param>
        /// <param name="width">Кол-во строчек.</param>
        /// <param name="height">Кол-во столбцов.</param>
        /// <param name="density">Кучность генерации клеток.</param>
        public GameEngine(int rows = 1, int columns = 1, 
                            int density = 2)
        {
            #region Check
            if (rows == 0)
                throw new ArgumentException("В поле не может быть 0 строк.", "rows");

            if (columns == 0)
                throw new ArgumentException("В поле не может быть 0 столбцов.", "colums");
            #endregion

            Rows = rows;
            Columns = columns;

            Field = new bool[rows, columns];

            random = new Random();

            StartGeneration(density);
        }

        private void StartGeneration(int density)
        {
            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    Field[x, y] = random.Next(density) == 0;                            
                }
            }
        }

        public void NextGeneration()
        {
            var newField = new bool[Rows, Columns];

            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    var neightbCount = CheckRules(x, y);
                    var hasAlife = Field[x, y];

                    if (!hasAlife && neightbCount == 3)
                        newField[x, y] = true;
                    else if (hasAlife && (neightbCount < 2 || neightbCount > 3))
                        newField[x, y] = false;
                    else
                        newField[x, y] = Field[x, y];
                }
            }

            Field = newField; 
            Generation++;
        }

        public bool[,] GetGeneration()
        {
            bool[,] newField = new bool[Rows, Columns];

            for (int x = 0; x < Field.GetLength(0); x++)
            {
                for (int y = 0; y < Field.GetLength(1); y++)
                {
                    newField[x, y] = Field[x, y];
                }
            }
            return newField;
        }

        private int CheckRules(int x, int y)
        {
            int counter = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var row = (x + i + Rows) % Rows;
                    var col = (y + j + Columns) % Columns;

                    var isSelfChecking = col == x && row == y;
                    var hasAlive = Field[row, col];

                    if (hasAlive && !isSelfChecking)
                        counter++;
                }
            }

            return counter;
        }
    }
}
