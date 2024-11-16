using System;
using System.IO;
using System.Text;

namespace demonSPICA.Format {
    public static class FormatIdentifier {
        public static FormatTypes identifyByFilestream(FileStream stream) {
            if (stream.Length < 4) {
                throw new InvalidDataException();
            }
            
            var reader = new BinaryReader(stream);
            var type = Encoding.ASCII.GetString(reader.ReadBytes(4));
            stream.Seek(0, SeekOrigin.Begin);
            var format = FormatTypesUtils.GetFormatType(type);

            if (format == FormatTypes.UNKNOWN) {
                throw new NotImplementedException();
            }

            return format;
        }
    }
}