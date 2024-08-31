using System.Net;
using System.Net.Sockets;
using System.Text;

// You can use print statements as follows for debugging, they'll be visible when running tests.
Console.WriteLine("Logs from your program will appear here!");

// Uncomment this block to pass the first stage
TcpListener server = new TcpListener(IPAddress.Any, 6379);
server.Start();
var clientSocket = server.AcceptSocket(); // wait for client
await clientSocket.SendAsync(Encoding.UTF8.GetBytes("+PONG\r\n"));

// using System;
// using System.Net;
// using System.Net.Sockets;
// using System.Text;

// namespace codecrafters_redis {
//   class TcpServer {
//     private readonly TcpListener _server;
//     public TcpServer(IPAddress ipAddress, int port) {
//       _server = new TcpListener(ipAddress, port);
//     }
//     public void Start() {
//       _server.Start();
//       Console.WriteLine("Server started, waiting for a client to connect...");
//       // Wait for a client to connect
//       Socket clientSocket = _server.AcceptSocket();
//       Console.WriteLine("Client connected!");
//       // Here you can add code to handle the connected client
//       clientSocket.SendAsync(Encoding.UTF8.GetBytes("+PONG\r\n"));
//     }
//     public void Stop() {
//       _server.Stop();
//       Console.WriteLine("Server stopped.");
//     }
//     public void Stop() { _server.Stop(); }
//   }
//   class Program {
//     static void Main(string[] args) {
//       // You can use print statements as follows for debugging, they'll be
//       // visible when running tests.
//       Console.WriteLine("Logs from your program will appear here!");
//       TcpServer server = new TcpServer(IPAddress.Any, 6379);
//       server.Start();
//       // Optionally stop the server after some time or based on some condition
//        server.Stop();
//     }
//   }
// }