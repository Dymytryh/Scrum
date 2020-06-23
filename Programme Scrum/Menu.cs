using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Programme_Scrum
{
    class Menu
    {
        public static void WriteMenu(List<string> list)
        {
            Program.nettoyerConsole();
            int place = 1;
            foreach (var element in list)
            {
                Console.WriteLine(place +". " + element);
                place++;
            }
            int lenght = list.Count() + 1 ;
            Console.WriteLine(lenght + ". Quitter");
           
        }

        public static void CallMenu(Dictionary<int,Func<string>> dic, int a) 
        {
            dic.Add(dic.Last().Key + 1, Exit);
            if (dic.ContainsKey(a))
            {
                try
                {
                    Program.nettoyerConsole();                   
                    var call = dic.Where(k => k.Key == a).FirstOrDefault().Value.DynamicInvoke();
                    Console.WriteLine(call);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }else
            {
                Console.WriteLine("Entrez un nombre correcte");
            }
        }

        public static string Exit()
        {
            Environment.Exit(-1);
            return "";
        }
    }
}
