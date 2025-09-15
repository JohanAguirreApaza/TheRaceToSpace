namespace TheRacetoSpace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbAlien = new System.Windows.Forms.PictureBox();
            this.pbBarril = new System.Windows.Forms.PictureBox();
            this.pbPiso1 = new System.Windows.Forms.PictureBox();
            this.pbAgujero = new System.Windows.Forms.PictureBox();
            this.lbPuntaje = new System.Windows.Forms.Label();
            this.timerInterno = new System.Windows.Forms.Timer(this.components);
            this.pbFondo1 = new System.Windows.Forms.PictureBox();
            this.pbPiso4 = new System.Windows.Forms.PictureBox();
            this.pbVida5 = new System.Windows.Forms.PictureBox();
            this.pbVida4 = new System.Windows.Forms.PictureBox();
            this.pbVida3 = new System.Windows.Forms.PictureBox();
            this.pbVida2 = new System.Windows.Forms.PictureBox();
            this.pbVida1 = new System.Windows.Forms.PictureBox();
            this.pbPiso5 = new System.Windows.Forms.PictureBox();
            this.pbBarril4 = new System.Windows.Forms.PictureBox();
            this.pbAgujero2 = new System.Windows.Forms.PictureBox();
            this.pbBarril2 = new System.Windows.Forms.PictureBox();
            this.pbBarril3 = new System.Windows.Forms.PictureBox();
            this.pbPlatillo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbPiso3 = new System.Windows.Forms.PictureBox();
            this.pbPiso2 = new System.Windows.Forms.PictureBox();
            this.btPAUSA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarril)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgujero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarril4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgujero2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarril2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarril3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAlien
            // 
            this.pbAlien.Image = ((System.Drawing.Image)(resources.GetObject("pbAlien.Image")));
            this.pbAlien.Location = new System.Drawing.Point(12, 440);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(56, 86);
            this.pbAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlien.TabIndex = 0;
            this.pbAlien.TabStop = false;
            this.pbAlien.Click += new System.EventHandler(this.pbAlien_Click);
            // 
            // pbBarril
            // 
            this.pbBarril.Image = ((System.Drawing.Image)(resources.GetObject("pbBarril.Image")));
            this.pbBarril.Location = new System.Drawing.Point(238, 488);
            this.pbBarril.Name = "pbBarril";
            this.pbBarril.Size = new System.Drawing.Size(73, 76);
            this.pbBarril.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarril.TabIndex = 12;
            this.pbBarril.TabStop = false;
            // 
            // pbPiso1
            // 
            this.pbPiso1.Image = ((System.Drawing.Image)(resources.GetObject("pbPiso1.Image")));
            this.pbPiso1.Location = new System.Drawing.Point(-16, 532);
            this.pbPiso1.Name = "pbPiso1";
            this.pbPiso1.Size = new System.Drawing.Size(542, 60);
            this.pbPiso1.TabIndex = 14;
            this.pbPiso1.TabStop = false;
            // 
            // pbAgujero
            // 
            this.pbAgujero.Image = ((System.Drawing.Image)(resources.GetObject("pbAgujero.Image")));
            this.pbAgujero.Location = new System.Drawing.Point(516, 532);
            this.pbAgujero.Name = "pbAgujero";
            this.pbAgujero.Size = new System.Drawing.Size(141, 65);
            this.pbAgujero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgujero.TabIndex = 17;
            this.pbAgujero.TabStop = false;
            // 
            // lbPuntaje
            // 
            this.lbPuntaje.AutoSize = true;
            this.lbPuntaje.BackColor = System.Drawing.Color.Black;
            this.lbPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPuntaje.Location = new System.Drawing.Point(31, 116);
            this.lbPuntaje.Name = "lbPuntaje";
            this.lbPuntaje.Size = new System.Drawing.Size(59, 20);
            this.lbPuntaje.TabIndex = 22;
            this.lbPuntaje.Text = "label2";
            this.lbPuntaje.Click += new System.EventHandler(this.lbPuntaje_Click);
            // 
            // timerInterno
            // 
            this.timerInterno.Tick += new System.EventHandler(this.timerInterno_Tick);
            // 
            // pbFondo1
            // 
            this.pbFondo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbFondo1.Image = ((System.Drawing.Image)(resources.GetObject("pbFondo1.Image")));
            this.pbFondo1.Location = new System.Drawing.Point(-6, 1);
            this.pbFondo1.Name = "pbFondo1";
            this.pbFondo1.Size = new System.Drawing.Size(2214, 576);
            this.pbFondo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFondo1.TabIndex = 32;
            this.pbFondo1.TabStop = false;
            // 
            // pbPiso4
            // 
            this.pbPiso4.Image = ((System.Drawing.Image)(resources.GetObject("pbPiso4.Image")));
            this.pbPiso4.Location = new System.Drawing.Point(710, 357);
            this.pbPiso4.Name = "pbPiso4";
            this.pbPiso4.Size = new System.Drawing.Size(276, 60);
            this.pbPiso4.TabIndex = 35;
            this.pbPiso4.TabStop = false;
            // 
            // pbVida5
            // 
            this.pbVida5.Image = ((System.Drawing.Image)(resources.GetObject("pbVida5.Image")));
            this.pbVida5.Location = new System.Drawing.Point(35, 28);
            this.pbVida5.Name = "pbVida5";
            this.pbVida5.Size = new System.Drawing.Size(48, 73);
            this.pbVida5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVida5.TabIndex = 37;
            this.pbVida5.TabStop = false;
            // 
            // pbVida4
            // 
            this.pbVida4.Image = ((System.Drawing.Image)(resources.GetObject("pbVida4.Image")));
            this.pbVida4.Location = new System.Drawing.Point(89, 28);
            this.pbVida4.Name = "pbVida4";
            this.pbVida4.Size = new System.Drawing.Size(48, 73);
            this.pbVida4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVida4.TabIndex = 38;
            this.pbVida4.TabStop = false;
            // 
            // pbVida3
            // 
            this.pbVida3.Image = ((System.Drawing.Image)(resources.GetObject("pbVida3.Image")));
            this.pbVida3.Location = new System.Drawing.Point(143, 28);
            this.pbVida3.Name = "pbVida3";
            this.pbVida3.Size = new System.Drawing.Size(48, 73);
            this.pbVida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVida3.TabIndex = 39;
            this.pbVida3.TabStop = false;
            // 
            // pbVida2
            // 
            this.pbVida2.Image = ((System.Drawing.Image)(resources.GetObject("pbVida2.Image")));
            this.pbVida2.Location = new System.Drawing.Point(197, 28);
            this.pbVida2.Name = "pbVida2";
            this.pbVida2.Size = new System.Drawing.Size(48, 73);
            this.pbVida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVida2.TabIndex = 40;
            this.pbVida2.TabStop = false;
            // 
            // pbVida1
            // 
            this.pbVida1.Image = ((System.Drawing.Image)(resources.GetObject("pbVida1.Image")));
            this.pbVida1.Location = new System.Drawing.Point(251, 28);
            this.pbVida1.Name = "pbVida1";
            this.pbVida1.Size = new System.Drawing.Size(48, 73);
            this.pbVida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVida1.TabIndex = 41;
            this.pbVida1.TabStop = false;
            // 
            // pbPiso5
            // 
            this.pbPiso5.Image = ((System.Drawing.Image)(resources.GetObject("pbPiso5.Image")));
            this.pbPiso5.Location = new System.Drawing.Point(1070, 255);
            this.pbPiso5.Name = "pbPiso5";
            this.pbPiso5.Size = new System.Drawing.Size(582, 60);
            this.pbPiso5.TabIndex = 34;
            this.pbPiso5.TabStop = false;
            // 
            // pbBarril4
            // 
            this.pbBarril4.Image = ((System.Drawing.Image)(resources.GetObject("pbBarril4.Image")));
            this.pbBarril4.Location = new System.Drawing.Point(1335, 203);
            this.pbBarril4.Name = "pbBarril4";
            this.pbBarril4.Size = new System.Drawing.Size(73, 76);
            this.pbBarril4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarril4.TabIndex = 42;
            this.pbBarril4.TabStop = false;
            // 
            // pbAgujero2
            // 
            this.pbAgujero2.Image = ((System.Drawing.Image)(resources.GetObject("pbAgujero2.Image")));
            this.pbAgujero2.Location = new System.Drawing.Point(1316, 532);
            this.pbAgujero2.Name = "pbAgujero2";
            this.pbAgujero2.Size = new System.Drawing.Size(156, 60);
            this.pbAgujero2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAgujero2.TabIndex = 43;
            this.pbAgujero2.TabStop = false;
            // 
            // pbBarril2
            // 
            this.pbBarril2.Image = ((System.Drawing.Image)(resources.GetObject("pbBarril2.Image")));
            this.pbBarril2.Location = new System.Drawing.Point(877, 307);
            this.pbBarril2.Name = "pbBarril2";
            this.pbBarril2.Size = new System.Drawing.Size(73, 76);
            this.pbBarril2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarril2.TabIndex = 44;
            this.pbBarril2.TabStop = false;
            // 
            // pbBarril3
            // 
            this.pbBarril3.Image = ((System.Drawing.Image)(resources.GetObject("pbBarril3.Image")));
            this.pbBarril3.Location = new System.Drawing.Point(1070, 477);
            this.pbBarril3.Name = "pbBarril3";
            this.pbBarril3.Size = new System.Drawing.Size(73, 76);
            this.pbBarril3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarril3.TabIndex = 45;
            this.pbBarril3.TabStop = false;
            // 
            // pbPlatillo
            // 
            this.pbPlatillo.Image = ((System.Drawing.Image)(resources.GetObject("pbPlatillo.Image")));
            this.pbPlatillo.Location = new System.Drawing.Point(541, 347);
            this.pbPlatillo.Name = "pbPlatillo";
            this.pbPlatillo.Size = new System.Drawing.Size(146, 36);
            this.pbPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlatillo.TabIndex = 46;
            this.pbPlatillo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pbPiso3
            // 
            this.pbPiso3.Image = ((System.Drawing.Image)(resources.GetObject("pbPiso3.Image")));
            this.pbPiso3.Location = new System.Drawing.Point(1469, 532);
            this.pbPiso3.Name = "pbPiso3";
            this.pbPiso3.Size = new System.Drawing.Size(721, 60);
            this.pbPiso3.TabIndex = 16;
            this.pbPiso3.TabStop = false;
            // 
            // pbPiso2
            // 
            this.pbPiso2.Image = ((System.Drawing.Image)(resources.GetObject("pbPiso2.Image")));
            this.pbPiso2.Location = new System.Drawing.Point(647, 532);
            this.pbPiso2.Name = "pbPiso2";
            this.pbPiso2.Size = new System.Drawing.Size(674, 60);
            this.pbPiso2.TabIndex = 15;
            this.pbPiso2.TabStop = false;
            // 
            // btPAUSA
            // 
            this.btPAUSA.BackColor = System.Drawing.Color.Black;
            this.btPAUSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPAUSA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPAUSA.Location = new System.Drawing.Point(1469, 12);
            this.btPAUSA.Name = "btPAUSA";
            this.btPAUSA.Size = new System.Drawing.Size(50, 47);
            this.btPAUSA.TabIndex = 47;
            this.btPAUSA.Text = "⏸️";
            this.btPAUSA.UseVisualStyleBackColor = false;
            this.btPAUSA.Click += new System.EventHandler(this.btPAUSA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 589);
            this.Controls.Add(this.btPAUSA);
            this.Controls.Add(this.pbPlatillo);
            this.Controls.Add(this.pbBarril3);
            this.Controls.Add(this.pbBarril2);
            this.Controls.Add(this.pbAgujero2);
            this.Controls.Add(this.pbBarril4);
            this.Controls.Add(this.pbVida1);
            this.Controls.Add(this.pbVida2);
            this.Controls.Add(this.pbVida3);
            this.Controls.Add(this.pbVida4);
            this.Controls.Add(this.pbVida5);
            this.Controls.Add(this.pbPiso4);
            this.Controls.Add(this.pbPiso5);
            this.Controls.Add(this.lbPuntaje);
            this.Controls.Add(this.pbBarril);
            this.Controls.Add(this.pbAgujero);
            this.Controls.Add(this.pbPiso3);
            this.Controls.Add(this.pbPiso2);
            this.Controls.Add(this.pbPiso1);
            this.Controls.Add(this.pbAlien);
            this.Controls.Add(this.pbFondo1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarril)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgujero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarril4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgujero2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarril2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarril3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPiso2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlien;
        private System.Windows.Forms.PictureBox pbBarril;
        private System.Windows.Forms.PictureBox pbPiso1;
        private System.Windows.Forms.PictureBox pbAgujero;
        private System.Windows.Forms.Label lbPuntaje;
        private System.Windows.Forms.Timer timerInterno;
        private System.Windows.Forms.PictureBox pbFondo1;
        private System.Windows.Forms.PictureBox pbPiso4;
        private System.Windows.Forms.PictureBox pbVida5;
        private System.Windows.Forms.PictureBox pbVida4;
        private System.Windows.Forms.PictureBox pbVida3;
        private System.Windows.Forms.PictureBox pbVida2;
        private System.Windows.Forms.PictureBox pbVida1;
        private System.Windows.Forms.PictureBox pbPiso5;
        private System.Windows.Forms.PictureBox pbBarril4;
        private System.Windows.Forms.PictureBox pbAgujero2;
        private System.Windows.Forms.PictureBox pbBarril2;
        private System.Windows.Forms.PictureBox pbBarril3;
        private System.Windows.Forms.PictureBox pbPlatillo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbPiso3;
        private System.Windows.Forms.PictureBox pbPiso2;
        private System.Windows.Forms.Button btPAUSA;
    }
}

