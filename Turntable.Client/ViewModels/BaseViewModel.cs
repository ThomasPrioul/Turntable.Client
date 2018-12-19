namespace Turntable.Client.ViewModels
{
    using System;
    using ReactiveUI;

    abstract class BaseViewModel : ReactiveObject
    {
        public BaseViewModel(Connection connection)
        {
            Connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        protected Connection Connection { get; }
    }
}