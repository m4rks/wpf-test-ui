

using wpf_test_ui.ViewModels;

namespace wpf_test_ui.Common
{
    public class ViewModelLocator
    {
        //public PumpControlViewModel PumpControlViewModel => new PumpControlViewModel(App.Navigation, new MockCustomersService());
        public  TasksViewModel TasksViewModel => new TasksViewModel();
    }
}
