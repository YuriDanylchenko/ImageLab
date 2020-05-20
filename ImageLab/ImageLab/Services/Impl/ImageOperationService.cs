using ImageLab.Enums;
using ImageLab.Models;
using ImageLab.States;
using System;

namespace ImageLab.Services.Impl
{
	public class ImageOperationService : IImageOperationService
	{
		public ImageOperationService()
		{

		}

		public Image MoveImage(Image image)
		{
			Console.WriteLine("Choose side");
			Console.WriteLine("1 - right; 2 - left");

			int value = Int32.Parse(Console.ReadLine());

			MoveImage moveImage = new MoveImage(new ImageDirectionTop());

			if (value == 1)
			{
				while (true)
				{					
					image = moveImage.MoveInRightDirection(image);
					
					Console.WriteLine("If you want to stop move image wright stop");
					var val = Console.ReadLine();
					if (val.Equals("stop")) break;
				}
			}

			if (value == 2)
			{
				while (true)
				{			
					image = moveImage.MoveInLeftDirection(image);

					Console.WriteLine("If you want to stop move image wright stop");
					var val = Console.ReadLine();
					if (val.Equals("stop")) break;
				}
				
			}

			return image;
		}

		public Image StrecthImage(Image image, int length)
		{
			Console.WriteLine($"Image {image.Name} was stretched on {length} pixels");
			return image;
		}

		public Image CompressImage(Image image, int length)
		{
			Console.WriteLine($"Image {image.Name} was compressed on {length} pixels");
			return image;
		}

		public Image CutImage(Image image, int length, string side)
		{
			Console.WriteLine($"Image {image.Name} was cut on {length} pixels on {side} side");
			return image;
		}
	}
}
