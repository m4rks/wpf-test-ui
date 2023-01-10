using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_test_ui.ViewModels
{
    public class LoginViewModel : Base
    {
        #region Property
        private string _inputName;
        public string InputName
        {
            get { return _inputName; }
            set { 
                _inputName = value;
                OnPropertyChanged();
            }
        }

        private string _RequestedUserAndPassword;

        public string RequestedUserAndPasswordLabel
        {
            get { return _RequestedUserAndPassword; }
            set {
                _RequestedUserAndPassword = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Command

        public RelayCommand LoginButtonCommand { get; set; }
        public RelayCommand ExecuteCommand { get; set; }

        #endregion

        private string Name = string.Empty;

        public LoginViewModel()
        {
            InputName = "";
            RequestedUserAndPasswordLabel = "UserName?";

            LoginButtonCommand = new RelayCommand(p => EnterButton());
            ExecuteCommand = new RelayCommand(p => EnterButton());

        }

        private void EnterButton()
        {
            if (!string.IsNullOrWhiteSpace(InputName) && Name == string.Empty)
            {
                RequestedUserAndPasswordLabel = "Password";
                Name = InputName;
                InputName = "";
            }

            if (!string.IsNullOrWhiteSpace(InputName) && Name != string.Empty)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }



        }



    }

    
}
