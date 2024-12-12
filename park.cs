using System;
using System.Collections.Generic;
using System.Linq;

public class ParcAutomobile
    {
        private List<Voiture> voitures = new List<Voiture>();
        private int prochainId = 1;

        public void AjouterVoiture(string marque, string modele, int annee)
        {
            var voiture = new Voiture(prochainId++, marque, modele, annee);
            voitures.Add(voiture);
            Console.WriteLine($"Voiture ajoutée : {marque} {modele} ({annee}). ID: {voiture.Id}");
        }

        public void ListerVoitures()
        {
            if (!voitures.Any())
            {
                Console.WriteLine("Aucune voiture dans le parc.");
                return;
            }

            foreach (var voiture in voitures)
            {
                voiture.AfficherInfos();
            }
        }

        public void LouerVoiture(int id)
        {
            var voiture = voitures.FirstOrDefault(v => v.Id == id);
            if (voiture != null)
            {
                voiture.Louer();
            }
            else
            {
                Console.WriteLine("Voiture introuvable.");
            }
        }

        public void RendreVoiture(int id)
        {
            var voiture = voitures.FirstOrDefault(v => v.Id == id);
            if (voiture != null)
            {
                voiture.Rendre();
            }
            else
            {
                Console.WriteLine("Voiture introuvable.");
            }
        }
    }