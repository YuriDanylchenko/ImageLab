using ImageLab.Models;

namespace ImageLab.Services
{
    public interface IReadImageservice
    {
        public Image GetImage(UserRequestForImage request);
    }
}
