using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server
{
    public class StateObject
    {
        public Socket workSocket = null; //client socket
        public const int bufferSize = 1024;
        public byte[] buffer = new byte[bufferSize];
        public StringBuilder stringBuilder = new StringBuilder();
    }
}
