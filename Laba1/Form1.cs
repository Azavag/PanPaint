using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
           
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            if( e.Button == MouseButtons.Left)
            {
                string s ="X= " + e.X.ToString() + "; Y= " + e.Y.ToString();
                g.DrawString(s, new Font("Times New Roman", 8), new SolidBrush(Color.Black), new Point(e.X, e.Y));
              
            }
            if(e.Button == MouseButtons.Right)
            {
                string A = "Нажата правая кнопка мыши";
                MessageBox.Show(A, "Предупреждение");
                g.Clear(Color.White);
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form2();
            f.MdiParent = this;
            f.Text = "Рисунок " + this.MdiChildren.Length.ToString();
            f.Show();
        }
    }
}
