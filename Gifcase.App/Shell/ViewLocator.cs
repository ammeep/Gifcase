using Gifcase.App.ViewModels;
using Gifcase.App.Views;
using Ninject;

namespace Gifcase.App.Shell
{
    public class ViewLocator : IViewLocator
    {
        private readonly IKernel _kernel;

        public ViewLocator(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IView FindView<T>(T viewModel) where T : IViewModel
        {
            var view = (IView)_kernel.GetService(typeof(IView));
            view.DataContext = viewModel;
            return view;
        }
    }
}