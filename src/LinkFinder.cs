using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace VismaTwitter
{

    public static class FindLink
        {

    public static string Find(string text)
    {

        foreach (Match item in Regex.Matches(text, @"(http|ftp|https):\/\/([\w\-_]+(?:(?:\.[\w\-_]+)+))([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?"))
        {
               text= text.Replace(item.Value,"<A HREF='"  + item.Value + "' TARGET='_new'>" + item.Value + "</A>");
                //                Console.WriteLine(item.Value);
        }
            return text;
    }
}
}