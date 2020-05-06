using ImageLab.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageLab.Services
{
   public interface ISaveImageService
    {
        public void SaveImage(Image image);
    }
}
