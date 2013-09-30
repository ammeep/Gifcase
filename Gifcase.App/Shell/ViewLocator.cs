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

        public IView<TViewModel> FindView<TViewModel>(TViewModel viewModel) where TViewModel : IViewModel
        {
            var view =(IView<TViewModel>)_kernel.GetService(typeof(IView<TViewModel>));
            view.ViewModel = viewModel;
            return view;
        }
    }
}