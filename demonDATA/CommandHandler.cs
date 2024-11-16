using System.IO;
using demonSPICA.Format;

namespace demonDATA {
    public static class CommandHandler {
        public static void handleExtract(FileInfo file) {
            if (!(file is { Exists: true })) {
                throw new System.ArgumentNullException(nameof(file));
            }

            using var stream = file.OpenRead();
            var format = FormatIdentifier.identifyByFilestream(stream);
        }
    }
}