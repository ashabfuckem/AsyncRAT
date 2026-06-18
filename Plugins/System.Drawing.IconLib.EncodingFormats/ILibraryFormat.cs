using System.IO;

namespace System.Drawing.IconLib.EncodingFormats;

public interface ILibraryFormat
{
	bool IsRecognizedFormat(Stream stream);

	void Save(MultiIcon singleIcon, Stream stream);

	MultiIcon Load(Stream stream);
}
