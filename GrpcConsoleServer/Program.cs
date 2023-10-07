// See https://aka.ms/new-console-template for more information
using Grpc.Core;
using GrpcConsoleServer;
using Helloworld;

const int Port = 30051;
Server server = new Server
{
    Services = { Greeter.BindService(new GreeterServer()) },
    Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
};
server.Start();

Console.WriteLine("Greeter server listening on port " + Port);
Console.WriteLine("Press any key to stop the server...");
Console.ReadKey();

server.ShutdownAsync().Wait();