
# 🚗 Gestionnaire de Parc de Véhicules 🚗

Bienvenue dans l'application de gestion de parc de véhicules, développée en C# pour aider à gérer un parc automobile et faciliter les locations !  

## 📜 Description
Ce projet permet de :
- **Ajouter** des véhicules au parc 🚘.
- **Lister** tous les véhicules disponibles 📋.
- **Louer** un véhicule pour un client 🔑.
- **Rendre** un véhicule après son utilisation 🔄.

## 🛠️ Fonctionnalités principales
- Gestion intuitive d'un parc de véhicules.
- Sauvegarde et chargement des données à partir d'un fichier texte.
- Interface utilisateur en ligne de commande.

## ⚙️ Prérequis
1. **Système d'exploitation :** Windows, macOS ou Linux.
2. **Version de .NET :** .NET 9.0 . Assurez-vous que le SDK .NET est installé sur votre machine. Téléchargez-le [ici](https://dotnet.microsoft.com/download).
3. **Fichier requis :** Un fichier nommé `vehicules.txt` pour initialiser les données du parc. Ce fichier doit être placé dans le répertoire racine de l'application.

## 🚀 Lancement du projet
### 1️⃣ Cloner le dépôt
Cloner le projet sur votre machine locale avec :
```bash
git clone <URL_DU_DEPOT>
```

### 2️⃣ Compilation
Depuis le répertoire du projet, compilez-le avec :
```bash
dotnet build
```

### 3️⃣ Exécution
Pour exécuter le projet :
```bash
dotnet run
```

## 🧩 Structure du projet
- **Program.cs :** Contient le point d'entrée et le menu interactif de l'application.
- **GestionParc.cs :** Gère les actions sur le parc de véhicules (ajout, liste, location, retour).
- **Voiture.cs :** Définit la classe `Vehicule` avec ses attributs et méthodes.
- **vehicules.txt :** Fichier de sauvegarde des données.

## 📄 Exemple d'utilisation
Voici un exemple d'exécution :
1. Ajouter un véhicule : Fournissez les informations demandées (ID, constructeur, modèle, année).
2. Lister les véhicules : Affiche tous les véhicules disponibles.
3. Louer un véhicule : Entrez l'ID du véhicule souhaité.
4. Rendre un véhicule : Entrez l'ID du véhicule loué.

## 📂 Nomenclature des fichiers
- **TPFinalCsharp.csproj :** Fichier de projet pour le build .NET.
- **vehicules.txt :** Contient les données des véhicules sous format CSV.✨
