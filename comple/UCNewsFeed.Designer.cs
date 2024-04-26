namespace ModeloInsta
{
    partial class UCNewsFeed
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNewsFeed));
            pictureBoxPosts = new PictureBox();
            pictureBoxProfile = new PictureBox();
            labelUserName = new Label();
            labelTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPosts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPosts
            // 
            pictureBoxPosts.BackColor = Color.White;
            pictureBoxPosts.Dock = DockStyle.Top;
            pictureBoxPosts.Image = (Image)resources.GetObject("pictureBoxPosts.Image");
            pictureBoxPosts.Location = new Point(0, 0);
            pictureBoxPosts.Name = "pictureBoxPosts";
            pictureBoxPosts.Size = new Size(186, 163);
            pictureBoxPosts.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPosts.TabIndex = 0;
            pictureBoxPosts.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Image = (Image)resources.GetObject("pictureBoxProfile.Image");
            pictureBoxProfile.Location = new Point(3, 169);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(37, 35);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProfile.TabIndex = 1;
            pictureBoxProfile.TabStop = false;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(46, 169);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(80, 16);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "Marta_gmz";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTime.Location = new Point(46, 186);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(78, 16);
            labelTime.TabIndex = 3;
            labelTime.Text = "Hace 3 horas";
            // 
            // UCNewsFeed
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(labelTime);
            Controls.Add(labelUserName);
            Controls.Add(pictureBoxProfile);
            Controls.Add(pictureBoxPosts);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UCNewsFeed";
            Size = new Size(186, 220);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPosts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPosts;
        private PictureBox pictureBoxProfile;
        private Label labelUserName;
        private Label labelTime;
    }
}
