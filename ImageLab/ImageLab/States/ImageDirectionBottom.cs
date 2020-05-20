using ImageLab.Enums;
using ImageLab.Interfaces;
using ImageLab.Models;
using System;

namespace ImageLab.States
{
	public class ImageDirectionBottom : IMoveImage
	{
		public Image MoveImage(Image image)
		{
			Console.WriteLine("Top of image is directi to bottom side");
			image.Direction = ImageHeadDirection.BOTTOM;
			return image;
		}
	}
}
