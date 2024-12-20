using System;
using System.Collections.Generic;

namespace TPFinal
{
    public class GestionVehicules
    {
        private List<Vehicule> parcVehicules = new List<Vehicule>();

        public void AjouterVehicule(Vehicule vehicule)
        {
            parcVehicules.Add(vehicule);
            Console.WriteLine("Le véhicule a été ajouté au parc !");
        }

        public void ListerVehicules()
        {
            Console.WriteLine("\nListe des véhicules disponibles :");
            foreach (var vehicule in parcVehicules)
            {
                vehicule.AfficherDetails();
            }
        }

        public void LouerVehicule(int id)
        {
            foreach (var vehicule in parcVehicules)
            {
                if (vehicule.Id == id && vehicule.Disponibilite == "Disponible")
                {
                    vehicule.Disponibilite = "Loué";
                    Console.WriteLine("Le véhicule a été loué avec succès !");
                    return;
                }
            }
            Console.WriteLine("Véhicule introuvable ou déjà loué.");
        }

        public void RendreVehicule(int id)
        {
            foreach (var vehicule in parcVehicules)
            {
                if (vehicule.Id == id && vehicule.Disponibilite == "Loué")
                {
                    vehicule.Disponibilite = "Disponible";
                    Console.WriteLine("Le véhicule a été rendu !");
                    return;
                }
            }
            Console.WriteLine("Véhicule introuvable ou déjà disponible.");
        }
    }
}

