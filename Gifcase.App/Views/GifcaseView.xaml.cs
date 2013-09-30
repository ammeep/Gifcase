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
using Gifcase.App.ViewModels;

namespace Gifcase.App.Views
{
    /// <summary>
    /// Interaction logic for GifcaseView.xaml
    /// </summary>
    public partial class GifcaseView : UserControl, IView<IGifcaseViewModel>
    {
        private IGifcaseViewModel _viewModel;

        public GifcaseView()
        {
            InitializeComponent();
        }

        public IGifcaseViewModel ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                DataContext = value;
            }
        }
    }
}
