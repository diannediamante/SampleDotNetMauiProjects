using SmplToDoApplication.ViewModel;

namespace SmplToDoApplication;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}