using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labtime.Text = DateTime.Now.ToString("H : MM : ss");
        }

        private void Alarm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
