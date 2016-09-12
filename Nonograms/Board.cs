using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Nonograms
{
    class Board
    {
        int[,] cells;
        public Board(int width, int height)
        {
            cells = new int[width,height];
        }
        public void Draw(int x, int y)
        {
            if (cells[y, x] == 1)
            {
                cells[y, x] = 0;
            }
            else
            {
                cells[y, x] = 1;
            }
        }
        public void ReDraw(Graphics Back, int Size_Box)
        {
            Back.Clear(Color.Empty);
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int f = 0; f < cells.GetLength(1); f++)
                {
                    if (cells[i, f] == 1)
                        Back.FillRectangle(new SolidBrush(Color.Black), f * Size_Box, i * Size_Box, Size_Box, Size_Box);
                    
                }
            }
        }
        public void Create_File(string path) //Запишем в файл рисунок
        {
            StreamWriter writer = new StreamWriter(@path); //Создаем стрим райтер

            writer.WriteLine("{0}_{1}", cells.GetLength(0), cells.GetLength(1)); //Первая строка зададим значения высоты и ширины
            for (int i = 0; i < cells.GetLength(0); i++) //Далее в цикле будем записывать элементы массива 
            {
                for (int f = 0; f < cells.GetLength(1); f++)
                {
                    writer.Write(cells[i, f]);
                }
                writer.WriteLine();
            }
            writer.Close(); // Закрываем стримрайтер
        }        
    }
}
