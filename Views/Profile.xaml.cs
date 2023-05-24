namespace Restoran_Adisyon.Views;
using Restoran_Adisyon.ViewModel;
public partial class Profile : ContentPage
{
    public Profile()
    {
        InitializeComponent();
        BindingContext = new ProfileViewModel();
    }
}