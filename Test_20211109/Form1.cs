using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Ucet ucet;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            ucet = new Ucet("Vítek", 30000);
            label3_jmeno.Text = ucet.jmeno.ToString();
            label3_stavPenez.Text = ucet.stavPenez.ToString();
            
        }

        private void button1_vlozit_Click(object sender, EventArgs e)
        {
            int vlozit = int.Parse(textBox1.Text);
            ucet.Vlozit(vlozit);
            label3_stavPenez.Text = ucet.stavPenez.ToString();

        }

        private void button1_vybrat_Click(object sender, EventArgs e)
        {
            int vyber = int.Parse(textBox1.Text);
            ucet.Vyber(vyber);
            label3_stavPenez.Text = ucet.stavPenez.ToString();
        }

        private void button_platba_Click(object sender, EventArgs e)
        {
            int platba = int.Parse(textBox2.Text);
            ucet.Platba(platba);
            label3_stavPenez.Text = ucet.stavPenez.ToString();
        }
    }
}
