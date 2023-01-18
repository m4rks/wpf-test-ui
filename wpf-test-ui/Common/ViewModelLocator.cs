namespace wpf_test_ui.ViewModels
{
    public class ViewModelLocator
    {
        //public PumpControlViewModel PumpControlViewModel => new PumpControlViewModel(App.Navigation, new MockCustomersService());
        public TasksViewModel TasksViewModel => new TasksViewModel();
    }
}
