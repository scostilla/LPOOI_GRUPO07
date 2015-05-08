using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClasesBase;

namespace Vistas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public static Rol[] roles = new Rol[3];

       
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("select * from Rol", cnn);

            SqlDataReader dr;
            cnn.Open();

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbRol.Items.Add(dr["rolDescripcion"]);
            }
            /*
            Rol oRol1 = roles[0];
            Rol oRol2 = roles[1];
            Rol oRol3 = roles[2];

            Usuario oUsuario1 = new Usuario();
            oUsuario1.UserName = "Luis";
            oUsuario1.Password = "123";
            oUsuario1.Apellido = "Wayar";
            oUsuario1.Nombre = "Luis";
            oUsuario1.RolCodigo = oRol3.RolCodigo;

            Usuario oUsuario2 = new Usuario("user", "user", "Zapata", "Ramon", oRol2.RolCodigo);
            Usuario oUsuario3 = new Usuario("admin", "admin", "Eliza", "Ramirez", oRol1.RolCodigo);
            
            string u = txtUserName.Text;
            string p = txtPassword.Text;

            if (oUsuario1.UserName == u && oUsuario1.Password == p)
            {
                MessageBox.Show("Bienvenido Usuario:" + u);
                //Llamada al formulario principal

                //FrmPrincipal ofrmPrincipal = new FrmPrincipal();
                //ofrmPrincipal.Show();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }*/
        }

        private void btnIngresar_MouseHover(object sender, EventArgs e)
        {
            this.btnIngresar.ForeColor = Color.Blue;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            this.btnIngresar.ForeColor = Color.Black;
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            this.btnSalir.ForeColor = Color.Blue;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.btnSalir.ForeColor = Color.Black;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
