using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class InstaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstaForm));
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button8 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ucNewsFeed1 = new ModeloInsta.UCNewsFeed();
            ucNewsFeed2 = new ModeloInsta.UCNewsFeed();
            ucNewsFeed3 = new ModeloInsta.UCNewsFeed();
            ucNewsFeed4 = new ModeloInsta.UCNewsFeed();
            ucNewsFeed5 = new ModeloInsta.UCNewsFeed();
            ucNewsFeed6 = new ModeloInsta.UCNewsFeed();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 562);
            panel1.TabIndex = 0;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Gray;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(156, 525);
            button7.Name = "button7";
            button7.Size = new Size(32, 29);
            button7.TabIndex = 8;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Gray;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(7, 525);
            button6.Name = "button6";
            button6.Size = new Size(32, 29);
            button6.TabIndex = 7;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Gray;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 258);
            button5.Name = "button5";
            button5.Size = new Size(190, 35);
            button5.TabIndex = 6;
            button5.Text = "           Perfil";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Gray;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 217);
            button4.Name = "button4";
            button4.Size = new Size(190, 35);
            button4.TabIndex = 5;
            button4.Text = "           Subir";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Gray;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 176);
            button3.Name = "button3";
            button3.Size = new Size(190, 35);
            button3.TabIndex = 4;
            button3.Text = "           Notificacion";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Gray;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 135);
            button2.Name = "button2";
            button2.Size = new Size(190, 35);
            button2.TabIndex = 3;
            button2.Text = "           Explorar";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gray;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 94);
            button1.Name = "button1";
            button1.Size = new Size(190, 35);
            button1.TabIndex = 2;
            button1.Text = "           Incio";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 13);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 1;
            label1.Text = "instagram";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.Gray;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(404, 8);
            button8.Name = "button8";
            button8.Size = new Size(32, 29);
            button8.TabIndex = 9;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(224, 224, 224);
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.ForeColor = Color.Gray;
            maskedTextBox1.Location = new Point(433, 11);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(213, 23);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.Text = "Buscar";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(652, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(705, 12);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 9;
            label2.Text = "RaulF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(202, 15);
            label3.Name = "label3";
            label3.Size = new Size(161, 16);
            label3.TabIndex = 11;
            label3.Text = "Publicaciones recientes";
            // 
            // ucNewsFeed1
            // 
            ucNewsFeed1.BackColor = Color.FromArgb(224, 224, 224);
            ucNewsFeed1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucNewsFeed1.Location = new Point(202, 58);
            ucNewsFeed1.Name = "ucNewsFeed1";
            ucNewsFeed1.PostImage = (Image)resources.GetObject("ucNewsFeed1.PostImage");
            ucNewsFeed1.PostTime = "Hace 3 horas";
            ucNewsFeed1.ProfilePic = (Image)resources.GetObject("ucNewsFeed1.ProfilePic");
            ucNewsFeed1.Size = new Size(186, 220);
            ucNewsFeed1.TabIndex = 12;
            ucNewsFeed1.UserName = "Marta_gmz";
            // 
            // ucNewsFeed2
            // 
            ucNewsFeed2.BackColor = Color.FromArgb(224, 224, 224);
            ucNewsFeed2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucNewsFeed2.Location = new Point(409, 58);
            ucNewsFeed2.Name = "ucNewsFeed2";
            ucNewsFeed2.PostImage = (Image)resources.GetObject("ucNewsFeed2.PostImage");
            ucNewsFeed2.PostTime = "Hace 5 horas";
            ucNewsFeed2.ProfilePic = (Image)resources.GetObject("ucNewsFeed2.ProfilePic");
            ucNewsFeed2.Size = new Size(186, 220);
            ucNewsFeed2.TabIndex = 13;
            ucNewsFeed2.UserName = "Samu54";
            ucNewsFeed2.Load += ucNewsFeed2_Load;
            // 
            // ucNewsFeed3
            // 
            ucNewsFeed3.BackColor = Color.FromArgb(224, 224, 224);
            ucNewsFeed3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucNewsFeed3.Location = new Point(618, 58);
            ucNewsFeed3.Name = "ucNewsFeed3";
            ucNewsFeed3.PostImage = (Image)resources.GetObject("ucNewsFeed3.PostImage");
            ucNewsFeed3.PostTime = "Hace 8 horas";
            ucNewsFeed3.ProfilePic = (Image)resources.GetObject("ucNewsFeed3.ProfilePic");
            ucNewsFeed3.Size = new Size(186, 220);
            ucNewsFeed3.TabIndex = 14;
            ucNewsFeed3.UserName = "Carlos65";
            // 
            // ucNewsFeed4
            // 
            ucNewsFeed4.BackColor = Color.FromArgb(224, 224, 224);
            ucNewsFeed4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucNewsFeed4.Location = new Point(618, 299);
            ucNewsFeed4.Name = "ucNewsFeed4";
            ucNewsFeed4.PostImage = (Image)resources.GetObject("ucNewsFeed4.PostImage");
            ucNewsFeed4.PostTime = "Hace 20 horas";
            ucNewsFeed4.ProfilePic = (Image)resources.GetObject("ucNewsFeed4.ProfilePic");
            ucNewsFeed4.Size = new Size(186, 220);
            ucNewsFeed4.TabIndex = 17;
            ucNewsFeed4.UserName = "ErnestoM03";
            // 
            // ucNewsFeed5
            // 
            ucNewsFeed5.BackColor = Color.FromArgb(224, 224, 224);
            ucNewsFeed5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucNewsFeed5.Location = new Point(409, 299);
            ucNewsFeed5.Name = "ucNewsFeed5";
            ucNewsFeed5.PostImage = (Image)resources.GetObject("ucNewsFeed5.PostImage");
            ucNewsFeed5.PostTime = "Hace 16 horas";
            ucNewsFeed5.ProfilePic = (Image)resources.GetObject("ucNewsFeed5.ProfilePic");
            ucNewsFeed5.Size = new Size(186, 220);
            ucNewsFeed5.TabIndex = 16;
            ucNewsFeed5.UserName = "Henry75";
            // 
            // ucNewsFeed6
            // 
            ucNewsFeed6.BackColor = Color.FromArgb(224, 224, 224);
            ucNewsFeed6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucNewsFeed6.Location = new Point(202, 299);
            ucNewsFeed6.Name = "ucNewsFeed6";
            ucNewsFeed6.PostImage = (Image)resources.GetObject("ucNewsFeed6.PostImage");
            ucNewsFeed6.PostTime = "Hace 12 horas";
            ucNewsFeed6.ProfilePic = (Image)resources.GetObject("ucNewsFeed6.ProfilePic");
            ucNewsFeed6.Size = new Size(186, 220);
            ucNewsFeed6.TabIndex = 15;
            ucNewsFeed6.UserName = "LuciaMTZ";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Silver;
            ClientSize = new Size(816, 562);
            Controls.Add(ucNewsFeed4);
            Controls.Add(ucNewsFeed5);
            Controls.Add(ucNewsFeed6);
            Controls.Add(ucNewsFeed3);
            Controls.Add(ucNewsFeed2);
            Controls.Add(ucNewsFeed1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(button8);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button button8;
        private MaskedTextBox maskedTextBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private ModeloInsta.UCNewsFeed ucNewsFeed1;
        private ModeloInsta.UCNewsFeed ucNewsFeed2;
        private ModeloInsta.UCNewsFeed ucNewsFeed3;
        private ModeloInsta.UCNewsFeed ucNewsFeed4;
        private ModeloInsta.UCNewsFeed ucNewsFeed5;
        private ModeloInsta.UCNewsFeed ucNewsFeed6;
    }
}
