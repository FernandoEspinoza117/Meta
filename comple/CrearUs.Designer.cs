namespace comple
{
    partial class CrearUs
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
            this.button1 = new System.Windows.Forms.Button();
            this.NombreU = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.Genero = new System.Windows.Forms.TextBox();
            this.ApellidoU = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NombreU
            // 
            this.NombreU.Location = new System.Drawing.Point(65, 54);
            this.NombreU.Multiline = true;
            this.NombreU.Name = "NombreU";
            this.NombreU.Size = new System.Drawing.Size(313, 33);
            this.NombreU.TabIndex = 1;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(65, 223);
            this.Correo.Multiline = true;
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(313, 33);
            this.Correo.TabIndex = 2;
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(218, 171);
            this.Edad.Multiline = true;
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(100, 33);
            this.Edad.TabIndex = 3;
            // 
            // Genero
            // 
            this.Genero.Location = new System.Drawing.Point(65, 171);
            this.Genero.Multiline = true;
            this.Genero.Name = "Genero";
            this.Genero.Size = new System.Drawing.Size(121, 33);
            this.Genero.TabIndex = 4;
            // 
            // ApellidoU
            // 
            this.ApellidoU.Location = new System.Drawing.Point(65, 106);
            this.ApellidoU.Multiline = true;
            this.ApellidoU.Name = "ApellidoU";
            this.ApellidoU.Size = new System.Drawing.Size(313, 33);
            this.ApellidoU.TabIndex = 5;
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(65, 287);
            this.Contraseña.Multiline = true;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(313, 33);
            this.Contraseña.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(79, 38);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 7;
            this.Nombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Genero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contraseña";
            // 
            // CrearUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 435);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.ApellidoU);
            this.Controls.Add(this.Genero);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.NombreU);
            this.Controls.Add(this.button1);
            this.Name = "CrearUs";
            this.Text = "CrearUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NombreU;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.TextBox Genero;
        private System.Windows.Forms.TextBox ApellidoU;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}