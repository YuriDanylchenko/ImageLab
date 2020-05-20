using ImageLab.Enums;
using ImageLab.Extensions;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ImageLab.Models
{
    [Serializable]
    public class Image : IImageProrotype
    {
        public string Name { get; set; }      
        public ImageHeadDirection Direction { get; set; }

        public ImageFormat Format { get; set; }

        public Image CloneForSave()
        {
            return (Image)this.MemberwiseClone();
        }

        public Image DeepCloneForSave()
        {
            object image = null;
            using (MemoryStream tempStream = new MemoryStream())
            {
                BinaryFormatter binFormatter = new BinaryFormatter(null,
                    new StreamingContext(StreamingContextStates.Clone));

                binFormatter.Serialize(tempStream, this);
                tempStream.Seek(0, SeekOrigin.Begin);

                image = binFormatter.Deserialize(tempStream);
            }
            return (Image)image;
        }
    }
}
