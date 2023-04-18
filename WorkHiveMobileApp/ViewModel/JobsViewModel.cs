//using AndroidX.Core.Util;
//using AndroidX.Lifecycle;
//using Android.Webkit;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorkHiveMobileApp.Services;

namespace WorkHiveMobileApp.ViewModel
{

    public partial class JobsViewModel : ObservableObject
    {


        List<Jobs> toDo = new List<Jobs>();
        public List<Jobs> ToDo { get { return toDo; } set => SetProperty(ref toDo, value); }
        public ICommand LoadPostsCommand { get; }
        public JobsViewModel()
        {

            LoadPostsCommand = new Command(async () => await LoadPostsAsync());
        }

        private async Task LoadPostsAsync()
        {
            RestService service = new RestService();
            ToDo = await service.GetJobList();
          
        }
        [RelayCommand]
        async void Add()
        {
            if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
            {
                

            }
            else
            {
                await Shell.Current.DisplayAlert("Warning", "No Internet", "ok");
            }
        }
        [RelayCommand]
        async void Tap(int id)
        {
              await Shell.Current.GoToAsync($"JobDetails?Name1={id.ToString()}");

        }
    }
}
