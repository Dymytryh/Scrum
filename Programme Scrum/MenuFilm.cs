using System;


using System.Xml.XPath;

namespace Programme_Scrum
{
    class MenuFilm
    {
        public static void afficherListeFilm(string cheminFichierXml)
        {
            XPathDocument doc = new XPathDocument(cheminFichierXml);
            XPathNavigator nav = doc.CreateNavigator();

            XPathNodeIterator iter = nav.Select("MOVIE");

            int index = 1;

            while (iter.MoveNext())
            {
                string titreFilm = iter.Current.SelectSingleNode("TITLE").Value;
                /*   string dateSortieFilm = iter.Current.SelectSingleNode("DATE").Value;
                   string nomRealisateur = iter.Current.SelectSingleNode("REALISATOR").Value;
                   string noteFilm = iter.Current.SelectSingleNode("NOTE").Value;
               */
                Console.WriteLine(index + ": " + titreFilm);
                index++;
            }

            Console.WriteLine("Veuillez entrer le numéro du film");
            int numFilmInput = Convert.ToInt32(Console.ReadLine());


        }

        public static Boolean afficherInfoFilm(int numFilmInput, string cheminFichierXml)
        {
            XPathDocument doc = new XPathDocument(cheminFichierXml);
            XPathNavigator nav = doc.CreateNavigator();

            XPathNodeIterator iter = nav.Select("MOVIE");

            string titreFilm = "Erreur";
            string dateSortieFilm = "Erreur";
            string nomRealisateur = "Erreur";
            string noteFilm = "Erreur";

            Boolean erreur = true;

            int index = 1;

            while (iter.MoveNext())
            {
                
                
                if (index == numFilmInput)
                {
                    titreFilm = iter.Current.SelectSingleNode("TITLE").Value;
                    dateSortieFilm = iter.Current.SelectSingleNode("DATE").Value;
                    nomRealisateur = iter.Current.SelectSingleNode("REALISATOR").Value;
                    noteFilm = iter.Current.SelectSingleNode("NOTE").Value;

                    erreur = false;

                    break;
                }


            }
            Console.WriteLine("Titre du film: " + titreFilm);
            Console.WriteLine("Date de sortie: " + dateSortieFilm);
            Console.WriteLine("Nom du réalisateur: " + nomRealisateur);
            Console.WriteLine("Note: " + noteFilm);

            return erreur;
        }



        public static string afficherMenuFilm()
        {

            while (true)
            {
                Console.WriteLine("1: Revenir à la liste des films");
                Console.WriteLine("2: Supprimer le film et revenir à la liste des films");
                Console.WriteLine("3: Revenir au menu principal");

                try
                {
                    int choixMenuUtilisateur = Convert.ToInt32(Console.ReadLine());
                    if (choixMenuUtilisateur==1 || choixMenuUtilisateur==2 || choixMenuUtilisateur == 3)
                    {
                        //return choixMenuUtilisateur;
                        return "";
                    }
                    
                }

                catch (Exception erreur)
                {
                    Console.WriteLine("Exception levé:"+erreur);
                }

                Console.WriteLine("Veuillez entrer un nombre entier compris entre 1 et 3");
            }

        }



    }
}
