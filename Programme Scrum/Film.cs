using System;
using System.IO;
using System.Text;

namespace Programme_Scrum
{
    class Film
    {
        public static int READLINE_BUFFER_SIZE { get; private set; }

        public static string EncodageFilm()
        {
            bool isOk = false;
            do
            {
                try
                {
                    Console.Write("Entrez le titre d'un film: ");
                    string titre = Console.ReadLine();

                    Console.Write("Entrez l'année de sortie: ");
                    int date = int.Parse(Console.ReadLine());

                    while (date < 1891 || date > DateTime.Now.Year)
                    {
                        Console.Write("Entrez l'année CORRECTE de sortie: ");
                        date = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Entrez le réalisateur: ");
                    string realisateur = Console.ReadLine();

                    Console.Write("Note sur 10: ");
                    int note = int.Parse(Console.ReadLine());

                    while (note > 10 || note < 0)
                    {
                        Console.Write("Entrez une note entre 0 et 10: ");
                        note = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Entrez votre critique du film: ");
                    Console.SetIn(new StreamReader(Console.OpenStandardInput(),
                                Console.InputEncoding,
                                false,
                                bufferSize: 1024));
                    string critique = Console.ReadLine();

                    while (critique.Length <= 100 || critique.Length >= 1000)
                    {
                        critique = Console.ReadLine();
                    }

                    // Set a variable to the Documents path.
                    string docPath =
                      Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                 
                    StreamWriter sw = new StreamWriter(Path.Combine(docPath, "titre.xml"));
                    sw.WriteLine("<MOVIE>");
                    sw.WriteLine("<TITLE>" + titre + "</TITLE>");
                    sw.WriteLine("<DATE>" + date + "</DATE>");
                    sw.WriteLine("<REALISATOR>" + realisateur + "</REALISATOR>");
                    sw.WriteLine("<NOTE>" + note + "</NOTE>");
                    sw.WriteLine("<CRITIQUE>" + critique + "</CRITIQUE>");
                    sw.WriteLine("</MOVIE>");
                    sw.Close();
                    Console.WriteLine("Film sauvegardé !");
                    isOk = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            } while (!isOk);

                return "";
        }       
    }
}
