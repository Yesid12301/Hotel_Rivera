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
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }


        #region Botones Principales
        private void btnSalir_MouseMove(object sender, MouseEventArgs e)
        {
            btnSalir.BackColor = Color.DarkRed;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Indigo;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.inicio.Show();
        }


        #endregion

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Usuario form = new Usuario();
            form.ShowDialog();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;               
        }     
    }
}

