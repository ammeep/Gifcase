using System.Windows.Media.Imaging;
using Gifcase.App.Models;

namespace Gifcase.App.ViewModels
{
    public class GifViewModel : ViewModel, IGifViewModel 
    {
        private string _name;
        private BitmapImage _image;

        public GifViewModel(Gif gif)
        {
            Name = gif.Name;
            Image = new BitmapImage(gif.ImageSource);
        }

        public string Name
        {
            get { return _name; }
            private set
            {
                SetProperty(ref _name, value);
            }
        }

        public BitmapImage Image
        {
            get { return _image; }
            private set
            {
                SetProperty(ref _image, value);
            }
        }
    }

    public interface IGifViewModel : IViewModel
    {
        string Name { get; }
        BitmapImage Image { get; }
    }
}