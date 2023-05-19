
using Hotel_Rivera.Datos;
using Hotel_Rivera.Entidades;
using Hotel_Rivera.Negocios;
using Hotel_Rivera.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Hotel_Rivera
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        CN_usuario oCN_usuario = new CN_usuario();
        CE_usuario oCE_usuario = new CE_usuario();
      


        #region Botones principales
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.SteelBlue;
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.DarkRed;
        }

        private void txtUusario_Click(object sender, EventArgs e)
        {
            lblerror.Visible = false;
        }

        private void ptbMostrar_Click(object sender, EventArgs e)//que muestre la contraseña
        {
            txtContrasena.UseSystemPasswordChar = false;
            ptbMostrar.Visible = false;
            ptbOcultar.Visible = true;
        }

        private void txtContrasena_Click(object sender, EventArgs e)
        {
            lblerror.Visible = false;
        }
        private void ptbOcultar_Click(object sender, EventArgs e)// lo contrario
        {
            txtContrasena.UseSystemPasswordChar = true;
            ptbMostrar.Visible = true;
            ptbOcultar.Visible = false;
        }
       
        #endregion


        private void Ingresar()
        {
            oCE_usuario.Nombre = txtUusario.Text;
            oCE_usuario.Contraseña = txtContrasena.Text;
            if (oCN_usuario.buscarUsuario(oCE_usuario))
            {
                txtUusario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                Program.inicio.Hide();
                Opciones menu = new Opciones();
                menu.Show();
            }
            else
            {
                lblerror.Visible = true;
            }
        }

        private void lblOlvidar_Click(object sender, EventArgs e)
        {
            CambioContraseña contrasena = new CambioContraseña();
            contrasena.Show();
            lblerror.Visible = false;
                       
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = true;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //txtContrasena.Size = new Size(230,30);
            //txtContrasena.BorderStyle = BorderStyle.None;
            //txtContrasena.BackColor = Color.LightGray;          
            
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void btnIngresarNegro_MouseLeave(object sender, EventArgs e)
        {
            btnIngresarNegro.BringToFront();
        }

        private void btnIngresarNegro_MouseMove(object sender, MouseEventArgs e)
        {
            btnIngresarBlanco.BringToFront();
        }

        private void btnIngresarNegro_Click(object sender, EventArgs e)
        {
            Ingresar();            
        }
    }
}