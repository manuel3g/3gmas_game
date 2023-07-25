using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Juego
{
    public partial class Form1 : Form
    {
        private int x = 0;
        private int y = 0;
        public int v = 0;
        public int l = 3;
        public Form1()
        {
            InitializeComponent();
            vita.Text = "VIDAS: " + l;
            burn.Visible = false;
        }

        WindowsMediaPlayer sonido = new WMPLib.WindowsMediaPlayer();
        puntaje open = new puntaje();

        private void Form1_Load(object sender, EventArgs e)
        {
            //WindowsMediaPlayer1.URL = Application.StartupPath + (@"musica.mp3");
            //WindowsMediaPlayer1.Ctlcontrols.play()
            sonido.URL = @"musica.mp3";
            sonido.controls.play();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ayuda.Visible = false;
                burn.Visible = false;
            }

            //------------------------------DERECHA-----------------------------------------
            if (e.KeyCode == Keys.Right){
                sprite.Image = Image.FromFile(@"derecha.png");
                lblDireccion.Text = "Derecha";

                //LAVA
                if (x == 120 && y == 360)
                {
                    if (l == 0) {
                        open.Show();
                        open.puntajes.Text = "Gemas recolectadas " + v + "/3";
                        open.lblDie.Visible = true;
                        switch (v)
                        {
                            case 0: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                            case 1: open.pbPuntos.Image = Image.FromFile(@"1.png"); break;
                            case 2: open.pbPuntos.Image = Image.FromFile(@"2.png"); break;
                            case 3: open.pbPuntos.Image = Image.FromFile(@"3.png"); break;
                            default: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                        }
                    }
                    else{
                        l--;
                        vita.Text = "VIDAS: " + l;
                        burn.Visible = true;
                        sprite.Location = new Point(x -= 60, y);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }

                //Vidas
                if (vida.Visible == true)
                {
                    if (x==60 && y==120)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida.Visible = false;
                    }
                    
                }
                //********** Vida 2 **************
                if (vida2.Visible == true)
                {
                    if (x == 360 && y == 300)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida2.Visible = false;
                    }
                }
                //********** Vida 3 **************
                if (vida3.Visible == true)
                {
                    if (x == 120 && y == 600)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida3.Visible = false;
                    }
                }

                //colisiones
                if (x == 360 && y == 240 || x==240 && y==0 || x == 60 && y == 600 || x == 180 && y == 600) { }
                else{
                    if (x <= 540)
                    {

                        sprite.Location = new Point(x += 60, y);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }
            }else

            //-----------------------------IZQUIERDA----------------------------------------
            if (e.KeyCode == Keys.Left){
                sprite.Image = Image.FromFile(@"izquierda.png");
                lblDireccion.Text = "Izquierda";

                //LAVA
                if (x == 300 && y == 360)
                {
                    if (l == 0)
                    {
                        open.Show();
                        open.puntajes.Text = "Gemas recolectadas " + v + "/3";
                        open.lblDie.Visible = true;
                        switch (v)
                        {
                            case 0: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                            case 1: open.pbPuntos.Image = Image.FromFile(@"1.png"); break;
                            case 2: open.pbPuntos.Image = Image.FromFile(@"2.png"); break;
                            case 3: open.pbPuntos.Image = Image.FromFile(@"3.png"); break;
                            default: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                        }
                    }
                    else
                    {
                        l--;
                        vita.Text = "VIDAS: " + l;
                        burn.Visible = true;
                        sprite.Location = new Point(x += 60, y);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }

                //vidas
                if (vida.Visible == true)
                {
                    if (x == 180 && y == 120)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida.Visible = false;
                    } 
                }
                //********** Vida 2 **************
                if (vida2.Visible == true)
                {
                    if (x == 480 && y == 300)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida2.Visible = false;
                    }
                }
                //********** Vida 3 **************
                if (vida3.Visible == true)
                {
                    if (x == 240 && y == 600)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida3.Visible = false;
                    }
                }


                //colisiones
                if (x == 480 && y == 240 || x == 360 && y == 0 || x == 180 && y == 600 || x == 300 && y == 600) { }
                else
                {
                    if (x >= 60)
                    {
                        sprite.Location = new Point(x -= 60, y);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }
            }else

            //----------------------------------ARRIBA------------------------------------
            if (e.KeyCode == Keys.Up){
                sprite.Image = Image.FromFile(@"arriba.png");
                lblDireccion.Text = "Arriba";

                if (x == 180 && y == 420)
                {
                    if (l == 0)
                    {
                        open.Show();
                        open.puntajes.Text = "Gemas recolectadas " + v + "/3";
                        open.lblDie.Visible = true;
                        switch (v)
                        {
                            case 0: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                            case 1: open.pbPuntos.Image = Image.FromFile(@"1.png"); break;
                            case 2: open.pbPuntos.Image = Image.FromFile(@"2.png"); break;
                            case 3: open.pbPuntos.Image = Image.FromFile(@"3.png"); break;
                            default: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                        }
                    }
                    else
                    {
                        l--;
                        vita.Text = "VIDAS: " + l;
                        burn.Visible = true;
                        sprite.Location = new Point(x, y += 60);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }

                if (x == 240 && y == 420)
                {
                    if (l == 0)
                    {
                        open.Show();
                        open.puntajes.Text = "Gemas recolectadas " + v + "/3";
                        open.lblDie.Visible = true;
                        switch (v)
                        {
                            case 0: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                            case 1: open.pbPuntos.Image = Image.FromFile(@"1.png"); break;
                            case 2: open.pbPuntos.Image = Image.FromFile(@"2.png"); break;
                            case 3: open.pbPuntos.Image = Image.FromFile(@"3.png"); break;
                            default: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                        }
                    }
                    else
                    {
                        l--;
                        vita.Text = "VIDAS: " + l;
                        burn.Visible = true;
                        sprite.Location = new Point(x, y += 60);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }

                //**************************PUNTOS***************************************
                if (x == 300 && y == 60) {
                    
                    open.Show();
                    open.win.Visible = true;
                    open.puntajes.Text = "Gemas recolectadas " + v + "/3";
                    switch (v)
                    {
                        case 0: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                        case 1: open.pbPuntos.Image = Image.FromFile(@"1.png"); break;
                        case 2: open.pbPuntos.Image = Image.FromFile(@"2.png"); break;
                        case 3: open.pbPuntos.Image = Image.FromFile(@"3.png"); break;
                        default: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                    }
                }

                //vidas
                if (vida.Visible == true)
                {
                    if (x == 120 && y == 180)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida.Visible = false;
                    }
                }
                //********** Vida 2 **************
                if (vida2.Visible == true)
                {
                    if (x == 420 && y == 360)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida2.Visible = false;
                    }
                }

                //colisiones
                if (x == 420 && y == 300) { }
                else
                {
                    if (y >= 60)
                    {
                        sprite.Location = new Point(x, y -= 60);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }
            }else

            //---------------------------------ABAJO-------------------------------------
            if (e.KeyCode == Keys.Down){
                sprite.Image = Image.FromFile(@"abajo.png");
                lblDireccion.Text = "Abajo";

                //LAVA
                if (x == 180 && y == 300)
                {
                    if (l == 0)
                    {
                        open.Show();
                        open.puntajes.Text = "Gemas recolectadas " + v + "/3";
                        open.lblDie.Visible = true;
                        switch (v)
                        {
                            case 0: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                            case 1: open.pbPuntos.Image = Image.FromFile(@"1.png"); break;
                            case 2: open.pbPuntos.Image = Image.FromFile(@"2.png"); break;
                            case 3: open.pbPuntos.Image = Image.FromFile(@"3.png"); break;
                            default: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                        }
                    }
                    else
                    {
                        l--;
                        vita.Text = "VIDAS: " + l;
                        burn.Visible = true;
                        sprite.Location = new Point(x, y -= 60);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }

                if (x == 240 && y == 300)
                {
                    if (l == 0)
                    {
                        open.Show();
                        open.puntajes.Text = "Gemas recolectadas " + v + "/3";
                        open.lblDie.Visible = true;
                        switch (v)
                        {
                            case 0: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                            case 1: open.pbPuntos.Image = Image.FromFile(@"1.png"); break;
                            case 2: open.pbPuntos.Image = Image.FromFile(@"2.png"); break;
                            case 3: open.pbPuntos.Image = Image.FromFile(@"3.png"); break;
                            default: open.pbPuntos.Image = Image.FromFile(@"0.png"); break;
                        }
                    }
                    else
                    {
                        l--;
                        vita.Text = "VIDAS: " + l;
                        burn.Visible = true;
                        sprite.Location = new Point(x, y -= 60);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }


                //vidas
                if (vida.Visible == true)
                {
                    if (x == 120 && y == 60)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida.Visible = false;
                    }
                }
                //********** Vida 2 **************
                if (vida2.Visible == true)
                {
                    if (x == 420 && y == 240)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida2.Visible = false;
                    }
                }
                //********** Vida 3 **************
                if (vida3.Visible == true)
                {
                    if (x == 180 && y == 540)
                    {
                        v++;
                        sprite.Image = Image.FromFile(@"point.png");
                        lblVidas.Text = "Gemas: " + v;
                        vida3.Visible = false;
                    }
                }

                //colisiones
                if (x == 420 && y == 180 || x == 240 && y == 540 || x == 120 && y == 540) { }
                else
                {
                    if (y <= 540)
                    {
                        sprite.Location = new Point(x, y += 60);
                        lblCoordenada.Text = "(" + x.ToString() + "," + y.ToString() + ")";
                    }
                }
            }
        }
        

        private void lblCoordenada_Click(object sender, EventArgs e)
        {
            Close();
        }


        /*
        private void IsVida()
        {
            if (sprite.Location.X == 120 && sprite.Location.Y == 120)
            {
                v++;
                sprite.Image = Image.FromFile(@"point.png");
                lblVidas.Text = "VIDAS: " + v;
                vida.Visible = false;
            }
        }

        private void isBlock()
        {
            if(sprite.Location.X==420 && sprite.Location.Y == 240)
            {
                MessageBox.Show("colision");
            }
        }*/
    }
}
