using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class SocketExample
    {

        public static void Connect3()
        {
            TcpClient clientSocket = new TcpClient();
            Console.WriteLine("Client Started");
            clientSocket.Connect("160.43.94.168", 23643);
            //clientSocket.Connect(IPAddress.Parse("160.79.83.100"), 22);
            Console.WriteLine("Client Socket Program - Server Connected ...");
           
           

            //byte[] bytes = new byte[1024];
            ////IPHostEntry host = Dns.GetHostEntry("160.43.94.168");
            //IPAddress ipAddress = IPAddress.Parse("160.79.83.100");
            //IPEndPoint remoteEP = new IPEndPoint( ipAddress, 520);

            //// Create a TCP/IP  socket.    
            //Socket sender = new Socket(ipAddress.AddressFamily,
            //    SocketType.Stream, ProtocolType.Tcp);

            //// Connect the socket to the remote endpoint. Catch any errors.    
            //try
            //{
            //    // Connect to Remote EndPoint  
            //    sender.Connect(remoteEP);

            //    Console.WriteLine("Socket connected to {0}",
            //        sender.RemoteEndPoint.ToString());

            //    // Encode the data string into a byte array.    
            //    byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

            //    // Send the data through the socket.    
            //    int bytesSent = sender.Send(msg);

            //    // Receive the response from the remote device.    
            //    int bytesRec = sender.Receive(bytes);
            //    Console.WriteLine("Echoed test = {0}",
            //        Encoding.ASCII.GetString(bytes, 0, bytesRec));

            //    // Release the socket.    
            //    sender.Shutdown(SocketShutdown.Both);
            //    sender.Close();

            //}
            //catch (ArgumentNullException ane)
            //{
            //    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            //}
            //catch (SocketException se)
            //{
            //    Console.WriteLine("SocketException : {0}", se.ToString());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Unexpected exception : {0}", e.ToString());
            //}

        }

        static void Main()
        {
            SocketExample.Connect3();
        }

    }

}
