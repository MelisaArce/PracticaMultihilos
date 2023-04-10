namespace TP_Multihilos
{
    partial class Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAtendidoCajaUno = new System.Windows.Forms.Label();
            this.lblAtendidoCajaDos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCliAtendidos = new System.Windows.Forms.Label();
            this.lblCliEsp1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCliEsp2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbClientesUno = new System.Windows.Forms.ListBox();
            this.lbClientesDos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(266, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComenzar.FlatAppearance.BorderSize = 0;
            this.btnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(296, 62);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(99, 53);
            this.btnComenzar.TabIndex = 2;
            this.btnComenzar.Text = "ATENDER";
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Atendiendo a: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Atendiendo a: ";
            // 
            // lblAtendidoCajaUno
            // 
            this.lblAtendidoCajaUno.AutoSize = true;
            this.lblAtendidoCajaUno.Location = new System.Drawing.Point(130, 202);
            this.lblAtendidoCajaUno.Name = "lblAtendidoCajaUno";
            this.lblAtendidoCajaUno.Size = new System.Drawing.Size(103, 13);
            this.lblAtendidoCajaUno.TabIndex = 5;
            this.lblAtendidoCajaUno.Text = "\"Nombre de cliente\"";
            // 
            // lblAtendidoCajaDos
            // 
            this.lblAtendidoCajaDos.AutoSize = true;
            this.lblAtendidoCajaDos.Location = new System.Drawing.Point(549, 202);
            this.lblAtendidoCajaDos.Name = "lblAtendidoCajaDos";
            this.lblAtendidoCajaDos.Size = new System.Drawing.Size(103, 13);
            this.lblAtendidoCajaDos.TabIndex = 6;
            this.lblAtendidoCajaDos.Text = "\"Nombre de cliente\"";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Clientes Atendidos:";
            // 
            // lblCliAtendidos
            // 
            this.lblCliAtendidos.AutoSize = true;
            this.lblCliAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliAtendidos.Location = new System.Drawing.Point(333, 138);
            this.lblCliAtendidos.Name = "lblCliAtendidos";
            this.lblCliAtendidos.Size = new System.Drawing.Size(24, 25);
            this.lblCliAtendidos.TabIndex = 20;
            this.lblCliAtendidos.Text = "0";
            // 
            // lblCliEsp1
            // 
            this.lblCliEsp1.AutoSize = true;
            this.lblCliEsp1.Location = new System.Drawing.Point(199, 14);
            this.lblCliEsp1.Name = "lblCliEsp1";
            this.lblCliEsp1.Size = new System.Drawing.Size(19, 13);
            this.lblCliEsp1.TabIndex = 23;
            this.lblCliEsp1.Text = "??";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Clientes a la espera: ";
            // 
            // lblCliEsp2
            // 
            this.lblCliEsp2.AutoSize = true;
            this.lblCliEsp2.Location = new System.Drawing.Point(614, 14);
            this.lblCliEsp2.Name = "lblCliEsp2";
            this.lblCliEsp2.Size = new System.Drawing.Size(19, 13);
            this.lblCliEsp2.TabIndex = 25;
            this.lblCliEsp2.Text = "??";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Clientes a la espera: ";
            // 
            // lbClientesUno
            // 
            this.lbClientesUno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbClientesUno.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientesUno.FormattingEnabled = true;
            this.lbClientesUno.ItemHeight = 19;
            this.lbClientesUno.Location = new System.Drawing.Point(41, 239);
            this.lbClientesUno.Name = "lbClientesUno";
            this.lbClientesUno.Size = new System.Drawing.Size(217, 327);
            this.lbClientesUno.TabIndex = 26;
            // 
            // lbClientesDos
            // 
            this.lbClientesDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbClientesDos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientesDos.FormattingEnabled = true;
            this.lbClientesDos.ItemHeight = 19;
            this.lbClientesDos.Location = new System.Drawing.Point(445, 239);
            this.lbClientesDos.Name = "lbClientesDos";
            this.lbClientesDos.Size = new System.Drawing.Size(217, 327);
            this.lbClientesDos.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 585);
            this.Controls.Add(this.lbClientesDos);
            this.Controls.Add(this.lbClientesUno);
            this.Controls.Add(this.lblCliEsp2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCliEsp1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCliAtendidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAtendidoCajaDos);
            this.Controls.Add(this.lblAtendidoCajaUno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SUPERMERCADO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblAtendidoCajaUno;
        public System.Windows.Forms.Label lblAtendidoCajaDos;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblCliAtendidos;
        public System.Windows.Forms.Label lblCliEsp1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblCliEsp2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox lbClientesUno;
        public System.Windows.Forms.ListBox lbClientesDos;
    }
}

