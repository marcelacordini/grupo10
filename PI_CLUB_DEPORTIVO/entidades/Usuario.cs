using PI_CLUB_DEPORTIVO.datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_CLUB_DEPORTIVO.entidades
{
    internal class Usuario
    {
        // Atributos
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rol { get; set; }

        // Constructor
        public Usuario(int idUsuario, string username, string password, string rol)
        {
            IdUsuario = idUsuario;
            Username = username;
            Password = password;
            Rol = rol;
        }
    }
}
