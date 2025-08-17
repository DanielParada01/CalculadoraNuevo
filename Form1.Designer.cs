
namespace WindowsFormsApp1
{
    partial class btncalcularopciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.optsuma = new System.Windows.Forms.RadioButton();
            this.optresta = new System.Windows.Forms.RadioButton();
            this.optmultiplicacion = new System.Windows.Forms.RadioButton();
            this.optdivicion = new System.Windows.Forms.RadioButton();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.optexponente = new System.Windows.Forms.RadioButton();
            this.cboopciones = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nuumero 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(224, 52);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(100, 20);
            this.txb1.TabIndex = 2;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(224, 86);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(100, 20);
            this.txb2.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(224, 134);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // optsuma
            // 
            this.optsuma.AutoSize = true;
            this.optsuma.Location = new System.Drawing.Point(371, 170);
            this.optsuma.Name = "optsuma";
            this.optsuma.Size = new System.Drawing.Size(52, 17);
            this.optsuma.TabIndex = 5;
            this.optsuma.TabStop = true;
            this.optsuma.Text = "Suma";
            this.optsuma.UseVisualStyleBackColor = true;
            // 
            // optresta
            // 
            this.optresta.AutoSize = true;
            this.optresta.Location = new System.Drawing.Point(371, 192);
            this.optresta.Name = "optresta";
            this.optresta.Size = new System.Drawing.Size(48, 17);
            this.optresta.TabIndex = 6;
            this.optresta.TabStop = true;
            this.optresta.Text = "resta";
            this.optresta.UseVisualStyleBackColor = true;
            // 
            // optmultiplicacion
            // 
            this.optmultiplicacion.AutoSize = true;
            this.optmultiplicacion.Location = new System.Drawing.Point(371, 215);
            this.optmultiplicacion.Name = "optmultiplicacion";
            this.optmultiplicacion.Size = new System.Drawing.Size(88, 17);
            this.optmultiplicacion.TabIndex = 7;
            this.optmultiplicacion.TabStop = true;
            this.optmultiplicacion.Text = "multiplicacion";
            this.optmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optdivicion
            // 
            this.optdivicion.AutoSize = true;
            this.optdivicion.Location = new System.Drawing.Point(371, 238);
            this.optdivicion.Name = "optdivicion";
            this.optdivicion.Size = new System.Drawing.Size(61, 17);
            this.optdivicion.TabIndex = 8;
            this.optdivicion.TabStop = true;
            this.optdivicion.Text = "divicion";
            this.optdivicion.UseVisualStyleBackColor = true;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(143, 195);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(53, 13);
            this.lblrespuesta.TabIndex = 9;
            this.lblrespuesta.Text = "respuesta";
            // 
            // optexponente
            // 
            this.optexponente.AutoSize = true;
            this.optexponente.Location = new System.Drawing.Point(371, 262);
            this.optexponente.Name = "optexponente";
            this.optexponente.Size = new System.Drawing.Size(75, 17);
            this.optexponente.TabIndex = 10;
            this.optexponente.TabStop = true;
            this.optexponente.Text = "exponente";
            this.optexponente.UseVisualStyleBackColor = true;
            // 
            // cboopciones
            // 
            this.cboopciones.FormattingEnabled = true;
            this.cboopciones.Items.AddRange(new object[] {
            "suma",
            "resta",
            "multiplicacion",
            "divicion"});
            this.cboopciones.Location = new System.Drawing.Point(367, 51);
            this.cboopciones.Name = "cboopciones";
            this.cboopciones.Size = new System.Drawing.Size(121, 21);
            this.cboopciones.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "calcular opciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncalcularopciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboopciones);
            this.Controls.Add(this.optexponente);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.optdivicion);
            this.Controls.Add(this.optmultiplicacion);
            this.Controls.Add(this.optresta);
            this.Controls.Add(this.optsuma);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "btncalcularopciones";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.RadioButton optsuma;
        private System.Windows.Forms.RadioButton optresta;
        private System.Windows.Forms.RadioButton optmultiplicacion;
        private System.Windows.Forms.RadioButton optdivicion;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.RadioButton optexponente;
        private System.Windows.Forms.ComboBox cboopciones;
        private System.Windows.Forms.Button button1;
    }
}

