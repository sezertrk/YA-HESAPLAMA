using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = int.Parse(textBox1.Text);
            int d = int.Parse(textBox2.Text);
            int son = 0;
            son = s - d;
            if (son > 17) ;
            {
                MessageBox .Show ("Gözünüz Toprakta" + son.ToString ()); 
            }
            else (son < 17);
            {
                MessageBox .Show ("Daha Gençsin" + son.ToString ());
        }
    }
    }
}
