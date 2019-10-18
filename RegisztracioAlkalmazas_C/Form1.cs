using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox.Items.Add("Úszás");
            listBox.Items.Add("Horgászat");
            listBox.Items.Add("Futás");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Trim().Equals(""))
            {
                listBox.Items.Add(textBox1.Text);
                listBox.Text = "";
            }
        }
    }
}
