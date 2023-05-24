namespace Restoran_Adisyon.Views;
using Restoran_Adisyon.ViewModel;


public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        BindingContext = new HomePageViewModel();
    }
}