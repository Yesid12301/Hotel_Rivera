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

namespace Hotel_Rivera.Presentacion
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        CN_usuario oCN_usuario = new CN_usuario();
        CE_usuario oCE_usuario = new CE_usuario();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNueva.Text == txtConfirmar.Text)
            {
                oCE_usuario.Nombre = "admin";
                oCE_usuario.Contraseña = txtContraseñaActual.Text.Trim();
                if (oCN_usuario.buscarUsuario(oCE_usuario))
                {
                    oCE_usuario.Contraseña = txtNueva.Text.Trim(); ;
                    oCN_usuario.editarUsuario(oCE_usuario);
                     this.Close();


                    //Opcion 1

                    Opciones opciones = Application.OpenForms.OfType<Opciones>().FirstOrDefault();
                    opciones?.Close();
                    Program.inicio.Show();

                    //Opcion 2
                    //Opciones opciones = Application.OpenForms["Opciones"] as Opciones;
                    //opciones?.Close();
                    //Program.inicio.Show();
                }
                else
                {
                    lblerror.Visible = true;
                }
            }
            else
            {
                lblVacios.Visible = true;
            }
        }

        #region Botones Principales
        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.SteelBlue;
        }

        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.DarkRed;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtContraseñaActual_Click(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            lblVacios.Visible = false;
        }

        private void txtNueva_Click(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            lblVacios.Visible = false;
        }

        private void txtConfirmar_Click(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            lblVacios.Visible = false;
        }
        private void ptbOcultar_Click(object sender, EventArgs e)
        {
          
            txtNueva.UseSystemPasswordChar = true;
            txtConfirmar.UseSystemPasswordChar = true;
            ptbOcultar.Visible = false;
            ptbMostrar.Visible = true;

        }

        private void ptbMostrar_Click(object sender, EventArgs e)
        {
            txtNueva.UseSystemPasswordChar = false;
            txtConfirmar.UseSystemPasswordChar = false;
            ptbMostrar.Visible = false;
            ptbOcultar.Visible = true;
        }
        private void ptbMostrar1_Click(object sender, EventArgs e)
        {
            txtContraseñaActual.UseSystemPasswordChar = false;
            ptbMostrar1.Visible = false;
            ptbOcultar1.Visible = true;
        }

        private void ptbOcultar1_Click(object sender, EventArgs e)
        {
            txtContraseñaActual.UseSystemPasswordChar = true;
            ptbOcultar1.Visible = false;
            ptbMostrar1.Visible = true;
        }
        #endregion
         // para darle bordes al formulario ovalados 
        private void Usuario_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        


        //

    } 
}