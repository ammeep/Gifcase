using System.Windows;
using Gifcase.App.Shell;
using Gifcase.App.Views;

namespace Gifcase.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IShell
    {
        public Bootstrapper Bootstrapper { get; protected set; }

        public MainWindow()
        {
            InitializeComponent();
            Bootstrapper = new Bootstrapper(this);
            Bootstrapper.Start();
        }

        public void ShowInMainRegion(IView view)
        {
            MainRegion.Content = view;
        }
    }
}
