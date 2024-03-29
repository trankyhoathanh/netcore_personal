﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Google.Protobuf;

namespace MicroService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseUrls("http://*:62100")
                   .UseStartup<Startup>();
    }
}
