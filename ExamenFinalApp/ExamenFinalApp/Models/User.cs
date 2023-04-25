using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ExamenFinalApp.Models
{

    public class User
    {
        public User()
        {

        }

        public RestRequest Request { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = null;

        public string Apellido { get; set; } = null;
        public string NumeroTelefono { get; set; }
        public string Contrasennia { get; set; } = null;

        public string DescripcionTrabajo { get; set; }
        public int StatusUsuarioId { get; set; }
        public int IdPais { get; set; }
        public int RoleId { get; set; }


        public string UserRole { get; set; } = null;
        public string UserStatus { get; set; } = null;













    }}





