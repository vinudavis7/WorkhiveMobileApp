using System.Runtime.Intrinsics.Arm;
using WorkHiveMobileApp.ViewModel;

namespace WorkHiveMobileApp;
[QueryProperty("Name1", "Name1")]
public partial class JobDetails : ContentPage
{
    public string Name1 { get; set; }
    JobDetailsViewModel viewModel;
    public JobDetails(JobDetailsViewModel jdm)
    {
        InitializeComponent();
        viewModel = jdm;
    }
    protected override void OnAppearing( )
    {
        base.OnAppearing();
        int.TryParse(Name1, out var result);
        viewModel.Name1 = Name1;
        BindingContext = viewModel;
        viewModel.LoadPostsCommand.Execute(null);
    }

}