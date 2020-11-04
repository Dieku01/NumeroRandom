namespace NumeroRandom
{
    partial class frmPrincipal
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeroMinimo = new System.Windows.Forms.TextBox();
            this.tbNumeroMaximo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(58, 165);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(163, 32);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "&Obtener Número";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(109, 106);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(25, 25);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número mínimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número máximo:";
            // 
            // tbNumeroMinimo
            // 
            this.tbNumeroMinimo.Location = new System.Drawing.Point(183, 29);
            this.tbNumeroMinimo.Name = "tbNumeroMinimo";
            this.tbNumeroMinimo.Size = new System.Drawing.Size(75, 20);
            this.tbNumeroMinimo.TabIndex = 4;
            this.tbNumeroMinimo.Text = "0";
            this.tbNumeroMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroMinimo_KeyPress);
            // 
            // tbNumeroMaximo
            // 
            this.tbNumeroMaximo.Location = new System.Drawing.Point(188, 56);
            this.tbNumeroMaximo.Name = "tbNumeroMaximo";
            this.tbNumeroMaximo.Size = new System.Drawing.Size(75, 20);
            this.tbNumeroMaximo.TabIndex = 5;
            this.tbNumeroMaximo.Text = "10";
            this.tbNumeroMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroMaximo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Número:";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 228);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNumeroMaximo);
            this.Controls.Add(this.tbNumeroMinimo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.Text = "Randomizador de números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeroMinimo;
        private System.Windows.Forms.TextBox tbNumeroMaximo;
        private System.Windows.Forms.Label label3;
    }
}

