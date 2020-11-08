using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        LogicClass l = new LogicClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            l.LdBt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l.Spbt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(WindowsFormsApp1.Properties.Resources.Gun);
            sound.Play();
            l.ShootBt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            l.StAwayBt();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            l.StartAgainBt();
        }
    }
}
