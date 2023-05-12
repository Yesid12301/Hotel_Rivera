using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Rivera.Datos;
using Hotel_Rivera.Entidades;

namespace Hotel_Rivera.Negocios
{
    public class CN_usuario
    {
        public void buscar()
        {
            CD_usuarios CD_usuarios = new CD_usuarios();
            CE_usuario CE_usuario = new CE_usuario();
            CD_usuarios.buscar();
        }
    }
}
