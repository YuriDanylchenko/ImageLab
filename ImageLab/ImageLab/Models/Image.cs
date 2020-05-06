using ImageLab.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageLab.Models
{
    public class Image
    {
        public string Name { get; set; }
        public ImageFormat Format { get; set; }

        public ImageStatus Status { get; set; }
    }
}
