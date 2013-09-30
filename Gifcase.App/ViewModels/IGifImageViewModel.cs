using System.Windows;
using System.Windows.Media.Imaging;

namespace Gifcase.App.ViewModels
{
    public interface IGifImageViewModel : IViewModel
    {
        BitmapImage FallbackImage { get; }
        BitmapImage LoadingImage { get; }
        Visibility ImageVisibility { get; }
        Visibility LoadingImageVisibility { get; }
        Visibility FallbackImageVisibility { get; }
    }
}