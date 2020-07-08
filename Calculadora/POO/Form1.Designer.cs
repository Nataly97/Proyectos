namespace POO
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdoPotencia = new System.Windows.Forms.RadioButton();
            this.rdoDividir = new System.Windows.Forms.RadioButton();
            this.rdoRestar = new System.Windows.Forms.RadioButton();
            this.rdoMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdoSumar = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumero2);
            this.groupBox1.Controls.Add(this.txtNumero1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(257, 97);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(24, 97);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.rdoPotencia);
            this.groupBox2.Controls.Add(this.rdoDividir);
            this.groupBox2.Controls.Add(this.rdoRestar);
            this.groupBox2.Controls.Add(this.rdoMultiplicar);
            this.groupBox2.Controls.Add(this.rdoSumar);
            this.groupBox2.Location = new System.Drawing.Point(15, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acción";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(291, 83);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 32);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rdoPotencia
            // 
            this.rdoPotencia.AutoSize = true;
            this.rdoPotencia.Location = new System.Drawing.Point(202, 91);
            this.rdoPotencia.Name = "rdoPotencia";
            this.rdoPotencia.Size = new System.Drawing.Size(67, 17);
            this.rdoPotencia.TabIndex = 4;
            this.rdoPotencia.TabStop = true;
            this.rdoPotencia.Text = "Potencia";
            this.rdoPotencia.UseVisualStyleBackColor = true;
            // 
            // rdoDividir
            // 
            this.rdoDividir.AutoSize = true;
            this.rdoDividir.Location = new System.Drawing.Point(95, 91);
            this.rdoDividir.Name = "rdoDividir";
            this.rdoDividir.Size = new System.Drawing.Size(54, 17);
            this.rdoDividir.TabIndex = 3;
            this.rdoDividir.TabStop = true;
            this.rdoDividir.Text = "Dividir";
            this.rdoDividir.UseVisualStyleBackColor = true;
            // 
            // rdoRestar
            // 
            this.rdoRestar.AutoSize = true;
            this.rdoRestar.Location = new System.Drawing.Point(152, 45);
            this.rdoRestar.Name = "rdoRestar";
            this.rdoRestar.Size = new System.Drawing.Size(56, 17);
            this.rdoRestar.TabIndex = 2;
            this.rdoRestar.TabStop = true;
            this.rdoRestar.Text = "Restar";
            this.rdoRestar.UseVisualStyleBackColor = true;
            // 
            // rdoMultiplicar
            // 
            this.rdoMultiplicar.AutoSize = true;
            this.rdoMultiplicar.Location = new System.Drawing.Point(257, 45);
            this.rdoMultiplicar.Name = "rdoMultiplicar";
            this.rdoMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rdoMultiplicar.TabIndex = 1;
            this.rdoMultiplicar.TabStop = true;
            this.rdoMultiplicar.Text = "Multiplicar";
            this.rdoMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdoSumar
            // 
            this.rdoSumar.AutoSize = true;
            this.rdoSumar.Location = new System.Drawing.Point(35, 45);
            this.rdoSumar.Name = "rdoSumar";
            this.rdoSumar.Size = new System.Drawing.Size(55, 17);
            this.rdoSumar.TabIndex = 0;
            this.rdoSumar.TabStop = true;
            this.rdoSumar.Text = "Sumar";
            this.rdoSumar.UseVisualStyleBackColor = true;
            this.rdoSumar.CheckedChanged += new System.EventHandler(this.rdoSumar_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResultado);
            this.groupBox3.Location = new System.Drawing.Point(15, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 71);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(21, 34);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 15);
            this.lblResultado.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 415);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdoPotencia;
        private System.Windows.Forms.RadioButton rdoDividir;
        private System.Windows.Forms.RadioButton rdoRestar;
        private System.Windows.Forms.RadioButton rdoMultiplicar;
        private System.Windows.Forms.RadioButton rdoSumar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

