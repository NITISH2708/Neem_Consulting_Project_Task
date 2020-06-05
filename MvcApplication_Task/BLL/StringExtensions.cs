using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class StringExtensions
    {
        /// <summary>
        /// Compares two strings, set ignoreCase to true to ignore case comparison ('A' == 'a')
        /// </summary>
        public static bool CompareTo(this string strA, string strB, bool ignoreCase)
        {
            return String.Compare(strA, strB, ignoreCase) == 0;
        }
    }
}
