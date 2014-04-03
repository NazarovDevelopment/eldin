using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Electrodynamics
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void potentialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManager.Instance.CreateElectroStat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowManager.Instance.CreateElectroStat();
        }

   



    }
}