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
        Form2 newMDIChild;
        SaveFileDialog saveFileDialog;
        OpenFileDialog openFileDialog;
        string fileName;

        Color LineColor;
        Color BackgroundColor;
        float LineWidth;

        public Form1()
        {
            fileName = "";
            InitializeComponent();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();

            LineWidth = 1;
            LineColor = Color.Black;
            BackgroundColor = Color.White;
        }


        /*private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
        }*/
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
            newMDIChild = new Form2();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            newMDIChild.Text = "Рисунок " + this.MdiChildren.Length.ToString();
            // Display the new form.
            newMDIChild.Show();

        }

        //Открытие файла из система
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Graphics Files (*.grf)|*.grf";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
            }
            else return;
                
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            List<Figure> DrawingFigures = formatter.Deserialize(stream) as List<Figure>;

            newMDIChild = new Form2();
            newMDIChild.SetFigure(DrawingFigures);
            newMDIChild.MdiParent = this;
            newMDIChild.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            newMDIChild.Show();

            stream.Close();
        }
        //Сохранение файла
        public void SaveFile(bool IsRequired)
        {
            saveFileDialog.Filter = "Graphics Files (*.grf)|*.grf";
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (saveFileDialog.ShowDialog() == DialogResult.OK && (fileName == "" || IsRequired))
            {
                fileName = saveFileDialog.FileName;
            }
            else return;
            
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

                newMDIChild = this.ActiveMdiChild as Form2;
                formatter.Serialize(stream, newMDIChild.GetFigure());
                stream.Close();

                ActiveMdiChild.Text = Path.GetFileNameWithoutExtension(fileName);
                newMDIChild.setIsModification(false);
                fileName = "";
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveFile(false);
        }

        //Сохранить как..
        private void Save_AsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SaveFile(true);

            /*saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Filter = "Image Files (*.bmp, *.jpg, *png)|*.bmp;*.jpg;*.png";

            saveFileDialog.ShowDialog();
            fileName = saveFileDialog.FileName;

            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);

            Form2 saveList = this.ActiveMdiChild as Form2;
            formatter.Serialize(stream, saveList.GetFigure());
            stream.Close();

            ActiveMdiChild.Text = Path.GetFileNameWithoutExtension(fileName);*/
        }
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
        }
        //Выбор цвета линии
        private void LineColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineColor = ChoosingColor(LineColor);
        }
        //Выбор цвета фона
        private void BackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundColor = ChoosingColor(BackgroundColor);
        }
        //Выбор фона
        private Color ChoosingColor(Color color)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = color;
            if (colorDialog.ShowDialog() == DialogResult.OK)           
                return colorDialog.Color;
            else
            {
                return color;
            }
                
        }
    }
}
