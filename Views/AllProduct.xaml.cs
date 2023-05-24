namespace Restoran_Adisyon.Views;
using Restoran_Adisyon.ViewModel;


public partial class AllProduct : ContentPage
{
    public AllProduct()
    {
        InitializeComponent();
        BindingContext = new AllProductViewModel();
    }
}