using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UC_Analyze
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        AnalyzeViewModel _vm;
        public UserControl1()
        {
            InitializeComponent();

            //this.DataContext = new AnalyzeViewModel();
//            _vm = (AnalyzeViewModel)this.DataContext;
        }


        #region Text Property
        public String Text
        {
            get { return (String)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(String), typeof(UserControl1),
                new FrameworkPropertyMetadata(null)
                {
                //  It's read-write, so make it bind both ways by default
                BindsTwoWayByDefault = true
                });
        #endregion Text Property

        #region DisplayText Property
        public String DisplayText
        {
            get { return (String)GetValue(DisplayTextProperty); }
            set { SetValue(DisplayTextProperty, value); }
        }

        public static readonly DependencyProperty DisplayTextProperty =
            DependencyProperty.Register(nameof(DisplayText), typeof(String), typeof(UserControl1),
                new PropertyMetadata(null));
        #endregion DisplayText Property
    }
}