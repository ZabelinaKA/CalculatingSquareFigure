using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GzLibApp
{
    public partial class Fz44orfz223 : Form
    {
        public Fz44orfz223()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fz44 Fz44 = new fz44();
            Fz44.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fz223 Fz223 = new fz223();
            Fz223.Show();
        }
    }
}
