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
        DialogResult result;
        object[] ValuesOfWidth;
        static int width;
        public DialogForm()
        {
            InitializeComponent();
            ValuesOfWidth = new object[] { 1, 3, 5, 8, 10, 12, 15 };
            LineBox.Items.AddRange(ValuesOfWidth);
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(LineBox.Text != null)
            {
                width = Convert.ToInt32(LineBox.Text);
            }
            this.Close();
        }

        private void LineBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public int getwidth()
        {
            return width;
        }

    }
}
