using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Hotel_Rivera.Entidades;
using Hotel_Rivera.Negocios;

namespace Hotel_Rivera.Datos
{
    public class CD_conexion
    {
        private static string database = Path.Combine(Application.StartupPath, "probando_nose.db");
        public SQLiteConnection conexion;

        //La función Path.Combine combina varias partes de una ruta en una sola ruta completa.
        //Application.StartupPath representa la carpeta de inicio de la aplicación,
        //"Databa_HotelRivera.db" es el nombre del archivo de base de datos.

        //variable database contiene la ruta completa del archivo de base de datos SQLite que se utilizará en el código.
        public CD_conexion()
        {
            conexion = new SQLiteConnection("Data Source=" + database);          
        }

        public void conectar()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();                     
        }
        public void desconectar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();                
        }       
    }
}

