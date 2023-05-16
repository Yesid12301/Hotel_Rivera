using Hotel_Rivera.Entidades;
using Hotel_Rivera.Negocios;
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
    public partial class CambioContraseña : Form
    {
        CN_usuario oCN_usuario = new CN_usuario();
        CE_usuario oCE_usuario = new CE_usuario();

        public CambioContraseña()
        {
            InitializeComponent();
        }

        #region Botones principales 


        
        
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void CambioContraseña_Load(object sender, EventArgs e)
        {
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            oCE_usuario.Nombre = "admin";
            oCE_usuario.Contraseña = Contraseña.GetRandomPassword();
            Console.WriteLine("Recuerda que el usuario es:  admin");
            Console.WriteLine("Y su contraseña restablecidad sera:");
            Console.WriteLine(oCE_usuario.Contraseña);
            oCN_usuario.editarUsuario(oCE_usuario);
            //Correo.RecuperarContra(contra);
            this.Close();
        }

    }
    
}
