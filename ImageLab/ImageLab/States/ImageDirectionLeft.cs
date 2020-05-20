using ImageLab.Enums;
using ImageLab.Interfaces;
using ImageLab.Models;
using System;

namespace ImageLab.States
{
	public class ImageDirectionLeft : IMoveImage
	{
		public Image MoveImage(Image image)
		{
			Console.WriteLine("Top of image is directi to Left side");
			image.Direction = ImageHeadDirection.LEFT;
			return image;
		}
	}
}
