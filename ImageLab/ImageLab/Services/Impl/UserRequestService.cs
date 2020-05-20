using ImageLab.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImageLab.Services.Impl
{
    public class UserRequestService : IUserRequestService
    {
        public UserRequestService()
        {

        }
    
        public UserRequestForImage RequestForImage()
        {
            UserRequestForImage userRequestForImage = new UserRequestForImage();

            Console.WriteLine("Write name of image");
            userRequestForImage.Name = Console.ReadLine();
            Console.WriteLine("Write format type");
            userRequestForImage.ImageFormat = Console.ReadLine();

            return userRequestForImage;
        }

        public int OperationRequest()
        {
            Console.WriteLine("What you want to do with image?");
            Console.WriteLine("1 - Move, 2 - Stretch, 3 - Compress, 4 - Cut");
     
            var value = Int32.Parse(Console.ReadLine());

            if (value == 1 || value == 2 || value == 3 || value == 4)
            {
                return value;
            }
            else
            {
                throw new Exception($"Value {value} is not valid");
            }
                        
        }

        public string ContunueRequest()
        {
            Console.WriteLine("Do you want to continue to work with this image?");
            Console.WriteLine($"Write {"Yes"} if you want to continue to work with this image");

            var response = Console.ReadLine();
            return response;
        }

        public bool ExitFromApp()
        {
            Console.WriteLine($"If you want to exit from app write {"Exit"}");
            var response = Console.ReadLine();

            if (response.Equals("Exit")) return true;

            return false;

        }
    }
}
