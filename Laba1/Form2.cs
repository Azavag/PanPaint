using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Point = System.Drawing.Point;
using Class;
using Rect = Class.Rect;

namespace Laba1
{
    public partial class Form2 : Form
    {
        Form1.Figures Figure;           //Переменная для хранения типа фигуры
        List<Figure> figures = new List<Figure>();      //Список фигур

        Figure MainFigure;              //Переменная для инициализации любого типа фигур

        public bool FillingFigure { get; set; }

        Graphics g;
        static Form1 main;      //Родительская форма

        bool isModification;    //флаг модификации файла
        bool isFirst;           //Флаг открытия формы
        bool isMouseDown;

        BufferedGraphics BuffGrapics;

        public Point CursorPos { get; set; }
        //Конструктор
        public Form2(System.Drawing.Size FormSize)
        {
            InitializeComponent();
            //Создаём форму с нужным размером
            this.Size = FormSize;      
            //Флаги состояния
            isModification = false;
            isMouseDown = false;
            isFirst = false;
            //Скроллинг
            this.AutoScroll = true;
            this.AutoScrollMinSize = FormSize;
        }
        //
        private void Form2_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            //Устанавливаем максимальный размер буферной зоны
            BufferedGraphicsManager.Current.MaximumBuffer = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            
            BuffGrapics = BufferedGraphicsManager.Current.Allocate(g, new Rectangle(0, 0, 
                SystemInformation.PrimaryMonitorMaximizedWindowSize.Width, 
                SystemInformation.PrimaryMonitorMaximizedWindowSize.Height));

            BuffGrapics.Graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, Size.Width, Size.Height);
            BuffGrapics.Render();

        }
        //Возвращение размеры рисунка
        public System.Drawing.Size GetSize()
        {
            return this.Size;
        }
        //Возвращение списка фигур
        public List<Figure> GetFigure()
        {
            return figures;
        }
        //Установка списка фигур
        public void SetFigure(List<Figure> list)
        {
            figures = list;
        }

        //Установка флага модификации файла
        public void SetIsModification(bool flag)
        {
            isModification = flag;
        }
        //Обработчик события активации формы
        private void Form2_Activated(object sender, EventArgs e)
        {         
            main = this.MdiParent as Form1;             // Определяем родительскую форму
            //В строке состояние записываем размер окна
            main.GetStatusBar().Panels[4].Text = this.Width.ToString() + " x " + this.Height.ToString();
            //Делаем проверку для разблокировки кнопки "Сохранить"
            if (main != null && isFirst== false && main.MdiChildren.Length == 1)
            {
                main.ChangingState();
                isFirst = true;

            }            
        }
        //При нажатии кнопки мыши
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            FillingFigure = main.IsFigureFilling;       //Определяем состояние флага заливки
            Figure = main.ChoosedFigure;                //Определеяем выбранный тип фигуры
            if (e.Button == MouseButtons.Left && isMouseDown == false)
            {
                isMouseDown = true;
                isModification = true;
                switch (Figure)
                {
                    case Form1.Figures.Rectangle:
                        MainFigure = new Rect(e.Location, e.Location, main.getLineColor(), main.getBackgroundColor(), main.getLineWidth());
                        break;
                    case Form1.Figures.Ellipse:
                        MainFigure = new Ellipse(e.Location, e.Location, main.getLineColor(), main.getBackgroundColor(), main.getLineWidth());
                        break;
                    case Form1.Figures.StraightLine:
                        MainFigure = new StraightLine(e.Location, e.Location, main.getLineColor(), main.getBackgroundColor(), main.getLineWidth());
                        break;
                    case Form1.Figures.CurveLine:
                        MainFigure = new CurveLine(e.Location, e.Location, main.getLineColor(), main.getBackgroundColor(), main.getLineWidth());
                        break;
                }
                MainFigure.IsFilling = FillingFigure;
                Invalidate();

            }
        }
        //При движении мыши по файлу
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            //Можно сделать проверку на выход за пределы границ формы
            //В строке состояние записываем расположение курсора
            main.GetStatusBar().Panels[0].Text = (e.Location.X - AutoScrollPosition.X) + ", " + (e.Location.Y - AutoScrollPosition.Y) + "пкс";

            if (!isMouseDown)
            {
                return;
            }
            //Рисование контура прямоугольника
            BuffGrapics.Render(g);
            MainFigure.MouseMove(e.Location);
            MainFigure.DrawDash(g, AutoScrollPosition);

            
        }
        //При отпускании мыши
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {

            if (!isMouseDown)
            {
                return;
            }
            //Проверка на то, помещается ли фигура в область рисования
            if (MainFigure.endPoint.X <= Size.Width-AutoScrollPosition.X && MainFigure.endPoint.Y <= Size.Height
                && MainFigure.endPoint.X >= 0 && MainFigure.endPoint.Y >= 0
                && MainFigure.startPoint.X > 0 && MainFigure.startPoint.Y > 0)
            {
                //Рисование кончательного контура прямоугольника
                MainFigure.Draw(BuffGrapics.Graphics, AutoScrollPosition);
                figures.Add(MainFigure);                     //Добавление в список
            }
            BuffGrapics.Render();
            isMouseDown = false;

        }
        //При перерисовке формы
        private void Form2_Paint(object sender, PaintEventArgs e)
        {           
            BuffGrapics.Graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, this.Width, this.Height);
            //Перерисовка фигур           
            foreach (Figure MainFigure in figures)
            {
                MainFigure.Draw(BuffGrapics.Graphics, AutoScrollPosition);
            }   
            BuffGrapics.Render(e.Graphics);
        }
        //при закрытии формы
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Если закрывается последняя форма, то блокируем кнопки
            if (main.MdiChildren.Length == 1)
            {
                main.ChangingState();
                main.GetStatusBar().Panels[4].Text = "Размер изображения";

            }
            //Если были изменения в файле
            if (isModification)
            {   
                //Вызов диалогового окна
                DialogResult ChoiceResult = MessageBox.Show("Вы хотите сохранить изменения в файле?","GraF", MessageBoxButtons.YesNoCancel);
                //Реакция на выбор пользователя
                switch (ChoiceResult)
                {
                    case DialogResult.Yes:
                        main.SaveFile(false);       //Сохранения файла
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        main.ChangingState();       //Разблокировать кнопки
                        break;                       
                }
            }
           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Освобождение ресурсов
            BuffGrapics.Dispose();
        }
    }
}
