using System;
using Véhicule;

class Parc {
    public string nom;
    public int capacite;
    public int nbvoituresactuel;
    public Parc(string nom, int capacite, int nbvoituresactuel) {
        this.nom = nom;
        this.capacite = capacite;
        this.nbvoituresactuel = nbvoituresactuel;
    }

    public static void AjouterVoiture() {
        nbvoituresactuel = nbvoituresactuel + 1;
        if nbvoituresactuel => capacite{
            Console.WriteLine($"Le parc {nom} est plein.");
        }
    }

    public static ListerVoitures(){
        List<Voiture> voitures = new List<Voiture>();
        return voitures;
    }

    public static LouerVoiture(){
        nbvoituresactuel = nbvoituresactuel - 1;
        if nbvoituresactuel <= 0 {
            Console.WriteLine($"Le parc {nom} est vide.");

        }
    }

    public static RendreVoiture(){
        nbvoituresactuel = nbvoituresactuel + 1;
    }
}