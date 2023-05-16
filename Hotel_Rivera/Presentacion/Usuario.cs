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
                oCE_usuario.Contraseña = txtContraseñaActual.Text;
                if (oCN_usuario.buscarUsuario(oCE_usuario))
                {
                    oCE_usuario.Contraseña = txtNueva.Text;
                    oCN_usuario.editarUsuario(oCE_usuario);
                    MessageBox.Show("Contraseña Modificada");
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
                    Validacion validacion = new Validacion();
                    validacion.Show();
                }
            }
            else
            {
                Validacion validacion = new Validacion();
                validacion.Show();
            }
        }

        #region Botones
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