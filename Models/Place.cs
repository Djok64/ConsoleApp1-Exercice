namespace ConsoleApp1.Models
{
  // Définition de la classe Place
  public class Place
  {
    // Propriétés de la place
    public int Numero { get; set; } // Numéro de la place
    public bool EstReservee { get; set; } // Indique si la place est réservée ou non
    public string? NomReservation { get; set; } // Nom du réservant (peut être null si la place n'est pas réservée)

    // Constructeur de la classe Place
    public Place(int numero)
    {
      Numero = numero; // Initialise le numéro de la place avec la valeur passée en paramètre
      EstReservee = false; // Initialise EstReservee à false car la place n'est pas encore réservée
    }

    // Méthode pour réserver la place avec un nom de réservant
    public void Reservation(string? nom)
    {
      NomReservation = nom; // Stocke le nom du réservant dans la propriété NomReservation
      EstReservee = true; // Met à jour EstReservee à true pour indiquer que la place est réservée
    }

    // Méthode pour annuler la réservation de la place
    public void Annulation()
    {
      NomReservation = ""; // Efface le nom du réservant en mettant la propriété NomReservation à une chaîne vide
      EstReservee = false; // Met à jour EstReservee à false pour indiquer que la place n'est plus réservée
    }
  }
}
