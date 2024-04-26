namespace comple
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
            this.btniniciar = new System.Windows.Forms.Button();
            this.ckmostrar = new System.Windows.Forms.CheckBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontra = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.AliceBlue;
            this.btniniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btniniciar.Location = new System.Drawing.Point(178, 159);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(75, 23);
            this.btniniciar.TabIndex = 11;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // ckmostrar
            // 
            this.ckmostrar.AutoSize = true;
            this.ckmostrar.BackColor = System.Drawing.Color.AliceBlue;
            this.ckmostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckmostrar.Location = new System.Drawing.Point(218, 107);
            this.ckmostrar.Name = "ckmostrar";
            this.ckmostrar.Size = new System.Drawing.Size(60, 17);
            this.ckmostrar.TabIndex = 10;
            this.ckmostrar.Text = "Ocultar";
            this.ckmostrar.UseVisualStyleBackColor = false;
            this.ckmostrar.CheckedChanged += new System.EventHandler(this.ckmostrar_CheckedChanged);
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.AliceBlue;
            this.txtcontra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtcontra.Location = new System.Drawing.Point(112, 104);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(100, 20);
            this.txtcontra.TabIndex = 9;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.AliceBlue;
            this.txtusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtusuario.Location = new System.Drawing.Point(112, 65);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 8;
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.BackColor = System.Drawing.Color.AliceBlue;
            this.lblcontra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcontra.Location = new System.Drawing.Point(29, 104);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(61, 13);
            this.lblcontra.TabIndex = 7;
            this.lblcontra.Text = "Contraseña";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.AliceBlue;
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusuario.Location = new System.Drawing.Point(47, 65);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 6;
            this.lblusuario.Text = "Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 267);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.ckmostrar);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.lblusuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.CheckBox ckmostrar;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.Label lblusuario;
    }
}

