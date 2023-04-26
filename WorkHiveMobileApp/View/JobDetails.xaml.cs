using System.Runtime.Intrinsics.Arm;
using WorkHiveMobileApp.ViewModel;

namespace WorkHiveMobileApp;
[QueryProperty("Id", "Id")] //to receive Job Id parameter from Main page on tap
public partial class JobDetails : ContentPage
{
    public string Id { get; set; }
    JobDetailsViewModel viewModel;
    public JobDetails(JobDetailsViewModel detailViewModel)
    {
        InitializeComponent();
        viewModel = detailViewModel; //binding viewmodel
    }
    protected override void OnAppearing( )
    {
        base.OnAppearing();
        int.TryParse(Id, out var result);
        viewModel.Id = Id; //setting the Job id from main page 
        BindingContext = viewModel;
        viewModel.LoadJobsCommand.Execute(null); //initiating loading of data
    }

}