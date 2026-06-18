using System.Drawing.Imaging;

namespace System.Drawing.IconLib.ColorProcessing;

[Author("Franco, Gustavo")]
public interface IColorQuantizer
{
	Bitmap Convert(Bitmap source, PixelFormat outputFormat);
}
