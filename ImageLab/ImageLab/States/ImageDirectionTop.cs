using ImageLab.Enums;
using ImageLab.Interfaces;
using ImageLab.Models;
using System;

namespace ImageLab.States
{
	public class ImageDirectionTop : IMoveImage
	{
		public Image MoveImage(Image image)
		{
			Console.WriteLine("Top of image is directi to top side");
			image.Direction = ImageHeadDirection.TOP;
			return image;
		}
	}
}
