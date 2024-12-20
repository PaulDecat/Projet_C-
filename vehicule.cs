using System;

namespace LocationVehicules
{
    public class Vehicule
    {
        public int Id { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Annee { get; set; }
        public string Statut { get; set; } // "Disponible", "Loué"

        public Vehicule(int id, string marque, string modele, int annee)
        {
            Id = id;
            Marque = marque;
            Modele = modele;
            Annee = annee;
            Statut = "Disponible";
        }

        public void AfficherInfo()
        {
            Console.WriteLine($"ID: {Id}, Marque: {Marque}, Modèle: {Modele}, Année: {Annee}, Statut: {Statut}");
        }
    }
}
