using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeString
{
    public class PrimeString
    {
        public bool IsPrimeString(string text)
        {
            foreach (string elementWord in GetAllElementWords(text))
            {
                string tmp = text.Replace(elementWord, string.Empty);
                if (tmp.Length == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public IEnumerable<string> GetAllElementWords(string text)
        {
            for (int i = 1; i < text.Length; i++)
            {
                yield return text.Substring(i);
            }
        }
    }
}
