using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace comple
{
    public partial class CrearUs : Form
    {
        public CrearUs()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (NombreU.Text == "" || ApellidoU.Text == "" || Genero.Text == "" || Edad.Text == "" || Correo.Text == "" || Contraseña.Text == "")
            {
                MessageBox.Show("Falta Informacion");

            }
            else
            {
                try
                {
                    SqlConnection cn = new SqlConnection(@"Data Source = SPARTAN117\SQLSERVER; Initial Catalog = Meta; Persist Security Info = True; User ID = root2; Password = root2");
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into usuarios(Nombre_Usuario,Apellido_Usuario,Genero,Edad,Correo,contraseña) values(@NU,@AU,@G,@E,@Co,@C)", cn);
                    cmd.Parameters.AddWithValue("@NU", NombreU.Text);
                    cmd.Parameters.AddWithValue("@AU", ApellidoU.Text);
                    cmd.Parameters.AddWithValue("@G", Genero.Text);
                    cmd.Parameters.AddWithValue("@E", (Convert.ToInt32(Edad.Text)));
                    cmd.Parameters.AddWithValue("@Co", Correo.Text);
                    cmd.Parameters.AddWithValue("@C", Contraseña.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario Creado");
                    cn.Close();
                   

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

  }
}

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}