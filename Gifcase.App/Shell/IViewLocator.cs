using Gifcase.App.ViewModels;
using Gifcase.App.Views;

namespace Gifcase.App.Shell
{
    public interface IViewLocator
    {
        IView FindView<T>(T viewModel) where T : IViewModel;
    }
}