namespace demonSPICA.Format {
    public static class FormatTypesUtils {
        public static FormatTypes GetFormatType(string format) {
            if (format.StartsWith("CGFX")) {
                return FormatTypes.CGFX;
            } else {
                return FormatTypes.UNKNOWN;
            }
        }
    }
}