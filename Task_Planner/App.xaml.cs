using Task_Planner.MVVM.Views;

namespace Task_Planner
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
        }
    }
}
