using ImageLab.Enums;
using ImageLab.Models;
using System;

namespace ImageLab.Services.Impl
{
    public class ImageOperationService : IImageOperationService
    {
        public ImageOperationService()
        {

        }

        public Image MoveImage(Image image, string direction)
        {
            Console.WriteLine($"Image {image.Name} was moved to {direction} side");
            image.Status = ImageStatus.INPROGRESS;
            return image;
        }

        public Image StrecthImage(Image image, int length)
        {
            Console.WriteLine($"Image {image.Name} was stretched on {length} pixels");
            image.Status = ImageStatus.INPROGRESS;
            return image;
        }

        public Image CompressImage(Image image, int length)
        {
            Console.WriteLine($"Image {image.Name} was compressed on {length} pixels");
            image.Status = ImageStatus.INPROGRESS;
            return image;
        }

        public Image CutImage(Image image, int length, string side)
        {
            Console.WriteLine($"Image {image.Name} was cut on {length} pixels on {side} side");
            image.Status = ImageStatus.INPROGRESS;
            return image;
        }
    }
}
