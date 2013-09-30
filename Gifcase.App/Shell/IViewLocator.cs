using Gifcase.App.ViewModels;
using Gifcase.App.Views;

namespace Gifcase.App.Shell
{
    public interface IViewLocator
    {
        IView<TViewModel> FindView<TViewModel>(TViewModel viewModel) where TViewModel : IViewModel;
    }
}