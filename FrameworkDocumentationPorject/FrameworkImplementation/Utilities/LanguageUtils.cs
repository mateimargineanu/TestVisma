using System.Collections.Generic;

namespace FrameworkImplementation.Utilities
{
    public static class LanguageUtils
    {
        public static Dictionary<string, string> language = new Dictionary<string, string>();

        static LanguageUtils()
        {
            language.Add("English", "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
        }
    }
}
