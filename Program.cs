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

        int nombreFleches = 5;
        int touche = 0;
        int rate = 0;

        Console.WriteLine("La chasse commence, vous disposez de 5 flèches.");

        do

        {
            Console.WriteLine("Il vous reste " + nombreFleches + " flèches.");
            Console.WriteLine("Entrez 'touche' pour toucher ou 'rate' pour rater: ");
            string reponse = Console.ReadLine();

            if (reponse == "touche")
            {
                Console.WriteLine("Bien joué, vous avez touché le cerf !");
                touche++;
                nombreFleches--;
            }
            else if (reponse == "rate")
            {
                Console.WriteLine("Le cerf s'échappe de justesse !");
                rate++;
                nombreFleches--;
            }
            if (reponse != "touche" || reponse != "rate")
            {
                Console.WriteLine("Votre réponse ne correspond pas, veuiller réessayer.");
            }

        } while (nombreFleches <= 0 || touche <= 3);

        if (touche == 3)
        {
            Console.WriteLine("Le cerf est abbatu !");
        }
        else
        {
            Console.WriteLine("Le cerf s'est échappé !");
        }

        Console.WriteLine("==== Bilan de la chasse ====");
        Console.WriteLine("Nombre de tirs réussis : " + touche);
        Console.WriteLine("Nombre de flèches restantes : " + nombreFleches);
        if (touche == 3)
        {
            Console.WriteLine("Résultat : Chasse réussie !");
        }
        else
        {
            Console.WriteLine("Résultat : Chasse échouée !");
        }
    }
}