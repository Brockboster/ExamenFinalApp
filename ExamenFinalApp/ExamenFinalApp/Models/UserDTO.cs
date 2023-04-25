using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using System.Threading.Tasks;

namespace ExamenFinalApp.Models
{
    public class UserDTO
    {
        public UserDTO()
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


        public async Task<UserDTO> GetUserData(string username)
        {
            try
            {
                string RouteSufix = string.Format("Users/GetUserData?username={0}", this.NombreUsuario);

                string URL = Services.APIConnection.ProductionURLPrefix + RouteSufix;

                RestClient client = new RestClient(URL);
                Request = new RestRequest(URL, Method.Get);
                Request.AddHeader(Services.APIConnection.ApiKeyName, Services.APIConnection.ApiKeyValue);
                Request.AddHeader(GlobalObjects.contentType, GlobalObjects.minetype);

                RestResponse response = await client.ExecuteAsync(Request);
                HttpStatusCode statusCode = response.StatusCode;
                if (statusCode == HttpStatusCode.OK)
                {
                    var list = JsonConvert.DeserializeObject<List<UserDTO>>(response.Content);

                    var item = list[0];

                    return item;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                string Error = ex.Message;
                throw;
            }

        }
    }
}
