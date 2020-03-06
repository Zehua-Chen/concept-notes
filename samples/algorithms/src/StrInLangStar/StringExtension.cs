using System.Text.RegularExpressions;
using static System.Linq.Enumerable;

namespace Algorithms
{
    public static class StringExtension
    {
        internal static bool IsFullMatch(this string s, string expression)
        {
            Regex regex = new Regex(expression);
            return regex.IsMatch(s);
        }

        public static bool IsInLanguageStarRecursive(this string s, string language)
        {
            if (s.Length == 0)
            {
                return true;
            }

            if (s.IsFullMatch(language))
            {
                return true;
            }

            foreach (var i in Range(0, s.Length - 1))
            {
                if (s.Substring(0, i).IsFullMatch(language)
                    && s.Substring(i).IsInLanguageStarRecursive(language))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
