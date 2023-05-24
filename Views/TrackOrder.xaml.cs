namespace Restoran_Adisyon.Views;

using Restoran_Adisyon.ViewModel;
using static Restoran_Adisyon.Model.TrackOrderModel;


public partial class TrackOrder : ContentPage
{
    public TrackOrder(Track data)
    {
        InitializeComponent();
        BindingContext = new TrackOrderViewModel(data);
    }
}