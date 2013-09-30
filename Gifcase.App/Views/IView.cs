using Gifcase.App.ViewModels;

namespace Gifcase.App.Views
{
    public interface IView<TViewModel> where TViewModel: IViewModel
    {
        TViewModel ViewModel { get; set; }
    }
}