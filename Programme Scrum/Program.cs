using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Programme_Scrum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> menu = new List<string>(new string[] { "Nouvelle personne", "Supprimer personne"});
            Menu.WriteMenu(menu);
            int a = int.Parse(Console.ReadLine());
            Dictionary<int, Func <string>> dic = new Dictionary<int, Func<string>>();
            dic.Add(1, Menu.Test);
            dic.Add(2, Menu.Test);
            Menu.CallMenu(dic,a);
            Console.ReadKey();
        }
    }
}
