using System;

namespace LocationVehicules
{
    class Program
    {
        static void Main(string[] args)
        {
            Park parc = new Park();
            int choix;

            do
            {
                Console.WriteLine("\n--- Menu de gestion du parc ---");
                Console.WriteLine("1. Ajouter un véhicule");
                Console.WriteLine("2. Lister les véhicules");
                Console.WriteLine("3. Louer un véhicule");
                Console.WriteLine("4. Rendre un véhicule");
                Console.WriteLine("0. Quitter");
                Console.Write("Votre choix : ");

                if (!int.TryParse(Console.ReadLine(), out choix))
                {
                    Console.WriteLine("Veuillez entrer un numéro valide.");
                    continue;
                }

                switch (choix)
                {
                    case 1:
                        Console.Write("ID : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Marque : ");
                        string marque = Console.ReadLine();
                        Console.Write("Modèle : ");
                        string modele = Console.ReadLine();
                        Console.Write("Année : ");
                        int annee = int.Parse(Console.ReadLine());
                        parc.AjouterVehicule(id, marque, modele, annee);
                        break;

                    case 2:
                        parc.ListerVehicules();
                        break;

                    case 3:
                        Console.Write("ID du véhicule à louer : ");
                        int idLouer = int.Parse(Console.ReadLine());
                        parc.LouerVehicule(idLouer);
                        break;

                    case 4:
                        Console.Write("ID du véhicule à rendre : ");
                        int idRendre = int.Parse(Console.ReadLine());
                        parc.RendreVehicule(idRendre);
                        break;

                    case 0:
                        Console.WriteLine("Au revoir !");
                        break;

                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }
            } while (choix != 0);
        }
    }
}
