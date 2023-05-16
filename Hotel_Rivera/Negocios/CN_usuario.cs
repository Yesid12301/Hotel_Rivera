using Hotel_Rivera.Datos;
using Hotel_Rivera.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Rivera.Negocios
{
    public class CN_usuario
    {      
        CD_usuario oCD_usuario = new CD_usuario();
        public bool buscarUsuario(CE_usuario oCE_usuario)
        {
            oCE_usuario.Contraseña = Contraseña.Encriptacion(oCE_usuario.Contraseña);
            return oCD_usuario.buscarUsuario(oCE_usuario);
        }
        public void editarUsuario(CE_usuario oCE_usuario)
        {
            oCE_usuario.Contraseña = Contraseña.Encriptacion(oCE_usuario.Contraseña);
            oCD_usuario.editarUsuario(oCE_usuario);
        }
    }
}
