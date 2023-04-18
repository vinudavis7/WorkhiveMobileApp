using CommunityToolkit.Mvvm.ComponentModel;
//using Java.Lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WorkHiveMobileApp.Services;


namespace WorkHiveMobileApp.ViewModel
{
    public partial class JobDetailsViewModel: ObservableObject
    {
        Jobs toDo = new Jobs();
        public Jobs ToDo { get { return toDo; } set => SetProperty(ref toDo, value); }
        public ICommand LoadPostsCommand { get; }
        public string Name1 { get; set; }
        public JobDetailsViewModel()
        {
            LoadPostsCommand = new Command(async () => await LoadPostsAsync());
        }
        
        private async Task LoadPostsAsync()
        {
            RestService service = new RestService();
            ToDo = await service.GetJobDetails(Convert.ToInt32(this.Name1));
        }
    }
}
