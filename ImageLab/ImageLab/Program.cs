using ImageLab.Services;
using ImageLab.Services.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Runtime.CompilerServices;

namespace ImageLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
           //.AddLogging()
           .AddSingleton<IReadImageservice, ReadImageService>()
           //.AddSingleton<IBarService, BarService>()
           .BuildServiceProvider();

            var _readImageService = serviceProvider.GetService<IReadImageservice>();

            Console.WriteLine("Write name of image");
            string name = Console.ReadLine();
            Console.WriteLine("Write format type");
            string format = Console.ReadLine();

            _readImageService.GetImage(name, format);
            Console.WriteLine("Hello World!");
        }
    }
}
