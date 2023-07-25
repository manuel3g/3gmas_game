namespace Juego
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCoordenada = new System.Windows.Forms.Label();
            this.vida = new System.Windows.Forms.PictureBox();
            this.sprite = new System.Windows.Forms.PictureBox();
            this.lblVidas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.vida2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vida3 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lava = new System.Windows.Forms.PictureBox();
            this.vita = new System.Windows.Forms.Label();
            this.ayuda = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.burn = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).BeginInit();
            this.ayuda.SuspendLayout();
            this.burn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoordenada
            // 
            this.lblCoordenada.AutoSize = true;
            this.lblCoordenada.BackColor = System.Drawing.Color.Transparent;
            this.lblCoordenada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCoordenada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCoordenada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenada.Location = new System.Drawing.Point(393, 9);
            this.lblCoordenada.Margin = new System.Windows.Forms.Padding(0);
            this.lblCoordenada.Name = "lblCoordenada";
            this.lblCoordenada.Size = new System.Drawing.Size(38, 16);
            this.lblCoordenada.TabIndex = 1;
            this.lblCoordenada.Text = "(0,0)";
            this.lblCoordenada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCoordenada.Click += new System.EventHandler(this.lblCoordenada_Click);
            // 
            // vida
            // 
            this.vida.BackColor = System.Drawing.Color.Transparent;
            this.vida.Image = global::Juego.Properties.Resources.punto;
            this.vida.Location = new System.Drawing.Point(120, 120);
            this.vida.Margin = new System.Windows.Forms.Padding(0);
            this.vida.Name = "vida";
            this.vida.Size = new System.Drawing.Size(60, 60);
            this.vida.TabIndex = 2;
            this.vida.TabStop = false;
            // 
            // sprite
            // 
            this.sprite.BackColor = System.Drawing.Color.Transparent;
            this.sprite.Image = global::Juego.Properties.Resources.start;
            this.sprite.Location = new System.Drawing.Point(0, 0);
            this.sprite.Margin = new System.Windows.Forms.Padding(0);
            this.sprite.Name = "sprite";
            this.sprite.Size = new System.Drawing.Size(60, 60);
            this.sprite.TabIndex = 0;
            this.sprite.TabStop = false;
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.BackColor = System.Drawing.Color.Transparent;
            this.lblVidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.Location = new System.Drawing.Point(567, 9);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(81, 16);
            this.lblVidas.TabIndex = 3;
            this.lblVidas.Text = "GEMAS : 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Juego.Properties.Resources.arbol;
            this.pictureBox1.Location = new System.Drawing.Point(420, 240);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(469, 7);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 18);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Direcion";
            // 
            // vida2
            // 
            this.vida2.BackColor = System.Drawing.Color.Transparent;
            this.vida2.Image = global::Juego.Properties.Resources.punto;
            this.vida2.Location = new System.Drawing.Point(420, 300);
            this.vida2.Margin = new System.Windows.Forms.Padding(0);
            this.vida2.Name = "vida2";
            this.vida2.Size = new System.Drawing.Size(60, 60);
            this.vida2.TabIndex = 2;
            this.vida2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Juego.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(300, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // vida3
            // 
            this.vida3.BackColor = System.Drawing.Color.Transparent;
            this.vida3.Image = global::Juego.Properties.Resources.punto;
            this.vida3.Location = new System.Drawing.Point(180, 600);
            this.vida3.Margin = new System.Windows.Forms.Padding(0);
            this.vida3.Name = "vida3";
            this.vida3.Size = new System.Drawing.Size(60, 60);
            this.vida3.TabIndex = 2;
            this.vida3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Juego.Properties.Resources.arbol;
            this.pictureBox3.Location = new System.Drawing.Point(120, 600);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Juego.Properties.Resources.arbol;
            this.pictureBox4.Location = new System.Drawing.Point(240, 600);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // lava
            // 
            this.lava.BackColor = System.Drawing.Color.Transparent;
            this.lava.Image = global::Juego.Properties.Resources.lava;
            this.lava.Location = new System.Drawing.Point(180, 360);
            this.lava.Margin = new System.Windows.Forms.Padding(0);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(120, 60);
            this.lava.TabIndex = 4;
            this.lava.TabStop = false;
            // 
            // vita
            // 
            this.vita.AutoSize = true;
            this.vita.BackColor = System.Drawing.Color.Transparent;
            this.vita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vita.Location = new System.Drawing.Point(200, 7);
            this.vita.Name = "vita";
            this.vita.Size = new System.Drawing.Size(74, 18);
            this.vita.TabIndex = 7;
            this.vita.Text = "VIDAS: 3";
            // 
            // ayuda
            // 
            this.ayuda.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ayuda.Controls.Add(this.label3);
            this.ayuda.Controls.Add(this.label2);
            this.ayuda.Controls.Add(this.label1);
            this.ayuda.Location = new System.Drawing.Point(34, 522);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(595, 100);
            this.ayuda.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Presiona Enter para ocultar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ni se te ocurra tocar la lava porque te resta vida...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recolecta todas las gemas...  ";
            // 
            // burn
            // 
            this.burn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.burn.Controls.Add(this.label5);
            this.burn.Controls.Add(this.label4);
            this.burn.Location = new System.Drawing.Point(34, 522);
            this.burn.Name = "burn";
            this.burn.Size = new System.Drawing.Size(595, 100);
            this.burn.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(399, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Presiona Enter para ocultar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Recuerda, ¡No tocar la lava! ...";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::Juego.Properties.Resources.backg1;
            this.ClientSize = new System.Drawing.Size(660, 660);
            this.Controls.Add(this.burn);
            this.Controls.Add(this.lava);
            this.Controls.Add(this.ayuda);
            this.Controls.Add(this.vita);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCoordenada);
            this.Controls.Add(this.sprite);
            this.Controls.Add(this.vida3);
            this.Controls.Add(this.vida2);
            this.Controls.Add(this.vida);
            this.Controls.Add(this.lblVidas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.vida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).EndInit();
            this.ayuda.ResumeLayout(false);
            this.ayuda.PerformLayout();
            this.burn.ResumeLayout(false);
            this.burn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sprite;
        private System.Windows.Forms.Label lblCoordenada;
        private System.Windows.Forms.PictureBox vida;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.PictureBox vida2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox vida3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox lava;
        private System.Windows.Forms.Label vita;
        private System.Windows.Forms.Panel ayuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel burn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

