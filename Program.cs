namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
        
        int remainingArrows = 5;
        int successfulShots = 0;
        
        Console.WriteLine("Vous commencez votre chasse");

        while (remainingArrows > 0)
        {
            Console.WriteLine("\nFlèches restantes : " + remainingArrows);
            Console.Write("Résultat du tir (touche/rate) : ");

            string reponse = Console.ReadLine();

            // Ignorer la saisie si elle est invalide.
            if (reponse != "touche" && reponse != "rate")
            {
                Console.WriteLine("Réponse invalide ! Réessayez.");
                continue;
            }

            // Une flèche est consommée après un tir valide.
            remainingArrows--;

            if (reponse == "touche")
            {
                successfulShots++;
                Console.WriteLine("Bien joué ! Le cerf est touché.");
            }
            else
            {
                Console.WriteLine("Raté ! Le cerf s'est échappé de justesse.");
            }

            // Arrêter la chasse après 3 tirs réussis.
            if (successfulShots == 3)
            {
                Console.WriteLine("Le cerf est abattu !");
                break;
            }
        }

        // Afficher le bilan final.
        Console.WriteLine("\n===== BILAN DE LA CHASSE =====");
        Console.WriteLine("Tirs réussis : " + successfulShots);
        Console.WriteLine("Flèches restantes : " + remainingArrows);

        if (successfulShots == 3)
        {
            Console.WriteLine("Résultat : chasse réussie !");
        }
        else
        {
            Console.WriteLine("Résultat : chasse terminée, objectif non atteint.");
        }
    }
}