﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebSocketIo_Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://*:12345")
                .Build();
    }
}