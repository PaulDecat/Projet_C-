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
                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine("1. ➕ Ajouter un nouveau véhicul au parc");
                Console.WriteLine("2. 📋 Afficher la liste des véhicules");
                Console.WriteLine("3. 🔑 Louer un véhicule");
                Console.WriteLine("4. 🔄 Retourner un véhicule");
                Console.WriteLine("5. ❌ Quitter l'application");
                Console.Write("Veuillez saisir votre choix : ");

                
                while (!int.TryParse(Console.ReadLine(), out choix))
                {
                    Console.WriteLine("❌ Entrée invalide. Veuillez entrer un chiffre entre 1 et 5.");
                    Console.Write("Veuillez saisir votre choix : ");
                }

                switch (choix)
                {
                    case 1:
                        Console.WriteLine("---Ajout d'un nouveau véhicule---");

                        int id;
                        Console.Write("ID du véhicule : ");
                        while (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("❌ Entrée invalide. Veuillez entrer un nombre entier pour l'ID.");
                            Console.Write("ID du vehicule: ");
                        }

                        Console.Write("Constructeur de la voiture : ");
                        string constructeur = Console.ReadLine();

                        Console.Write("Modèle de la voiture: ");
                        string modele = Console.ReadLine();

                        int anneeDeFabrication;
                        Console.Write("Année de fabrication : ");
                        while (!int.TryParse(Console.ReadLine(), out anneeDeFabrication))
                        {
                            Console.WriteLine("❌ Entrée invalide. Veuillez entrer un nombre entier pour l'année de fabrication.");
                            Console.Write("Année de fabrication : ");
                        }

                        gestionVehicules.AjouterVehicule(new Vehicule(id, constructeur, modele, anneeDeFabrication));
                        Console.WriteLine("✅ Le véhicule a été ajouté avec succès !");
                        break;

                    case 2:
                        Console.WriteLine("\n---Liste des véhicules disponibles---");
                        gestionVehicules.ListerVehicules();
                        break;

                    case 3:
                        Console.WriteLine("\n---Location de véhicule---");

                        int idLouer;
                        Console.Write("ID du véhicule à louer : ");
                        while (!int.TryParse(Console.ReadLine(), out idLouer))
                        {
                            Console.WriteLine("❌ Entrée invalide. Veuillez entrer un nombre entier pour l'ID.");
                            Console.Write("ID du véhicule à louer : ");
                        }

                        gestionVehicules.LouerVehicule(idLouer);
                        break;

                    case 4:
                        Console.WriteLine("\n---Retour d'un véhicule---");

                        int idRendre;
                        Console.Write("ID du véhicule à retourner : ");
                        while (!int.TryParse(Console.ReadLine(), out idRendre))
                        {
                            Console.WriteLine("❌ Entrée invalide. Veuillez entrer un nombre entier pour l'ID.");
                            Console.Write("ID du véhicule à retourner : ");
                        }

                        gestionVehicules.RendreVehicule(idRendre);
                        break;

                    case 5:
                        Console.WriteLine("\nMerci d'avoir utilisé le gestionnaire de véhicule. À bientôt !");
                        break;

                    default:
                        Console.WriteLine("\n❌ Choix invalide. Veuillez entrer un numéro entre 1 et 5.");
                        break;
                }

            } while (choix != 5);
        }
    }
}
