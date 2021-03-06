﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseSetting("https_port", "443")
                .UseStartup<Startup>()
                .Build();
        }
    }
}