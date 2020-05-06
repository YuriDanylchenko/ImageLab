using ImageLab.Enums;
using ImageLab.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageLab.Services.Impl
{
    public class ReadImageService : IReadImageservice
    {
        public ReadImageService()
        {

        }

        public Image GetImage(UserRequestForImage request)
        {
            try
            {
                ImageFormat imageFormat = (ImageFormat)Enum.Parse(typeof(ImageFormat), request.ImageFormat.ToUpperInvariant(), true);
                //ImageFormat imageFormat = (ImageFormat)Enum.Parse(typeof(ImageFormat), format);
                Image image = new Image()
                {
                    Name = request.Name,
                    Format = imageFormat,
                    Status = ImageStatus.READY
                };

                return image;
            }

            catch
            {
                throw new Exception("Unknown format");
            }
           
        }
             
    }
}
