using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Gifcase.App.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        private bool _disposed; 

        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] String propertyName = null)
        {
            if (Equals(storage, value)) return false;
            storage = value;
            if (propertyName != null) OnPropertyChanged(propertyName);
            return true;
        }
  
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    CleanUp();
                }
                _disposed = true;
            } 
        }

        protected virtual void CleanUp()
        {
            //nothing
        }
    }
}