using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Class;

namespace Laba1
{
    public partial class Form1 : Form
    {
        InfoForSave SavingInfo;     //Для сохранения информации в файл
        Form2 newMDIChild;          //Для формы рисунка
        SaveFileDialog saveFileDialog;      //Для вызова окна сохранения
        OpenFileDialog openFileDialog;
        string fileName;                    //название файла

        public Figures ChoosedFigure { get; set; }                   //Переменная перечисления выбора типа фигуры
        ToolStripMenuItem PastChoisedMenuStrip { get; set; }        //Прошлый выбор типа фигуры
        ToolStripButton PastChoiceButtonStrip { get; set; }
        public bool IsFigureFilling { get; set; }

        Color LineColor;
        Color BackgroundColor;
        float LineWidth;

        Size FormSize;      //Размер рисунка

        Point CursorPos {get; set; }

        //перечисление типов фигур
        public enum Figures
        {
            Rectangle,
            Ellipse,
            StraightLine,
            CurveLine
        }

        public Form1()
        {
            fileName = "";
            InitializeComponent();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();

            LineWidth = 1;                          //Начальная толщина линии
            LineColor = Color.Black;                //Начальный цвет линии
            BackgroundColor = Color.White;          //Начальный цвет фона

            PastChoisedMenuStrip = this.StraightLineMenuStrip;          //Начальное значение пункта меню
            PastChoiceButtonStrip = this.CreateStraightLineStripButton;     //Начальное значение выбора кнопки

            ChoosedFigure = Figures.StraightLine;
            PastChoisedMenuStrip.Checked = true;
            PastChoiceButtonStrip.Checked = true;

            IsFigureFilling = false;

            FormSize = new Size(800, 600);
        }
        //Эти функции лучше переписать через гетер сетер
        public Color getLineColor()
        {
            return LineColor;
        }

        public Color getBackgroundColor()
        {
            return BackgroundColor;
        }

        public float getLineWidth()
        {
            return LineWidth;
        }
        //Создание нового файла
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            newMDIChild = new Form2(FormSize)
            {
                
                // Set the Parent Form of the Child window.
                MdiParent = this,
                Text = "Рисунок " + this.MdiChildren.Length.ToString()
            };

            // Display the new form.
            newMDIChild.Show();
        }

        //Открытие файла из система
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Graphics Files (*.grf)|*.grf";         //Шаблоны расширения файлов

            openFileDialog.FileName = "";
            //Если есть результат выбора, то получить название файла
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {               
                fileName = openFileDialog.FileName;
            }
            else return;
            //Работа с потоком 
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            InfoForSave OpeningInfo = formatter.Deserialize(stream) as InfoForSave;
            //Настройка формы
            newMDIChild = new Form2(OpeningInfo.SizeOfForm);
            newMDIChild.SetFigure(OpeningInfo.ListOfFigures);
            stream.Close();

