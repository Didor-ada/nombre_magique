using System;

namespace nombre_magique
{
    class Program
    {
        static int DemanderNombre()
        {
            int nombreUtilisateur = 0;

            while(nombreUtilisateur == 0)
            {
                Console.WriteLine("Veuillez insérer un nombre : ");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);
                }
                catch
                {
                    Console.WriteLine("ERREUR : rentrez un nombre valide !");
                }
            }
            return nombreUtilisateur;
        }

        // Demander nombre
        // afficher : rentrer un nombre
        // tester si ce nom est valide (conversion -> try/cartch) - > ERREUR : ce nombre n'est pas valide
        // reboucler tant que le nombre n'est pas valide
        // considérer que 0 est invalide
        //retourner la valeur sous forme de (int)
        static void Main(string[] args)
        {
            // appeler cette fonction DemanderNombre() une seule fois

            // write line : votre nombre est : xx

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;

            int nombre = DemanderNombre();

            // 1 - Passer les min et max en paramètres : int min, int max
            // 2 - Rentrer un nomre entre 1 et 10 <- dépend de min et max, ne pas le fait en dur
            // 3 - Tester si nombreUtilisateur est bien entre min et max : ERREUR : le nombre doit être entre 1 et 10

            Console.WriteLine("Votre nombre est : " + nombre);
        }
    }
}
