namespace Piedra__Papel_o_Tijera
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPiedra1 = new System.Windows.Forms.Button();
            this.btnPapel1 = new System.Windows.Forms.Button();
            this.btnTijera1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTijera2 = new System.Windows.Forms.Button();
            this.btnPapel2 = new System.Windows.Forms.Button();
            this.btnPiedra2 = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPiedra1);
            this.groupBox1.Controls.Add(this.btnPapel1);
            this.groupBox1.Controls.Add(this.btnTijera1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JUGADOR 1";
            // 
            // btnPiedra1
            // 
            this.btnPiedra1.Image = ((System.Drawing.Image)(resources.GetObject("btnPiedra1.Image")));
            this.btnPiedra1.Location = new System.Drawing.Point(6, 16);
            this.btnPiedra1.Name = "btnPiedra1";
            this.btnPiedra1.Size = new System.Drawing.Size(133, 78);
            this.btnPiedra1.TabIndex = 2;
            this.btnPiedra1.UseVisualStyleBackColor = true;
            this.btnPiedra1.Click += new System.EventHandler(this.btnPiedra1_Click);
            // 
            // btnPapel1
            // 
            this.btnPapel1.Image = ((System.Drawing.Image)(resources.GetObject("btnPapel1.Image")));
            this.btnPapel1.Location = new System.Drawing.Point(145, 91);
            this.btnPapel1.Name = "btnPapel1";
            this.btnPapel1.Size = new System.Drawing.Size(133, 97);
            this.btnPapel1.TabIndex = 1;
            this.btnPapel1.UseVisualStyleBackColor = true;
            this.btnPapel1.Click += new System.EventHandler(this.btnPapel1_Click);
            // 
            // btnTijera1
            // 
            this.btnTijera1.Image = ((System.Drawing.Image)(resources.GetObject("btnTijera1.Image")));
            this.btnTijera1.Location = new System.Drawing.Point(284, 184);
            this.btnTijera1.Name = "btnTijera1";
            this.btnTijera1.Size = new System.Drawing.Size(133, 108);
            this.btnTijera1.TabIndex = 0;
            this.btnTijera1.UseVisualStyleBackColor = true;
            this.btnTijera1.Click += new System.EventHandler(this.btnTijera1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTijera2);
            this.groupBox2.Controls.Add(this.btnPapel2);
            this.groupBox2.Controls.Add(this.btnPiedra2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(440, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JUGADOR 2";
            // 
            // btnTijera2
            // 
            this.btnTijera2.Enabled = false;
            this.btnTijera2.Image = ((System.Drawing.Image)(resources.GetObject("btnTijera2.Image")));
            this.btnTijera2.Location = new System.Drawing.Point(284, 188);
            this.btnTijera2.Name = "btnTijera2";
            this.btnTijera2.Size = new System.Drawing.Size(137, 108);
            this.btnTijera2.TabIndex = 3;
            this.btnTijera2.UseVisualStyleBackColor = true;
            this.btnTijera2.Click += new System.EventHandler(this.btnTijera2_Click);
            // 
            // btnPapel2
            // 
            this.btnPapel2.Enabled = false;
            this.btnPapel2.Image = ((System.Drawing.Image)(resources.GetObject("btnPapel2.Image")));
            this.btnPapel2.Location = new System.Drawing.Point(145, 91);
            this.btnPapel2.Name = "btnPapel2";
            this.btnPapel2.Size = new System.Drawing.Size(133, 97);
            this.btnPapel2.TabIndex = 7;
            this.btnPapel2.UseVisualStyleBackColor = true;
            this.btnPapel2.Click += new System.EventHandler(this.btnPapel2_Click);
            // 
            // btnPiedra2
            // 
            this.btnPiedra2.Enabled = false;
            this.btnPiedra2.Image = ((System.Drawing.Image)(resources.GetObject("btnPiedra2.Image")));
            this.btnPiedra2.Location = new System.Drawing.Point(6, 16);
            this.btnPiedra2.Name = "btnPiedra2";
            this.btnPiedra2.Size = new System.Drawing.Size(133, 78);
            this.btnPiedra2.TabIndex = 6;
            this.btnPiedra2.UseVisualStyleBackColor = true;
            this.btnPiedra2.Click += new System.EventHandler(this.btnPiedra2_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Enabled = false;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Location = new System.Drawing.Point(387, 331);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 56);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo Juego";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(877, 425);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piedra, Papel o Tijera";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPiedra1;
        private System.Windows.Forms.Button btnPapel1;
        private System.Windows.Forms.Button btnTijera1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTijera2;
        private System.Windows.Forms.Button btnPapel2;
        private System.Windows.Forms.Button btnPiedra2;
        private System.Windows.Forms.Button btnNuevo;
    }
}

