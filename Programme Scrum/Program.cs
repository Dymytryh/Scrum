﻿using System;
using System.Collections.Generic;

namespace Programme_Scrum
{
    class Program
    {
         public static void nettoyerConsole()
         {
              Console.Clear();
         }
        
        static void Main(string[] args)
        {
            

            List<string> menu = new List<string>(new string[] { "Encodage d'un film","Liste de films","Affichage de la météo"});
            menu.Add("S'enregistrer en tant qu'administrateur");
            int a = 0;

            do
            {
                Menu.WriteMenu(menu);
                a = int.Parse(Console.ReadLine());
                Dictionary<int, Func<string>> dic = new Dictionary<int, Func<string>>();
                dic.Add(1, Film.EncodageFilm);
                dic.Add(2, MenuFilm.afficherListeFilm);
                dic.Add(3, Meteo.AfficheMeteo);
                dic.Add(4, GestionAdmin.AjoutAdmin);
                Menu.CallMenu(dic, a);
                Console.ReadKey();
            } while (a != menu.Count + 1);
        }
    }
}
