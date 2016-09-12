using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonograms
{
    public partial class VisualBoard : Form
    {
        int Size_Box = 25, Nano_Width=5, Nano_Height=5; //Размер 1 клеточки, кол-во клеток в ширину, кол-во клеток в высоту
        Graphics Back; // для отрисовки фона
        Graphics Front; // для отрисовки переднего плана
        Board Nono_Board; //Объект доски
        string path = @"D:\Dropbox\Курсовая\Nonograms\Nonograms\bin\Debug\Image.txt"; //Стандартный путь где создавать файл

        public VisualBoard()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            Initialize(); // Инициализируем отрисовку
            Nono_Board = new Board(Nano_Height, Nano_Width); //Новая доска
            Back.Clear(Color.Empty); //Очищаем передний и задний планы
            Front.Clear(Color.Empty);
            Draw_Board(); //Рисуем доску
        }

        void Initialize ()
        {
            Nanogram_Board.Height = Nano_Height * Size_Box + 1;
            Nanogram_Board.Width = Nano_Width * Size_Box + 1;
            Bitmap bBack = new Bitmap(Nano_Width * Size_Box + 1, Nano_Height * Size_Box + 1);   // создаем битмап для рисования на заднем плане на 16 ячеек размера Size
            Bitmap bFront = new Bitmap(Nano_Width * Size_Box + 1, Nano_Height * Size_Box + 1);         
            Back = Graphics.FromImage(bBack);
            Front = Graphics.FromImage(bFront);
            Nanogram_Board.BackgroundImage = bBack;
            Nanogram_Board.Image = bFront;            
            Nanogram_Board.Refresh();
        } // СМ. НоНОграм
        void Draw_Board()
        {
            Pen blackPen = new Pen(Color.Black, 1); //Создаем кисть которой рисовать будем (Цвет, толщина)
            for (int i = 0; i <= Nano_Width; i++)
            {
                Front.DrawLine(blackPen, i * Size_Box, 0, i * Size_Box, Nano_Height * Size_Box);
            }
            for(int f = 0; f <= Nano_Height; f++)
            {
                Front.DrawLine(blackPen, 0, f * Size_Box, Nano_Width * Size_Box, f * Size_Box); 
            }
            
            Nanogram_Board.Refresh(); // Обновляем рисунок в Пикчербоксе
        }
        
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int X = Cursor.Position.X - this.DesktopLocation.X - Nanogram_Board.Location.X - 8;  // Вычисляем позицию куда кликнули мышкой
            int Y = Cursor.Position.Y - this.DesktopLocation.Y - Nanogram_Board.Location.Y - 30;
            int X1 = X / Size_Box, Y1 = Y / Size_Box;   //Определяем в какой квадратик мы попали курсором

            if (e.Button == MouseButtons.Left) //Если нажали левой кнопкой мыши 
            { 
                Nono_Board.Draw(X1, Y1); //Добавляем в массив текущую ячейку
                Nono_Board.ReDraw(Back, Size_Box); // перерисовываем пользовательский слой
                Nanogram_Board.Refresh(); 
            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Nono_Board.Create_File(path); //Создаем файл
        }

        private void Change_Click(object sender, EventArgs e) //изменить размеры полей
        {
            if (width.Text != "Ширина" && height.Text != "Высота") //Если стандартные значения были изменены, то попробуем изменить
            {
                Nano_Width = Convert.ToInt16(width.Text);

                Nano_Height = Convert.ToInt16(height.Text);
                Init();
            }
        }

        private void Choose_Click(object sender, EventArgs e) // Диалоговое окно выбора файла
        {
            OpenFileDialog OFD = new OpenFileDialog(); //Инициализируем диалоговое окно
            OFD.InitialDirectory = "c:\\"; //Начальная дериктория диалог. окна
            OFD.Filter = "txt files (*.txt)|*.txt"; //Фильтр (какие файлы мы отобрааем в диалоговом окне)
            OFD.RestoreDirectory = true;
            if (OFD.ShowDialog() == DialogResult.OK) //Если мы выбрали файл и нажали ОК, то ПУТЬ=Путь к файлу
            {
                path = OFD.FileName;
            }
        }                
    }
}