            newMDIChild.MdiParent = this;
            newMDIChild.Text = Path.GetFileNameWithoutExtension(fileName);
            newMDIChild.Show();          
        }
        //Сохранение файла
        public void SaveFile(bool IsRequired)
        {
            //Шаблон расширения и начальная директория
            saveFileDialog.Filter = "Graphics Files (*.grf)|*.grf";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            //Проверка, есть ли такой файл в системе и есть ли необходимость в принудительном переименовании
            if (!System.IO.File.Exists(fileName) || IsRequired)
            {
                openFileDialog.FileName = "";
                if (saveFileDialog.ShowDialog() == DialogResult.OK )
                {
                    fileName = saveFileDialog.FileName;
                }
                else return;
            }
            
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

                newMDIChild = this.ActiveMdiChild as Form2;

                SavingInfo = new InfoForSave();
                SavingInfo.ListOfFigures = newMDIChild.GetFigure();
                SavingInfo.SizeOfForm = newMDIChild.Size;               

                //formatter.Serialize(stream, newMDIChild.GetFigure());
                formatter.Serialize(stream, SavingInfo);
                stream.Close();

                ActiveMdiChild.Text = Path.GetFileNameWithoutExtension(fileName);
                newMDIChild.SetIsModification(false);
            }
        }
        //Сохранить
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveFile(false);
        }
        //Сохранить как..
        private void Save_AsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveFile(true);
        }
        //Смена доступа к кнопка сохранения
        public void ChangingState()
        {
            this.SaveToolStripMenuItem.Enabled = !this.SaveToolStripMenuItem.Enabled;
            this.Save_AsToolStripMenuItem.Enabled = !this.Save_AsToolStripMenuItem.Enabled;
        }
        //Выбор толщины линии
        private void LineWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogForm myDialog = new DialogForm();
            myDialog.ShowDialog(this);
            LineWidth = myDialog.getwidth();
            StatusBar.Refresh();
        }
        //Выбор цвета линии
        private void LineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineColor = ChoosingColor(LineColor);
            StatusBar.Refresh();
        }
        //Выбор цвета фона
        private void BackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundColor = ChoosingColor(BackgroundColor);
            StatusBar.Refresh();
        }
        //Выбор цвета
        private Color ChoosingColor(Color color)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = color;
            //Если выбрали ОК то вернуть выбранный цвет
            if (colorDialog.ShowDialog() == DialogResult.OK)
                return colorDialog.Color;
            //Если выбрано Отмена, то вернуть предыдущий цвет
            else
            {
                return color;
            }

        }
        //Размер изображения
        private void ImageSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызываем форму и получаем размер рисунка
            DialogForm_Size dialogForm_Size = new DialogForm_Size();
            dialogForm_Size.ShowDialog();
            
            FormSize = dialogForm_Size.GetSize();
        }
        //Возвращение размера формы
        public Size GetFormSize()
        {
            return FormSize;
        }
        //Флаг Заливки
        private void FillMenuStrip_Click(object sender, EventArgs e)
        {
            //Если хотя бы одна из опций заливки нажата то включить режим
            if (FillMenuStrip.Checked || FillStripButton.Checked)
                IsFigureFilling = true;
            else IsFigureFilling = false;
        }
        //Смена режима фигур
        private void ChoosingFigure()
        {             
            
            PastChoisedMenuStrip.Checked = false;       //Сбрасываем предыдущий выбор
            PastChoiceButtonStrip.Checked = false;
            if (this.RectangleMenuStrip.Checked || this.CreateRectangleStripButton.Checked)
            {
                ChoosedFigure = Figures.Rectangle;
                PastChoisedMenuStrip = RectangleMenuStrip;
                PastChoiceButtonStrip = CreateRectangleStripButton;
            }
            else if (this.EllipseMenuStrip.Checked || this.CreateEllipseStripButton.Checked)
            {
                ChoosedFigure = Figures.Ellipse;
                PastChoisedMenuStrip = EllipseMenuStrip;
                PastChoiceButtonStrip = CreateEllipseStripButton;
            }
            else if (this.StraightLineMenuStrip.Checked || this.CreateStraightLineStripButton.Checked)
            {
                ChoosedFigure = Figures.StraightLine;
                PastChoisedMenuStrip = StraightLineMenuStrip;
                PastChoiceButtonStrip = CreateStraightLineStripButton;
            }
            else if (this.CurveLineMenuStrip.Checked || this.CreateCurveLineStripButton.Checked)
            {
                ChoosedFigure = Figures.CurveLine;
                PastChoisedMenuStrip = CurveLineMenuStrip;
                PastChoiceButtonStrip = CreateCurveLineStripButton;
            }            
            
        }
        //Выбор прямой линии
        private void StraightLineMenuStrip_Click(object sender, EventArgs e)
        {
            ChoosingFigure();
        }
        //Выбор кривой линии
        private void CurveLineMenuStrip_Click(object sender, EventArgs e)
        {
            ChoosingFigure();
        }
        //Выбор прямоугольника
        private void RectangleMenuStrip_Click(object sender, EventArgs e)
        {
            ChoosingFigure();
        }
        // Выбор элипса
        private void EllipseMenuStrip_Click(object sender, EventArgs e)
        {
            ChoosingFigure();
        }
        //При перерисовке в StatusBar
        private void StatusBar_DrawItem(object sender, StatusBarDrawItemEventArgs sbdevent)
        {
            Graphics G = StatusBar.CreateGraphics();        //Объект для рисования прямоугольников в строке состояния
            //Подписи для обозначения выбранных цветов
            G.DrawString("Цвет 1:", new Font(this.Font, FontStyle.Regular),
                new SolidBrush(Color.Black), statusBarPanelCursor.Width + 5, 7);
            G.DrawString("Цвет 2:", new Font(this.Font, FontStyle.Regular),
             new SolidBrush(Color.Black), statusBarPanelCursor.Width + 5 + statusBarPanelColor1.Width, 7);

            int range = 50; //Перемення для расположения прямоугольников
            //Рисование индикаторов цвета
            G.FillRectangle(new SolidBrush(LineColor), Rectangle.FromLTRB(StatusBar.Panels[0].Width + range, 2,
                StatusBar.Panels[0].Width + range + 20, 22));
            G.DrawRectangle(new Pen(Color.Black, 1), Rectangle.FromLTRB(StatusBar.Panels[0].Width + range, 2,
                StatusBar.Panels[0].Width + range + 20, 22));

            G.FillRectangle(new SolidBrush(BackgroundColor), 
                Rectangle.FromLTRB(StatusBar.Panels[0].Width + StatusBar.Panels[1].Width + range, 2,
                StatusBar.Panels[0].Width + StatusBar.Panels[1].Width + range + 20, 22));
            G.DrawRectangle(new Pen(Color.Black, 1), 
                Rectangle.FromLTRB(StatusBar.Panels[0].Width + StatusBar.Panels[1].Width + range, 2,
                StatusBar.Panels[0].Width + StatusBar.Panels[1].Width + range + 20, 22));
            //вывод толщины линии
            statusBarPanelWidth.Text = LineWidth.ToString();
        }

        public StatusBar GetStatusBar()
        {
            return StatusBar;
        }


    }
}
