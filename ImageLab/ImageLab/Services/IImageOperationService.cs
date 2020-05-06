using ImageLab.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageLab.Services
{
    public interface IImageOperationService
    {
        public Image MoveImage(Image image, string direction);

        public Image StrecthImage(Image image, int length);

        public Image CompressImage(Image image, int length);

        public Image CutImage(Image image, int length, string side);
    }
       
}
