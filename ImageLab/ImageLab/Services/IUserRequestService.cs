using ImageLab.Models;

namespace ImageLab.Services
{
    public interface IUserRequestService
    {
        public UserRequestForImage RequestForImage();
        public int OperationRequest();
        public string ContunueRequest();
        public bool ExitFromApp();
    }
}
