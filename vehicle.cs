public class Véhicule {
    public int Id;
    public string Marque;
    public string Modele;
    public int Annee;
    public string Statut;

    public Véhicule(int id, string marque, string modele, int annee, string statut) {
        Id = id;
        Marque = marque;
        Modele = modele;
        Annee = annee;
        Statut = statut;
    }

    public static void afficher() {
        Console.WriteLine(ID | Marque | Modèle | Année | Statut);
    }
}