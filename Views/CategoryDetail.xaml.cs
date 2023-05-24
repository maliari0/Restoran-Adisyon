namespace Restoran_Adisyon.Views;
using Restoran_Adisyon.Model;
using Restoran_Adisyon.ViewModel;

public partial class CategoryDetail : ContentPage
{
    public CategoryDetail(CategoriesModel data)
    {
        InitializeComponent();
        BindingContext = new CategoryDetailViewModel(data);
    }
}