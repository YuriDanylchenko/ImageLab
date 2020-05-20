using ImageLab.Enums;
using ImageLab.Models;
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
		   .AddSingleton<IReadImageservice, ReadImageService>()
		   .AddSingleton<IUserRequestService, UserRequestService>()
		   .AddSingleton<IImageOperationService, ImageOperationService>()
		   .AddSingleton<ISaveImageService, SaveImageService>()
		   .BuildServiceProvider();

			var _readImageService = serviceProvider.GetService<IReadImageservice>();
			var _userRequestService = serviceProvider.GetService<IUserRequestService>();
			var _imageOperationService = serviceProvider.GetService<IImageOperationService>();
			var _saveImageService = serviceProvider.GetService<ISaveImageService>();

			string appCode = "Go";

			while (appCode.Equals("Go"))
			{			

				var image = _readImageService.GetImage(_userRequestService.RequestForImage());

				string workWithImage = "Go";

				while (workWithImage.Equals("Go"))
				{
					var operationCode = _userRequestService.OperationRequest();

					switch (operationCode)
					{
						case 1:
							{
								image = _imageOperationService.MoveImage(image);
								_saveImageService.SaveImage(image);
								break;
							};
						case 2:
							{
								image = _imageOperationService.StrecthImage(image, 30);
								_saveImageService.SaveImage(image);
								break;
							}
						case 3:
							{
								image = _imageOperationService.CompressImage(image, 20);
								_saveImageService.SaveImage(image);
								break;
							}
						case 4:
							{
								image = _imageOperationService.CutImage(image, 10, "right");
								_saveImageService.SaveImage(image);
								break;
							}
						default: break;

					}

					var resp = _userRequestService.ContunueRequest();

					if (!resp.Equals("Yes"))
					{
						_saveImageService.SaveImage(image);
						workWithImage = "Finish";
					}
				}

				if (_userRequestService.ExitFromApp())
				{
					appCode = "Finish";
				}
			}

			Console.WriteLine("The end");
		}
	}
}
