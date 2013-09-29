using System;
using Gifcase.App.Models;
using Gifcase.App.Shell;
using Gifcase.App.ViewModels;
using Gifcase.App.Views;
using Ninject;
using Ninject.Modules;

namespace Gifcase.App
{
    public class Bootstrapper 
    {
        private readonly IShell _shell;

        public Bootstrapper(IShell shell)
        {
            _shell = shell;
        }

        public void Start()
        {
            var root = new CompositionRoot();
            root.Configure(_shell);
            var viewLocator = root.Resolve<IViewLocator>();
            var shell = root.Resolve<IShell>();
            var gif = new Gif
            {
                ImageSource =
                    new Uri("http://www.lepoissonrouge.com/wp-content/uploads/2013/07/Lorde_PhotobyCharlesHowells_2.jpg")
            };
            IView view = viewLocator.FindView<IGifViewModel>(new GifViewModel(gif));
            shell.ShowInMainRegion(view);
        }

        public void Stop()
        {
            
        }
    }

    public class CompositionRoot
    {
        private StandardKernel _kernel;

        public void Configure(IShell shell)
        {
            _kernel = new StandardKernel(new GifModule());
            _kernel.Bind<IShell>().ToConstant(shell);
        }

        private class GifModule : NinjectModule
        {
            public override void Load()
            {
                Bind<IViewLocator>().To<ViewLocator>();
                Bind<IView>().To<GifView>();
            }
        }

        public T Resolve<T>()
        {
            return _kernel.Get<T>();
        }

    }


}
