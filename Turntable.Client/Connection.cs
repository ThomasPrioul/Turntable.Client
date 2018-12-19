namespace Turntable.Client
{
    using System;
    using System.Collections.Generic;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;

    class Connection : IDisposable
    {
        TcpClient client;
        bool disposedValue;

        public async Task Connect(string hostname, ushort port)
        {
            if (!(client is null)) throw new InvalidOperationException();

            try
            {
                client = new TcpClient();
                await client.ConnectAsync(hostname, port);
            }
            catch (Exception)
            {
                client?.Dispose();
                client = null;
                throw;
            }
        }

        public void Disconnect()
        {
            if (client is null) throw new InvalidOperationException();

            client.Dispose();
            client = null;
        }

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
                    client?.Dispose();
                }

                disposedValue = true;
            }
        }
    }
}