using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;


namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            AsynchronousSocketListener server = new AsynchronousSocketListener();
            server.StartListening();

        }
    }
}
