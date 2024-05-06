using System.Text.RegularExpressions; // Importation du namespace System.Text.RegularExpressions pour utiliser List<T>

namespace ConsoleApp1.Models
{
  // Définition de la classe Rang
  public class Rang
  {
    // Propriétés de la classe Rang
    public char LettreRang { get; set; } // Lettre du rang
    public List<Place> ListPlaces { get; set; } // Liste des places dans le rang

    // Constructeur de la classe Rang
    public Rang(int nombrePlaces, char lettreDuRang)
    {
      ListPlaces = new List<Place>(); // Initialisation de la liste des places

      // Boucle pour créer et ajouter les places au rang en fonction du nombre de places spécifié
      for (int i = 1; i <= nombrePlaces; i++)
      {
        ListPlaces.Add(new Place(i)); // Création d'une nouvelle place et ajout à la liste des places
      }

      LettreRang = lettreDuRang; // Initialisation de la lettre du rang
    }

    // Méthode pour ajouter une place au rang
    public void AjouterPlace(Place place)
    {
      ListPlaces.Add(place); // Ajout de la place à la liste des places du rang
    }

    // Méthode pour obtenir le nombre de places réservées dans le rang
    public int NombrePlacesReservees()
    {
      int nombreReservees = 0; // Variable pour stocker le nombre de places réservées

      // Boucle pour compter le nombre de places réservées dans la liste des places du rang
      foreach (var place in ListPlaces)
      {
        if (place.EstReservee)
        {
          nombreReservees++; // Incrémentation du compteur si la place est réservée
        }
      }

      return nombreReservees; // Retourne le nombre de places réservées
    }

    // Méthode pour obtenir le nombre de places libres dans le rang
    public int NombrePlacesLibre()
    {
      int nombreLibres = 0; // Variable pour stocker le nombre de places libres

      // Boucle pour compter le nombre de places libres dans la liste des places du rang
      foreach (var place in ListPlaces)
      {
        if (!place.EstReservee)
        {
          nombreLibres++; // Incrémentation du compteur si la place n'est pas réservée
        }
      }

      return nombreLibres; // Retourne le nombre de places libres
    }

    // Méthode pour obtenir une représentation textuelle du rang
    public override string ToString()
    {
      return "Rang " + LettreRang + " : nombre de places = " + ListPlaces.Count; // Retourne une chaîne représentant le rang
    }
  }
}
