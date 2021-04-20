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
    public partial class DialogForm : Form
    {
        object[] ValuesOfWidth;
        static int width;       //Поле значения толщины линии
        public DialogForm()
        {
            InitializeComponent();
            //Добавялем в LinaBox заданные значения
            ValuesOfWidth = new object[] { 1, 3, 5, 8, 10, 12, 15 };
            LineBox.Items.AddRange(ValuesOfWidth);
            
        }
        //При нажатии кнопки отмены
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();   //Закрытие формы
        }
        //При нажатии кнопки ОК
        private void OkButton_Click(object sender, EventArgs e)
        {
            //Записать выбор толщины из LineBox
            if(LineBox.Text != null)
            {
                width = Convert.ToInt32(LineBox.Text);
            }
            this.Close();
        }
        //Возвращение толщины
        public int getwidth()
        {
            return width;
        }

    }
}
