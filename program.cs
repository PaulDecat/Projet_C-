using System;

namespace GestionLocation
{
    class Program
    {
        static void Main(string[] args)
        {
            Parc parc = new Parc();
            int choix;

            do
            {
                Console.WriteLine("Gestion du Parc:");
                Console.WriteLine("1. Ajouter une voiture");
                Console.WriteLine("2. Lister les voitures");
                Console.WriteLine("3. Louer une voiture");
                Console.WriteLine("4. Rendre une voiture");
                Console.WriteLine("5. Quitter");
                Console.Write("Quelle est votre choix : ");

                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        Console.Write("ID de la voiture : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Marque de la voiture: ");
                        string marque = Console.ReadLine();
                        Console.Write("Modèle de la voiture : ");
                        string modele = Console.ReadLine();
                        Console.Write("Année de la voiture : ");
                        int annee = int.Parse(Console.ReadLine());

                        parc.AjouterVoiture(new Voiture(id, marque, modele, annee));
                        break;

                    case 2:
                        parc.ListerVoitures();
                        break;

                    case 3:
                        Console.Write("Voiture à louer : ");
                        int idLouer = int.Parse(Console.ReadLine());
                        parc.LouerVoiture(idLouer);
                        break;

                    case 4:
                        Console.Write("Voiture à rendre: ");
                        int idRendre = int.Parse(Console.ReadLine());
                        parc.RendreVoiture(idRendre);
                        break;

                    case 5:
                        Console.WriteLine("Au revoir !");
                        break;

                    default:
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        break;
                }

            } while (choix != 5);
        }
    }
}