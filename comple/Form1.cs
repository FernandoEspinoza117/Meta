using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace comple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            SqlConnection cn = new SqlConnection(@"Data Source = SPARTAN117\SQLSERVER; Initial Catalog = Meta; Persist Security Info = True; User ID = root2; Password = root2");
            cn.Open();
            SqlCommand cm = new SqlCommand("select usuario, contraseña from usuarios where correo='" + txtusuario.Text + "'and contraseña='" + txtcontra.Text + "'", cn);
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Bienvenido " + txtusuario.Text);
                Facebook fr = new Facebook();
                fr.ShowDialog();
            }
            else
                MessageBox.Show("No se encontro el usuario " + txtusuario.Text+ " revise si el usuario o la contraseña son correctos.");
        }

        private void ckmostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckmostrar.Checked)
            {
                txtcontra.PasswordChar = '*';
            }
            else
            {
                txtcontra.PasswordChar = '\0';
            }
        }
    }
}
