using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenFinalApp.ViewModels;

namespace ExamenFinalApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BienvenidaPage : ContentPage
    {
        UserViewModel viewModel;
        public BienvenidaPage()
        {
            InitializeComponent();
        }

       

        private async void BtnLogin_Clicked_1(object sender, EventArgs e)
        {
            bool R = false;
            if (txtuser.Text != null && !string.IsNullOrEmpty(txtuser.Text.Trim()) &&
                txtcontra.Text != null && !string.IsNullOrEmpty(txtcontra.Text.Trim()))
            {
                try
                {
                    UserDialogs.Instance.ShowLoading("Cheking User Access..");
                    await Task.Delay(2000);
                    

                    string usuario = txtuser.Text.Trim();
                    string contra = txtcontra.Text.Trim();

                    R = await viewModel.UserAccessValidation(usuario, contra);
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    UserDialogs.Instance.HideLoading();
                }

            }
            else
            {
                await DisplayAlert("Validacion error", "Usuario y contraseña son requeridas", "ok");
                return;
            }
            if (R)
            {
                GlobalObjects.local = await viewModel.GetUserData(txtuser.Text.Trim());
                await Navigation.PushAsync(new PreguntaPage());

                return;
            }
            else
            {
                await DisplayAlert("Validacion failed", "acceso restringido", "ok");
                return;
            }

        }
    }
}