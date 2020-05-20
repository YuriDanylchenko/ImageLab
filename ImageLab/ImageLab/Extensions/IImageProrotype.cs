using ImageLab.Models;

namespace ImageLab.Extensions
{
	public interface IImageProrotype
	{
		public Image CloneForSave();
		public Image DeepCloneForSave();
	}
}
