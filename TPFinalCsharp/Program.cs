using System;

namespace TPFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionVehicules gestionVehicules = new GestionVehicules();
            int choix;

            do
            {
                Console.WriteLine("\n🚗 Bienvenue dans le gestionnaire de véhicules 🚗");
                Console.WriteLine("Que souhaitez-vous faire ?");
                Console.WriteLine("1. ➕ Ajouter un nouveau véhicule au parc");
                Console.WriteLine("2. 📋 Afficher la liste des véhicules");
                Console.WriteLine("3. 🔑 Louer un véhicule");
                Console.WriteLine("4. 🔄 Retourner un véhicule");
                Console.WriteLine("5. ❌ Quitter l'application");
                Console.Write("Veuillez saisir votre choix : ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        Console.WriteLine("\n--- Ajout d'un nouveau véhicule ---");
                        Console.Write("Entrez l'ID du véhicule : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Entrez le constructeur (ex. Renault, BMW) : ");
                        string constructeur = Console.ReadLine();
                        Console.Write("Entrez le modèle (ex. Clio, X3) : ");
                        string modele = Console.ReadLine();
                        Console.Write("Entrez l'année de fabrication : ");
                        int anneeDeFabrication = int.Parse(Console.ReadLine());
                        gestionVehicules.AjouterVehicule(new Vehicule(id, constructeur, modele, anneeDeFabrication));
                        Console.WriteLine("Le véhicule a été ajouté avec succès !");
                        break;

                    case 2:
                        Console.WriteLine("\n--- Liste des véhicules disponibles ---");
                        gestionVehicules.ListerVehicules();
                        break;

                    case 3:
                        Console.WriteLine("\n--- Location de véhicule ---");
                        Console.Write("Entrez l'ID du véhicule que vous souhaitez louer : ");
                        int idLouer = int.Parse(Console.ReadLine());
                        gestionVehicules.LouerVehicule(idLouer);
                        break;

                    case 4:
                        Console.WriteLine("\n--- Retour d'un véhicule ---");
                        Console.Write("Entrez l'ID du véhicule que vous souhaitez retourner : ");
                        int idRendre = int.Parse(Console.ReadLine());
                        gestionVehicules.RendreVehicule(idRendre);
                        break;

                    case 5:
                        Console.WriteLine("\nMerci d'avoir utilisé le gestionnaire de véhicules. À bientôt !");
                        break;

                    default:
                        Console.WriteLine("\nChoix invalide. Veuillez entrer un numéro entre 1 et 5.");
                        break;
                }
            } while (choix != 5);
        }
    }
}



