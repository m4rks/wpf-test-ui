using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_test_ui.UserControls;

namespace wpf_test_ui.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public RelayCommand TaskControlCommand { get; set; }
        public RelayCommand PumpControlCommand { get; set; }

        private object currentView;
        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        private object displayText;
        public object DisplayText
        {
            get { return displayText; }
            set
            {
                displayText = value;
                OnPropertyChanged();
            }
        }

        private object text;
        public object Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }

        private string _mfRepo = "";
        public ShellViewModel()
        {

            PumpControlCommand = new RelayCommand(p => EnterButton());
            TaskControlCommand = new RelayCommand(p => EnterButton2());
            if (1 == 1)
            {
                //Login login = new LoginViewModel(_mfRepo); //_mfRepo
                PumpControlViewModel pumpControl = new PumpControlViewModel();
                CurrentView = pumpControl;
            }
            else
            {
                TaskControlUserControl taskControlUserControl = new TaskControlUserControl();
                CurrentView = taskControlUserControl;
            }
        }

        public void EnterButton()
        {
            PumpControlViewModel pumpControl = new PumpControlViewModel();
            CurrentView = pumpControl;
        }

        public void EnterButton2()
        {
            TaskControlUserControl taskControl = new TaskControlUserControl();
            CurrentView = taskControl;
        }

    }
}
