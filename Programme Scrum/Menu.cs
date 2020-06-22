using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programme_Scrum
{
    class Menu
    {
        public static void WriteMenu(List<string> list)
        {
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
            dic.Add(dic.Last().Key + 1, Menu.Test);
            var call = dic.Where(k => k.Key == a).FirstOrDefault().Value.DynamicInvoke();
            Console.WriteLine(call);
        }

        public static string Test()
        {
            return "Hello there";
        }
    }
}
