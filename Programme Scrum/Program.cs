using System;
using System.Collections.Generic;

namespace Programme_Scrum
{
    class Program
    {
        static void Main(string[] args)
        {
             public static void nettoyerConsole()
            {
                Console.Clear();
            }

            List<string> menu = new List<string>(new string[] { "Encodage d'un film"});
            int a = 0;

            do
            {
                Menu.WriteMenu(menu);
                a = int.Parse(Console.ReadLine());
                Dictionary<int, Func<string>> dic = new Dictionary<int, Func<string>>();
                dic.Add(1, Film.EncodageFilm);
                Menu.CallMenu(dic, a);
                Console.ReadKey();
            } while (a != menu.Count + 1);
        }
    }
}
