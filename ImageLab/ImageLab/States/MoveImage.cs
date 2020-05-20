using ImageLab.Interfaces;
using ImageLab.Models;
using System;

namespace ImageLab.States
{
	public class MoveImage
	{
		private IMoveImage _moveImage { get; set; }

		public MoveImage(IMoveImage moveimage)
		{
			_moveImage = moveimage;
		}

		public Image MoveInRightDirection(Image image)
		{
			if (_moveImage.GetType() == typeof(ImageDirectionTop))
			{
				_moveImage = new ImageDirectionLeft();
				return MoveImageInDirection(image);
			}

			if(_moveImage.GetType() ==typeof(ImageDirectionLeft))
			{
				_moveImage = new ImageDirectionBottom();
				return MoveImageInDirection(image);
			}

			if (_moveImage.GetType() == typeof(ImageDirectionBottom))
			{
				_moveImage = new ImageDirectionRight();
				return MoveImageInDirection(image);
			}

			if (_moveImage.GetType() == typeof(ImageDirectionRight))
			{
				_moveImage = new ImageDirectionTop();
				return MoveImageInDirection(image);
			}

			else throw new Exception("Unknow Direction");
		}

		public Image MoveInLeftDirection(Image image)
		{
			if (_moveImage.GetType() == typeof(ImageDirectionTop))
			{
				_moveImage = new ImageDirectionRight();
				return MoveImageInDirection(image);
			}

			if (_moveImage.GetType() == typeof(ImageDirectionRight))
			{
				_moveImage = new ImageDirectionBottom();
				return MoveImageInDirection(image);
			}

			if (_moveImage.GetType() == typeof(ImageDirectionBottom))
			{
				_moveImage = new ImageDirectionLeft();
				return MoveImageInDirection(image);
			}

			if (_moveImage.GetType() == typeof(ImageDirectionLeft))
			{
				_moveImage = new ImageDirectionTop();
				return MoveImageInDirection(image);
			}

			else throw new Exception("Unknow Direction");
		}

		private Image MoveImageInDirection(Image image)
		{
			return _moveImage.MoveImage(image);
		}
	}
}
