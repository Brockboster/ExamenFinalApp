using System;
using System.Collections.Generic;
using System.Text;
using ExamenFinalApp.Models;
using System.Threading.Tasks;
using ExamenFinalApp.ViewModels;
 

namespace ExamenFinalApp.ViewModels
{

    public class UserViewModel : BaseViewModel
    {
        public UserRole MyUserRole  { get; set; }
        public UserStatus MyUserStatus { get; set; }

        public User MyUser { get; set; }

        public UserDTO MyUserDTO { get; set; }

     

        public UserViewModel()
        {
            MyUserRole = new UserRole();
            MyUserStatus = new UserStatus();
            MyUserDTO = new UserDTO();
            
        }
        public async Task<UserDTO> GetData(string pUsername)
        {
            if (IsBusy) return null;
            IsBusy = true;
            try
            {
                UserDTO user = new UserDTO();
                user = await MyUserDTO.GetData(pUsername);

                if (user == null)
                {
                    return null;
                }
                return user;

            }
            catch (Exception)
            {
                return null;
                throw;
            }
            finally { IsBusy = false; }
        }
        

    }
}
