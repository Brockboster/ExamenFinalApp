using System.ComponentModel;
using ExamenFinalApp.ViewModels;
using Xamarin.Forms;

namespace ExamenFinalApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}