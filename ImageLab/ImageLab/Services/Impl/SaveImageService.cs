
using ImageLab.Enums;
using ImageLab.Models;
using ImageLab.States;
using System;

namespace ImageLab.Services.Impl
{
	public class SaveImageService : ISaveImageService
	{
		public SaveImageService()
		{

		}

		public void SaveImage(Image image)
		{
			var imageForSave = image.DeepCloneForSave();
			Console.WriteLine($"{imageForSave.Name} was saved in {imageForSave.Format.ToString()}");
		}

	}
}
