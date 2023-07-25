namespace Juego
{
    partial class puntaje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(puntaje));
            this.puntajes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDie = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.pbPuntos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // puntajes
            // 
            this.puntajes.AutoSize = true;
            this.puntajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntajes.Location = new System.Drawing.Point(115, 302);
            this.puntajes.Name = "puntajes";
            this.puntajes.Size = new System.Drawing.Size(445, 42);
            this.puntajes.TabIndex = 0;
            this.puntajes.Text = "Gemas recolectadas 0/3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salir";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // lblDie
            // 
            this.lblDie.AutoSize = true;
            this.lblDie.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDie.ForeColor = System.Drawing.Color.Red;
            this.lblDie.Location = new System.Drawing.Point(194, 183);
            this.lblDie.Name = "lblDie";
            this.lblDie.Size = new System.Drawing.Size(272, 42);
            this.lblDie.TabIndex = 2;
            this.lblDie.Text = "¡Estas Muerto!";
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.ForeColor = System.Drawing.Color.Orange;
            this.win.Location = new System.Drawing.Point(208, 183);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(241, 42);
            this.win.TabIndex = 2;
            this.win.Text = "¡Felicidades!";
            // 
            // pbPuntos
            // 
            this.pbPuntos.Location = new System.Drawing.Point(215, 240);
            this.pbPuntos.Margin = new System.Windows.Forms.Padding(0);
            this.pbPuntos.Name = "pbPuntos";
            this.pbPuntos.Size = new System.Drawing.Size(230, 50);
            this.pbPuntos.TabIndex = 1;
            this.pbPuntos.TabStop = false;
            // 
            // puntaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 621);
            this.Controls.Add(this.win);
            this.Controls.Add(this.lblDie);
            this.Controls.Add(this.pbPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.puntajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "puntaje";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "puntaje";
            this.Load += new System.EventHandler(this.puntaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label puntajes;
        public System.Windows.Forms.PictureBox pbPuntos;
        public System.Windows.Forms.Label lblDie;
        public System.Windows.Forms.Label win;
    }
}