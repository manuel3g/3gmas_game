using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class puntaje : Form
    {
        public puntaje()
        {
            InitializeComponent();
            lblDie.Visible = false;
            win.Visible = false;
        }
       
        private void label2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void puntaje_Load(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }
    }
}
