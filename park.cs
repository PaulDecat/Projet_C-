using System;
using System.Collections.Generic;
using System.Linq;

namespace LocationVehicules
{
    public class Park
    {
        private List<Vehicule> vehicules;
        private static readonly List<string> MarquesPredefinies = new List<string> { "Toyota", "Renault", "Peugeot", "Ford", "BMW" };

        public Park()
        {
            vehicules = new List<Vehicule>();
        }

        public void AjouterVehicule(int id, string marque, string modele, int annee)
        {
            if (!MarquesPredefinies.Contains(marque))
            {
                Console.WriteLine($"Erreur : La marque '{marque}' n'est pas dans la liste prédéfinie.");
                return;
            }

            Vehicule vehicule = new Vehicule(id, marque, modele, annee);
            vehicules.Add(vehicule);
            Console.WriteLine("Véhicule ajouté avec succès.");
        }

        public void ListerVehicules()
        {
            if (vehicules.Count == 0)
            {
                Console.WriteLine("Aucun véhicule dans le parc.");
                return;
            }

            foreach (var vehicule in vehicules)
            {
                vehicule.AfficherInfo();
            }
        }

        public void LouerVehicule(int id)
        {
            var vehicule = vehicules.FirstOrDefault(v => v.Id == id);
            if (vehicule == null)
            {
                Console.WriteLine("Erreur : Véhicule introuvable.");
                return;
            }

            if (vehicule.Statut == "Loué")
            {
                Console.WriteLine("Erreur : Ce véhicule est déjà loué.");
                return;
            }

            vehicule.Statut = "Loué";
            Console.WriteLine("Véhicule loué avec succès.");
        }

        public void RendreVehicule(int id)
        {
            var vehicule = vehicules.FirstOrDefault(v => v.Id == id);
            if (vehicule == null)
            {
                Console.WriteLine("Erreur : Véhicule introuvable.");
                return;
            }

            if (vehicule.Statut == "Disponible")
            {
                Console.WriteLine("Erreur : Ce véhicule n'est pas actuellement loué.");
                return;
            }

            vehicule.Statut = "Disponible";
            Console.WriteLine("Véhicule rendu avec succès.");
        }
    }
}
