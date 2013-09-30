using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Gifcase.App.Models;

namespace Gifcase.App.ViewModels
{
    public class GifImageImageViewModel : ViewModel, IGifImageViewModel 
    {
        private BitmapImage _image;
        private BitmapImage _fallbackImage;
        private BitmapImage _loadingImage;
        private Visibility _imageVisibility;
        private Visibility _fallbackImageVisibility;
        private Visibility _loadingImageVisibility;

        public GifImageImageViewModel(Gif gif)
        {
            LoadingImage = new BitmapImage(new Uri("pack://application:,,,/Images/loading.gif"));
            FallbackImage = new BitmapImage(new Uri("pack://application:,,,/Images/error.png"));
            Image = new BitmapImage(gif.ImageSource);
            Image.DownloadProgress += OnDownloadProgress;
            Image.DownloadCompleted += OnDownloadSuccessful;
            Image.DownloadFailed += OnDownloadFailed;
        }

        public BitmapImage Image
        {
            get { return _image; }
            private set
            {
                SetProperty(ref _image, value);
            }
        }

        public BitmapImage FallbackImage
        {
            get { return _fallbackImage; }
            private set
            {
                SetProperty(ref _fallbackImage, value);
            }
        }

        public BitmapImage LoadingImage
        {
            get { return _loadingImage; }
            private set
            {
                SetProperty(ref _loadingImage, value);
            }
        }

        public Visibility ImageVisibility
        {
            get { return _imageVisibility; }
            private set
            {
                SetProperty(ref _imageVisibility, value);
            }
        }

        public Visibility LoadingImageVisibility
        {
            get { return _loadingImageVisibility; }
            private set
            {
                SetProperty(ref _loadingImageVisibility, value);
            }
        }

        public Visibility FallbackImageVisibility
        {
            get { return _fallbackImageVisibility; }
            private set
            {
                SetProperty(ref _fallbackImageVisibility, value);
            }
        }


        private void OnDownloadProgress(object sender, DownloadProgressEventArgs e)
        {
            LoadingImageVisibility = Visibility.Visible;
            ImageVisibility = Visibility.Hidden;
            FallbackImageVisibility = Visibility.Hidden;
        }

        private void OnDownloadSuccessful(object sender, EventArgs e)
        {
            LoadingImageVisibility = Visibility.Hidden;
            ImageVisibility = Visibility.Visible;
            FallbackImageVisibility = Visibility.Hidden;
        }

        private void OnDownloadFailed(object sender, ExceptionEventArgs e)
        {
            LoadingImageVisibility = Visibility.Hidden;
            ImageVisibility = Visibility.Hidden;
            FallbackImageVisibility = Visibility.Visible;
        }

        protected override void CleanUp()
        {
            Image.DownloadProgress -= OnDownloadProgress;
            Image.DownloadCompleted -= OnDownloadSuccessful;
            Image.DownloadFailed -= OnDownloadFailed;
        }
    }
}