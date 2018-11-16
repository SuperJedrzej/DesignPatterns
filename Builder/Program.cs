using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Builder
{

    class Program
    {
        static void Main(string[] args)
        {
            var hello = "hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console.WriteLine(sb);

            var words = new[] {"hello", "world"};
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat("<li>{0}</li>",word);
            }

            sb.Append("</ul>");
            Console.WriteLine(sb);


            var builder = new HtmlBuilder("ul");
            builder.AddChild("li","hello").AddChild("li","world");
            Console.WriteLine(builder.ToString());
        }
    }
}
