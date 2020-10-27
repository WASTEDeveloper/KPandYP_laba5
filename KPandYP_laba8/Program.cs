using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace KPandYP_laba8
{
    class Program
    {
        public static void GreateHtmlDoc(string TextInBody)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html >");
            sb.Append("<head >");
            string meta = @"<meta charset=""UTF-8"">";
            sb.Append(meta);
            sb.Append("<title >");
            sb.Append("</title >");
            sb.Append("</head >");
            sb.Append("<body >");
            sb.Append(TextInBody);
            sb.Append("</body >");
            sb.Append("</html >");
            using (StreamWriter sw = new StreamWriter("MyHtml.html"))
            {
                sw.Write(sb.ToString());
                sw.Close();
                Console.WriteLine("Файл создан успешно!");
                //System.Diagnostics.Process.Start("MyHtml.html");
            }
        }

        public static void Task2()
        {
            string text = File.ReadAllText("2.txt");
            string pattern = @"b{2}";
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
            bool flag = true;
            while (reg.IsMatch(text))
            {
                text = flag ? reg.Replace(text, @"<b>", 1) : reg.Replace(text, @"</b>", 1);
                flag = !flag;
            }
            string[] mas = text.Split('\n');
            pattern = @"^Hs\d+";
            reg = new Regex(pattern);
            Regex reg2 = new Regex(@"\d+");
            for (int i = 0; i < mas.Length; i++)
            {
                if (reg.IsMatch(mas[i]))
                {
                    string size = reg2.Match(reg.Match(mas[i]).Value).Value;
                    mas[i] = reg.Replace(mas[i], $"<hr style=\"width: {size}px;\">");
                    mas[i] = mas[i] + "<hr>";
                }
            }
            text = string.Join("<br>", mas, 0, mas.Length);
            GreateHtmlDoc(text);

        }

        public static void Task1()
        {
            Regex regex = new Regex(@"[0-3]{1}[0-9]{1}.[0-1]{1}[0-2]{1}.\d{4}");
            string text = File.ReadAllText("1.txt");

            MatchCollection matches = regex.Matches(text);

            if (matches.Count > 0)
            {
                foreach (var item in matches)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено!");
            }
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
