using System;
using ImageLab.Enums;
using ImageLab.Interfaces;
using ImageLab.Models;

namespace ImageLab.States
{
	public class ImageDirectionRight : IMoveImage
	{
		public Image MoveImage(Image image)
		{
			Console.WriteLine("Top of image is direct to Right side");
			image.Direction = ImageHeadDirection.RIGHT;
			return image;
		}
	}
}
