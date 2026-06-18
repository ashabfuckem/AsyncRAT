namespace System.Drawing.IconLib.ColorProcessing;

[Author("Franco, Gustavo")]
public interface IDithering
{
	unsafe void Disperse(byte* pixelSource, int x, int y, byte bpp, int stride, int width, int height, Color colorEntry);
}
