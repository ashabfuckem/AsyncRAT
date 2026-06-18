using System.Drawing.Imaging;

namespace System.Drawing.IconLib.ColorProcessing;

[Author("Franco, Gustavo")]
public interface IPaletteQuantizer
{
	ColorPalette CreatePalette(Bitmap image, int maxColors, int bitsPerPixel);
}
