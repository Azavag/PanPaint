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
    public partial class DialogForm_Size : Form
    {
        static public Size size;        //Размер рисунка
        public DialogForm_Size()
        {
            InitializeComponent();          
        }
        //При нажатии кнопки ОК
        private void Ok_Button_Click(object sender, EventArgs e)
        {
            //Проверка на то какой из вариантов выбран
            if (Small_Size_Button.Checked == true)
                size = new Size(320, 240);
            else if (Mid_Size_Button.Checked == true)
                size = new Size(640, 480);
            else if (Large_Size_Button.Checked == true)
                size = new Size(800, 600);

            else if (OtherSize.Checked)
                size = new Size(Convert.ToInt32(this.WidthText.Text), Convert.ToInt32(this.HeightText.Text));

            Close();
        }
        //При нажатии кнопки отмены
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Вернуть результат выбора размера формы
        public Size GetSize()
        {
            return size;
        }       
        //При установлении флага произвольного размера рисунка
        private void OtherSize_CheckedChanged(object sender, EventArgs e)
        {
            this.ChangeVisible();
        }
        //Смена доступа к кнопкам выбора размеры
        private void ChangeVisible()
        {
            this.Small_Size_Button.Enabled = !this.Small_Size_Button.Enabled;
            this.Mid_Size_Button.Enabled = !this.Mid_Size_Button.Enabled;
            this.Large_Size_Button.Enabled = !this.Large_Size_Button.Enabled;

            this.Small_Size_Button.Checked = false;
            this.Mid_Size_Button.Checked = false;
            this.Large_Size_Button.Checked = false;

            this.WidthText.Enabled = !this.WidthText.Enabled;
            this.WidthLabel.Enabled = !this.WidthLabel.Enabled;
            this.HeightText.Enabled = !this.HeightText.Enabled;
            this.HeightLabel.Enabled = !this.HeightLabel.Enabled;
        }       
    }
}
