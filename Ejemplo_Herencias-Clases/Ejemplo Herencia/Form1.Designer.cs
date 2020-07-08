namespace Ejemplo_Herencia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorHoraE = new System.Windows.Forms.TextBox();
            this.btnObjeto2E = new System.Windows.Forms.Button();
            this.btnObjeto1E = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHorasE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboContratoE = new System.Windows.Forms.ComboBox();
            this.cboTipoE = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidosE = new System.Windows.Forms.TextBox();
            this.txtNombresE = new System.Windows.Forms.TextBox();
            this.txtDocumentoE = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnObjeto2C = new System.Windows.Forms.Button();
            this.btnObjeto1C = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategoriaC = new System.Windows.Forms.ComboBox();
            this.cboTipoC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidosC = new System.Windows.Forms.TextBox();
            this.txtNombresC = new System.Windows.Forms.TextBox();
            this.txtDocumentoC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtValorHoraE);
            this.groupBox1.Controls.Add(this.btnObjeto2E);
            this.groupBox1.Controls.Add(this.btnObjeto1E);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtHorasE);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboContratoE);
            this.groupBox1.Controls.Add(this.cboTipoE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApellidosE);
            this.groupBox1.Controls.Add(this.txtNombresE);
            this.groupBox1.Controls.Add(this.txtDocumentoE);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 475);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMPLEADO";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Valor Hora";
            // 
            // txtValorHoraE
            // 
            this.txtValorHoraE.Location = new System.Drawing.Point(74, 154);
            this.txtValorHoraE.Name = "txtValorHoraE";
            this.txtValorHoraE.Size = new System.Drawing.Size(104, 20);
            this.txtValorHoraE.TabIndex = 15;
            // 
            // btnObjeto2E
            // 
            this.btnObjeto2E.Location = new System.Drawing.Point(248, 303);
            this.btnObjeto2E.Name = "btnObjeto2E";
            this.btnObjeto2E.Size = new System.Drawing.Size(106, 60);
            this.btnObjeto2E.TabIndex = 14;
            this.btnObjeto2E.Text = "Valor a pagar";
            this.btnObjeto2E.UseVisualStyleBackColor = true;
            this.btnObjeto2E.Click += new System.EventHandler(this.btnObjeto2E_Click);
            // 
            // btnObjeto1E
            // 
            this.btnObjeto1E.Location = new System.Drawing.Point(74, 303);
            this.btnObjeto1E.Name = "btnObjeto1E";
            this.btnObjeto1E.Size = new System.Drawing.Size(106, 60);
            this.btnObjeto1E.TabIndex = 13;
            this.btnObjeto1E.Text = "Calcular";
            this.btnObjeto1E.UseVisualStyleBackColor = true;
            this.btnObjeto1E.Click += new System.EventHandler(this.btnObjeto1E_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Horas";
            // 
            // txtHorasE
            // 
            this.txtHorasE.Location = new System.Drawing.Point(261, 154);
            this.txtHorasE.Name = "txtHorasE";
            this.txtHorasE.Size = new System.Drawing.Size(119, 20);
            this.txtHorasE.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Contrato";
            // 
            // cboContratoE
            // 
            this.cboContratoE.FormattingEnabled = true;
            this.cboContratoE.Items.AddRange(new object[] {
            "Indefinido",
            "Fijo",
            "Obra Labor ",
            "OPS"});
            this.cboContratoE.Location = new System.Drawing.Point(76, 211);
            this.cboContratoE.Name = "cboContratoE";
            this.cboContratoE.Size = new System.Drawing.Size(104, 21);
            this.cboContratoE.TabIndex = 9;
            // 
            // cboTipoE
            // 
            this.cboTipoE.FormattingEnabled = true;
            this.cboTipoE.Items.AddRange(new object[] {
            "Operario ",
            "Auxiliar ",
            "Coordinador"});
            this.cboTipoE.Location = new System.Drawing.Point(261, 103);
            this.cboTipoE.Name = "cboTipoE";
            this.cboTipoE.Size = new System.Drawing.Size(119, 21);
            this.cboTipoE.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Documento";
            // 
            // txtApellidosE
            // 
            this.txtApellidosE.Location = new System.Drawing.Point(74, 103);
            this.txtApellidosE.Name = "txtApellidosE";
            this.txtApellidosE.Size = new System.Drawing.Size(104, 20);
            this.txtApellidosE.TabIndex = 2;
            // 
            // txtNombresE
            // 
            this.txtNombresE.Location = new System.Drawing.Point(261, 47);
            this.txtNombresE.Name = "txtNombresE";
            this.txtNombresE.Size = new System.Drawing.Size(119, 20);
            this.txtNombresE.TabIndex = 1;
            // 
            // txtDocumentoE
            // 
            this.txtDocumentoE.Location = new System.Drawing.Point(74, 48);
            this.txtDocumentoE.Name = "txtDocumentoE";
            this.txtDocumentoE.Size = new System.Drawing.Size(104, 20);
            this.txtDocumentoE.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnObjeto2C);
            this.groupBox2.Controls.Add(this.btnObjeto1C);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboCategoriaC);
            this.groupBox2.Controls.Add(this.cboTipoC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtApellidosC);
            this.groupBox2.Controls.Add(this.txtNombresC);
            this.groupBox2.Controls.Add(this.txtDocumentoC);
            this.groupBox2.Location = new System.Drawing.Point(405, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 475);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENTE";
            // 
            // btnObjeto2C
            // 
            this.btnObjeto2C.Location = new System.Drawing.Point(311, 303);
            this.btnObjeto2C.Name = "btnObjeto2C";
            this.btnObjeto2C.Size = new System.Drawing.Size(106, 60);
            this.btnObjeto2C.TabIndex = 15;
            this.btnObjeto2C.Text = "Código ";
            this.btnObjeto2C.UseVisualStyleBackColor = true;
            this.btnObjeto2C.Click += new System.EventHandler(this.btnObjeto2C_Click);
            // 
            // btnObjeto1C
            // 
            this.btnObjeto1C.Location = new System.Drawing.Point(100, 303);
            this.btnObjeto1C.Name = "btnObjeto1C";
            this.btnObjeto1C.Size = new System.Drawing.Size(106, 60);
            this.btnObjeto1C.TabIndex = 21;
            this.btnObjeto1C.Text = "Registrar";
            this.btnObjeto1C.UseVisualStyleBackColor = true;
            this.btnObjeto1C.Click += new System.EventHandler(this.btnObjeto1C_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Categoría";
            // 
            // cboCategoriaC
            // 
            this.cboCategoriaC.FormattingEnabled = true;
            this.cboCategoriaC.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCategoriaC.Location = new System.Drawing.Point(87, 154);
            this.cboCategoriaC.Name = "cboCategoriaC";
            this.cboCategoriaC.Size = new System.Drawing.Size(136, 21);
            this.cboCategoriaC.TabIndex = 17;
            // 
            // cboTipoC
            // 
            this.cboTipoC.FormattingEnabled = true;
            this.cboTipoC.Items.AddRange(new object[] {
            "Mayorista ",
            "Al Detal"});
            this.cboTipoC.Location = new System.Drawing.Point(311, 102);
            this.cboTipoC.Name = "cboTipoC";
            this.cboTipoC.Size = new System.Drawing.Size(136, 21);
            this.cboTipoC.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Apellidos ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Documento";
            // 
            // txtApellidosC
            // 
            this.txtApellidosC.Location = new System.Drawing.Point(87, 106);
            this.txtApellidosC.Name = "txtApellidosC";
            this.txtApellidosC.Size = new System.Drawing.Size(136, 20);
            this.txtApellidosC.TabIndex = 6;
            // 
            // txtNombresC
            // 
            this.txtNombresC.Location = new System.Drawing.Point(311, 48);
            this.txtNombresC.Name = "txtNombresC";
            this.txtNombresC.Size = new System.Drawing.Size(136, 20);
            this.txtNombresC.TabIndex = 5;
            // 
            // txtDocumentoC
            // 
            this.txtDocumentoC.Location = new System.Drawing.Point(87, 48);
            this.txtDocumentoC.Name = "txtDocumentoC";
            this.txtDocumentoC.Size = new System.Drawing.Size(136, 20);
            this.txtDocumentoC.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 499);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herencia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObjeto2E;
        private System.Windows.Forms.Button btnObjeto1E;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHorasE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboContratoE;
        private System.Windows.Forms.ComboBox cboTipoE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidosE;
        private System.Windows.Forms.TextBox txtNombresE;
        private System.Windows.Forms.TextBox txtDocumentoE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnObjeto2C;
        private System.Windows.Forms.Button btnObjeto1C;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCategoriaC;
        private System.Windows.Forms.ComboBox cboTipoC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidosC;
        private System.Windows.Forms.TextBox txtNombresC;
        private System.Windows.Forms.TextBox txtDocumentoC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtValorHoraE;
    }
}

