﻿using System;

namespace LifeLib
{

    public class GameEngine
    {
        #region Fields
        /// <summary>
        /// Игровое поле
        /// </summary>
        private bool[,] Field;
        
        ///// <summary>
        ///// Кол-во клеток на поле
        ///// </summary>
        //private Cell[] Cells;

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

        /// <summary>
        /// Сгенерировать стартовое поле.
        /// </summary>
        /// <param name="density">Кучность генерации.</param>
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

        /// <summary>
        /// Следующий цикл генерации.
        /// </summary>
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

        /// <summary>
        /// Получить копию игрового поля.
        /// </summary>
        /// <returns>Возвращает копию игрового поля.</returns>
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

        /// <summary>
        /// Проверка правил для клеток.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        /// <returns>Возвращает кол-во клеток рядом с искомой.</returns>
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

        /// <summary>
        /// Добавляет клетку в указанные координаты.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        /// <param name="resolution">Разрешение поля.</param>
        public void DrawCell(int x, int y, int resolution)
        {
            x = x / resolution;
            y = y / resolution;

            #region Check
            if (x >= Field.GetLength(0))
                throw new ArgumentOutOfRangeException("Координата Х выходит за пределы поля.");
            if(y >= Field.GetLength(1))
                throw new ArgumentOutOfRangeException("Координата Y выходит за пределы поля.");
            #endregion

            if (!Field[x, y])
                Field[x, y] = true;
        }

        /// <summary>
        /// Удаляет клетку в указанных координатах.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        /// /// <param name="resolution">Разрешение поля.</param>
        public void ClearCell(int x, int y, int resolution)
        {
            x = x / resolution;
            y = y / resolution;

            #region Check
            if (x >= Field.GetLength(0))
                throw new ArgumentOutOfRangeException("Координата Х выходит за пределы поля.");
            if (y >= Field.GetLength(1))
                throw new ArgumentOutOfRangeException("Координата Y выходит за пределы поля.");
            #endregion

            if (Field[x, y])
                Field[x, y] = false;
        }
    }
}
