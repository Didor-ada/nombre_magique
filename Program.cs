using System;

namespace nombre_magique
{
    class Program
    {
        static int DemanderNombre(int min, int max)
        {
            int nombreUtilisateur = -1;

            while ((nombreUtilisateur < min) || (nombreUtilisateur > max))
            {
                Console.WriteLine("Veuillez insérer un nombre entre " + min + " et " + max);
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);

                    if ((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine("ERREUR : le nombre doit être entre " + min + " et " + max);

                    }
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
            Random rand = new Random();

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX+1);

            int nombre = NOMBRE_MAGIQUE+1;

            //int nbVies = 4; // à enlever pour la boucle for

            // while (nbVies > 0) // tant qu'on a encore des vies
            for (int nbVies = 4; nbVies > 0; nbVies--)
            {
                Console.WriteLine();
                Console.WriteLine("Vies restantes : " + nbVies);
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                // 1 - Passer les min et max en paramètres : int min, int max
                // 2 - Rentrer un nomre entre 1 et 10 <- dépend de min et max, ne pas le fait en dur
                // 3 - Tester si nombreUtilisateur est bien entre min et max : ERREUR : le nombre doit être entre 1 et 10

                if (NOMBRE_MAGIQUE > nombre)
                {
                    Console.WriteLine("Le nombre magique est plus grand");
                }
                else if (NOMBRE_MAGIQUE < nombre)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
                }
                else
                {
                    Console.WriteLine("Bravo ! Vous avez trouvé le nombre magique");
                    break;
                }
                //nbVies -= 1; // = nbVies-- sert que pour la boucle while
            }

            if (nombre != NOMBRE_MAGIQUE) // (nbVies == 0) pour la boucle while
            {
                Console.WriteLine("Vous avez perdu, le nombre magique était : " + NOMBRE_MAGIQUE);
            }


            // Random

            /*Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int valeurAleatoire = rand.Next(1, 11);
                Console.WriteLine("Nombre aléatoire : " + valeurAleatoire);
            }*/
        }
    }
}
