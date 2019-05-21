using System.Collections.Generic;
using System.Globalization;

namespace ShScheduler.Translation
{
    static class Language
    {
        public static CultureInfo GetLanguage(int index)
        {
            if (Languages.ContainsKey(index))
            {
                switch (Languages[index])
                {
                    case "Français":
                        return new CultureInfo("fr-FR");
                    case "English":
                        return new CultureInfo("en-US");
                }
            }
            return new CultureInfo("en-US");

        }


        public static Dictionary<int, string> Languages => new Dictionary<int, string> { { 0, "English" }, { 1, "Français" } };
    }
}
