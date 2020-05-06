
using ImageLab.Enums;
using ImageLab.Models;
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
            if (SaveLookingInStatus(image.Status))
            {
                Console.WriteLine($"Image {image.Name} saved in {image.Format.ToString()}");
            }
            if (!SaveLookingInStatus(image.Status))
            {
                Console.WriteLine($"Image {image.Name} can't save. You have to end operations");
            }
        }

        private bool SaveLookingInStatus(ImageStatus status)
        {
            if (status == ImageStatus.FINISHED) return true;
            return false;
        }
    }
}
