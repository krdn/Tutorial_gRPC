﻿// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GrpcServerWithAspNet;

var channel = GrpcChannel.ForAddress("https://localhost:7165");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient 김석곤" });
Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();