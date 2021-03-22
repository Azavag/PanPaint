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
        List<Figure> figures = new List<Figure>();
        Rect rectangle;
        Graphics g;
        static Form1 main;
        bool isModification;    //флаг модификации файла
        bool isFirst;           //Флаг открытия формы
        bool isMouseDown;
        
        public Form2()
        {
            InitializeComponent();
            isModification = false;
            isMouseDown = false;
            isFirst = false;
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
        public void setIsModification(bool flag)
        {
            isModification = flag;
        }
        //Обработчик события активации формы
        private void Form2_Activated(object sender, EventArgs e)
        {
            g = CreateGraphics();
            // Определяем родительскую форму
            main = this.MdiParent as Form1;
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
           
            if (e.Button == MouseButtons.Left && isMouseDown == false)
            {
                isMouseDown = true;
                isModification = true;
                rectangle = new Rect(e.Location, e.Location, main.getLineColor(),main.getBackgroundColor(), main.getLineWidth());
                Invalidate();

            }
        }
        //При движении мыши по файлу
        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {

            if (isMouseDown)
            {
                //Рисование контура прямоугольника
                rectangle.Hide(g);
                rectangle.MouseMove(e.Location);
                rectangle.DrawDash(g);
            }
        }
        //При отпускании мыши
        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {             
                //Рисование кончательного контура прямоугольника
                rectangle.Draw(g);
                figures.Add(rectangle);     //Добавление в список
                isMouseDown = false;
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(g);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (main.MdiChildren.Length == 1)
            {
                main.ChangingState();
            }

            if (isModification)
            {
                DialogResult ChoiceResult = MessageBox.Show("Вы хотите сохранить изменения в файле?","GraF", MessageBoxButtons.YesNoCancel);
                switch(ChoiceResult)
                {
                    case DialogResult.Yes:
                        main.SaveFile(false);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        main.ChangingState();
                        break;                       
                }
            }

            
        }      
    }
}
