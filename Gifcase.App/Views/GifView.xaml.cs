using System.Windows.Controls;
using Gifcase.App.ViewModels;

namespace Gifcase.App.Views
{
    /// <summary>
    /// Interaction logic for GifView.xaml
    /// </summary>
    public partial class GifView : UserControl, IView<IGifImageViewModel>
    {
        private IGifImageViewModel _viewModel;

        public GifView()
        {
            InitializeComponent();
        }

        public IGifImageViewModel ViewModel
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
