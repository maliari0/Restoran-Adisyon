namespace Restoran_Adisyon.Views;
using Restoran_Adisyon.ViewModel;
public partial class OrderDetails : ContentPage
{
    public OrderDetails()
    {
        InitializeComponent();
        BindingContext = new OrderDetailsViewModel();
    }
}