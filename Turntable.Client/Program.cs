namespace Turntable.Client
{
    using System.Runtime.InteropServices;
    using Qml.Net;
    using Turntable.Client.ViewModels;

    class Program
    {
        static int Main(string[] args)
        {
            using (var app = new QGuiApplication(args))
            {
                QQmlApplicationEngine.ActivateMVVMBehavior();

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    QQuickStyle.SetStyle("Universal");
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    QQuickStyle.SetStyle("Material");
                using (var engine = new QQmlApplicationEngine())
                {
                    Qml.RegisterType<MainViewModel>("viewModels");
                    engine.Load("Views/main.qml");
                    return app.Exec();
                }
            }
        }
    }
}