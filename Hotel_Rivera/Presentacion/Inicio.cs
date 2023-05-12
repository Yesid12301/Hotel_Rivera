using Hotel_Rivera.Negocios;
using Hotel_Rivera.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Rivera
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void buscar()
        {
            CN_usuario oCN_usuario = new CN_usuario();
            CE_usuario CE_usuario = new CE_usuario();
            oCN_usuario.buscar();
        }
    }
}
