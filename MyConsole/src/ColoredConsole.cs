
using System.Runtime.ExceptionServices;

namespace MyConsole
{
    public static class ColoredConsole 
    {
        private static ConsoleColor _color = ConsoleColor.Gray;
        public static ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; Console.ForegroundColor = value; }
        }



        public static void ColoredPrint(Object? oj, ConsoleColor consoleColor)
        {
            if (oj == null) return;
            Console.ForegroundColor = consoleColor;
            Console.Write(oj.ToString());
            Console.ForegroundColor = _color;
        }
        public static void ColoredPrintnl(Object? oj, ConsoleColor consoleColor)
        {
            if (oj == null) return;
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(oj.ToString());
            Console.ForegroundColor = _color;
        }

        public static void ColorAtSymbol(string oj, ConsoleColor consoleColor)
        {
            string[] s = oj.Split(' ');
            foreach (string str in s)
            {
                if (str[0] == '!' && str[1] == '_')
                {
                    ColoredPrint($"{str.Remove(0, 2)} ", consoleColor);
                } else
                {
                    Console.Write($"{str} ");
                }
            }
            Console.Write("\n");
        }
        public static void ColorAtSymbol(string oj, ConsoleColor consoleColor, char a)
        {
            string[] s = oj.Split(' ');
            foreach (string str in s)
            {
                if (str[0] == a && str[1] == '_')
                {
                    ColoredPrint($"{str.Remove(0, 2)} ", consoleColor);
                }
                else
                {
                    Console.Write($"{str} ");
                }
            }
            Console.Write("\n");
        }
        public static void ColorAtSymbol(string oj, ConsoleColor consoleColor, char a, char b)
        {
            string[] s = oj.Split(' ');
            foreach (string str in s)
            {
                if (str[0] == a && str[1] == b)
                {
                    ColoredPrint($"{str.Remove(0, 2)} ", consoleColor);
                }
                else
                {
                    Console.Write($"{str} ");
                }
            }
            Console.Write("\n");
        }
        public static void ColorAtSymbol(string oj, ConsoleColor consoleColor, string a)
        {
            string[] s = oj.Split(' ');
            foreach (string str in s)
            {
                if (str[0] == a[0] && str[1] == a[1])
                {
                    ColoredPrint($"{str.Remove(0, 2)} ", consoleColor);
                }
                else
                {
                    Console.Write($"{str} ");
                }
            }
            Console.Write("\n");
        }
    }
}