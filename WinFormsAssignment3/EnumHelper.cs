using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace WinFormsAssignment3
{
    /// <summary>
    /// Code obtained from:
    /// https://stackoverflow.com/questions/1799370/getting-attributes-of-enums-value
    /// </summary>
    public class EnumHelper
    {
        public static string ToDescription(Enum value)
        {
            if (value == null)
                return string.Empty;
            

            if (!Enum.IsDefined(value.GetType(), value))
                return string.Empty;

            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo != null)
            {
                DescriptionAttribute[] attributes =
                    fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

                if (attributes != null && attributes.Length > 0)
                    return attributes[0].Description;
            }

            return StringHelper.ToFriendlyName(value.ToString());
        }
    }

    public static class StringHelper
    {
        public static bool IsNullOrWhiteSpace(string value)
        {
            return value == null || string.IsNullOrEmpty(value.Trim());
        }

        public static string ToFriendlyName(string value)
        {
            if (value == null) return string.Empty;
            if (value.Trim().Length == 0) return string.Empty;

            string result = value;

            result = string.Concat(result.Substring(0, 1).ToUpperInvariant(), result.Substring(1, result.Length - 1));

            const string pattern = @"([A-Z]+(?![a-z])|\d+|[A-Z][a-z]+|(?![A-Z])[a-z]+)+";

            List<string> words = new List<string>();
            Match match = Regex.Match(result, pattern);
            if (match.Success)
            {
                Group group = match.Groups[1];
                foreach (Capture capture in group.Captures)
                {
                    words.Add(capture.Value);
                }
            }

            return string.Join(" ", words.ToArray());
        }
    }
}
