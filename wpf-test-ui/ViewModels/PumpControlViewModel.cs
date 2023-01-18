using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_test_ui.ViewModels
{
    public class PumpControlViewModel : BaseViewModel
    {
        #region Field
        public RelayCommand ShowTaskForPumpCommand { get; set; }
        #endregion

        #region Property
        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public PumpControlViewModel()
        {
            Name = "pump #1";
            ShowTaskForPumpCommand = new RelayCommand(p => ShowTaskForPump());
        }

        #region Property
        public void ShowTaskForPump()
        {

        }
        #endregion



    }
}
