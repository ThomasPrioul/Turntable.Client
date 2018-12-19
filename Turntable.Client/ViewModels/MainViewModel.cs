namespace Turntable.Client.ViewModels
{
    using System;
    using ReactiveUI;

    class MainViewModel : BaseViewModel, IDisposable
    {
        string connectionSettings;
        bool disposedValue;
        string title;

        public MainViewModel()
            : base(new Connection())
        {
            Title = "Client plaque tournante";
        }

        public string ConnectionSettings { get => connectionSettings; set => this.RaiseAndSetIfChanged(ref connectionSettings, value); }

        public string Title { get => title; set => this.RaiseAndSetIfChanged(ref title, value); }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Connection.Dispose();
                }

                disposedValue = true;
            }
        }
    }
}