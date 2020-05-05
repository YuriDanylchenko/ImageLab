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

        public static T ToEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public Image GetImage(string name, string format)
        {
            try
            {
                ImageFormat imageFormat = (ImageFormat)Enum.Parse(typeof(ImageFormat), format.ToUpperInvariant(), true);
                //ImageFormat imageFormat = (ImageFormat)Enum.Parse(typeof(ImageFormat), format);
                Image image = new Image()
                {
                    Name = name,
                    Format = imageFormat
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
