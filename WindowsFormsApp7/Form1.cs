using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeForm();
        }
        void ChangeForm()
        {
            string color = textBox1.Text;
            BackColor = Color.FromName(color);
            string title = textBox2.Text;
            Text = (title);

            string width = textBox3.Text;
            this.Width = Convert.ToInt32(width); ;

            string height = textBox4.Text;
            this.Height = Convert.ToInt32(height);
        }
    }
}
