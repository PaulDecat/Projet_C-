using System;

namespace TPFinal
{
    public class Vehicule
    {
        public int Id { get; set; }
        public string Constructeur { get; set; }
        public string Modele { get; set; }
        public int AnneeDeFabrication { get; set; }
        public string Disponibilite { get; set; }

        public Vehicule(int id, string constructeur, string modele, int anneeDeFabrication)
        {
            Id = id;
            Constructeur = constructeur;
            Modele = modele;
            AnneeDeFabrication = anneeDeFabrication;
            Disponibilite = "Disponible";
        }

        public void AfficherDetail()
        {
            Console.WriteLine($"ID: {Id}, Constructeur: {Constructeur}, Modele: {Modele}, Année: {AnneeDeFabrication}, Disponibilité: {Disponibilite}");
        }
    }
}

