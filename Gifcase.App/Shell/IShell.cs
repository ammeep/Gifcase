using Gifcase.App.ViewModels;
using Gifcase.App.Views;

namespace Gifcase.App.Shell
{
    public interface IShell
    {
        void ShowInMainRegion<TViewModel>(IView<TViewModel> view) where TViewModel : IViewModel;
    }
}