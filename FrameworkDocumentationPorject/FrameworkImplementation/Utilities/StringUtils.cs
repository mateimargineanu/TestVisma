using System;
using System.Linq;

namespace FrameworkImplementation.Utilities
{
    public class StringUtils
    {
        private static Random random = new Random();
        public static string RandomString(int length = 5)
        {
            var chars = LanguageUtils.language["English"];
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
