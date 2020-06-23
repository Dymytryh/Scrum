using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Programme_Scrum
{
    class Program
    {
        public static int READLINE_BUFFER_SIZE { get; private set; }

        public static void nettoyerConsole()
         {
              Console.Clear();
         }
        
        static void Main(string[] args)
        {

            List<string> menu = new List<string>(new string[] { "Encodage d'un film", "Liste de films"});
            int a = 0;

            do
            {
                Menu.WriteMenu(menu);
                a = int.Parse(Console.ReadLine());
                Dictionary<int, Func<string>> dic = new Dictionary<int, Func<string>>();
                dic.Add(1, Film.EncodageFilm);
                dic.Add(2, MenuFilm.afficherMenuFilm);
                Menu.CallMenu(dic, a);
                Console.ReadKey();
            } while (a != menu.Count + 1);
        }

        
    }
}
