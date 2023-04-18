//using AndroidX.Lifecycle;
//using AndroidX.Lifecycle;
using WorkHiveMobileApp.ViewModel;

namespace WorkHiveMobileApp;

public partial class MainPage : ContentPage
{
	int count = 0;

    //public MainPage()
    //{
    //    InitializeComponent();

    //}
    public JobsViewModel vm;
    public MainPage(JobsViewModel jm)
	{
		InitializeComponent();
        BindingContext = jm;
        vm = jm;
        vm.LoadPostsCommand.Execute(null);
    }


}

