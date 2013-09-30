
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Gifcase.App.Models;

namespace Gifcase.App.ViewModels
{
    public class GifcaseViewModel : ViewModel, IGifcaseViewModel
    {
        private ObservableCollection<GifImageViewModel> _allGifs;

        public GifcaseViewModel(IEnumerable<Gif> gifs)
        {
            AllGifs = new ObservableCollection<GifImageViewModel>(gifs.Select(gif => new GifImageViewModel(gif)));
        }

        public ObservableCollection<GifImageViewModel> AllGifs
        {
            get { return _allGifs; }
            set { SetProperty(ref _allGifs, value); }
        }
    }

    public interface IGifcaseViewModel : IViewModel
    {
        ObservableCollection<GifImageViewModel> AllGifs { get; set; }
    }

    public class GifcaseAppViewModel
    {
        
    }
}