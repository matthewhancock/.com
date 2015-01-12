using System;
using System.Text.RegularExpressions;

namespace mh.Util
{
    /// <summary>
    /// Summary description for Text
    /// </summary>
    public static class Text
    {
        internal static string StripHtml(string HtmlString)
        {
            return Regex.Replace(HtmlString, "<(.|\n)*?>", String.Empty).Replace("&nbsp;", " ");
        }
    }
}