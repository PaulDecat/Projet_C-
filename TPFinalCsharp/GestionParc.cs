using System;
using System.Collections.Generic;
using System.IO;

namespace TPFinal
{
    public class GestionVehicules
    {
        private List<Vehicule> parcVehicules = new List<Vehicule>();

        public GestionVehicules()
        {
            ChargerVehiculesDepuisFichier("vehicules.txt");
        }

        public void ChargerVehiculesDepuisFichier(string cheminFichier)
{
    try
    {
        if (!File.Exists(cheminFichier))
        {
            Console.WriteLine($"Le fichier {cheminFichier} n'existe pas.");
            return;
        }

        var lignes = File.ReadAllLines(cheminFichier);
        foreach (var ligne in lignes)
        {
            try
            {
                var donnees = ligne.Split(',');
                if (donnees.Length != 4)
                {
                    Console.WriteLine($"Ligne mal formatée ignorée : {ligne}");
                    continue;
                }

                int id = int.Parse(donnees[0]);
                if (parcVehicules.Exists(v => v.Id == id))
                {
                    Console.WriteLine($"ID déjà existant ignoré : {id}");
                    continue;
                }

                string constructeur = donnees[1];
                string modele = donnees[2];
                int annee = int.Parse(donnees[3]);

                parcVehicules.Add(new Vehicule(id, constructeur, modele, annee));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du traitement de la ligne : {ligne}.");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur lors de la lecture du fichier : {ex.Message}");
    }
}

        public void AjouterVehicule(Vehicule vehicule)
        {
            parcVehicules.Add(vehicule);
            Console.WriteLine("Le véhicule a été ajouté au parc !");
        }

        public void ListerVehicules()
        {
            if (parcVehicules.Count == 0)
            {
                Console.WriteLine("\nAucun véhicule dans le parc.");
            }
            else
            {
                Console.WriteLine("\nListe des véhicules disponibles :");
                foreach (var vehicule in parcVehicules)
                {
                    vehicule.AfficherDetails();
                }
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

