using Task_Planner.MVVM.ViewModels;

namespace Task_Planner.MVVM.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}