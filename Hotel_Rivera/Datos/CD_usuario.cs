using Hotel_Rivera.Entidades;
using Hotel_Rivera.Negocios;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Rivera.Datos
{
    public class CD_usuario
    {
        CD_conexion oCD_conexion = new CD_conexion();
        public bool buscarUsuario(CE_usuario oCE_usuario)
        {
            oCD_conexion.conectar();
            string query = "SELECT * FROM Usuario WHERE Nombre = @Nombre AND Contrasena = @Contrasena";
            using (SQLiteCommand comando = new SQLiteCommand(query, oCD_conexion.conexion))
            {
                comando.Parameters.AddWithValue("@Nombre", oCE_usuario.Nombre);
                comando.Parameters.AddWithValue("@Contrasena", oCE_usuario.Contraseña);
                using (SQLiteDataReader leer = comando.ExecuteReader())
                {
                    if (leer.Read())
                    {
                        oCD_conexion.desconectar();
                        return true;
                    }
                    else
                    {
                        oCD_conexion.desconectar();
                        return false;
                    }
                }
            }
            
        }
        public void editarUsuario(CE_usuario oCE_usuario)
        {
            oCD_conexion.conectar();
            string query = "UPDATE Usuario SET Contrasena = @Contrasena WHERE Nombre = @Nombre";
            using (SQLiteCommand comando = new SQLiteCommand(query, oCD_conexion.conexion))
            {
                comando.Parameters.AddWithValue("@Nombre", oCE_usuario.Nombre);
                comando.Parameters.AddWithValue("@Contrasena", oCE_usuario.Contraseña);
                comando.ExecuteNonQuery();
            }
            oCD_conexion.desconectar();
        }
    }
}
