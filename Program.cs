using ConsoleApp1.Models; // Importation du namespace contenant les classes nécessaires
                          // Affichage d'un message de bienvenue
Console.WriteLine("Salut mamennn !");
// Demande à l'utilisateur son nom et le stocke dans une variable
Console.WriteLine("Entrez votre nom : ");
string? nom = Console.ReadLine();
// Affichage d'un message de salutation avec le nom de l'utilisateur
Console.WriteLine($"Bonjour, {nom} !");

// Création d'un objet Theatre avec plusieurs rangs et un nombre de places par rang
int[] nombrePlacesParRang = { 10, 15, 20 }; // Exemple de nombre de places par rang
Theatre theatre = new Theatre(nombrePlacesParRang);

// Exemple de réservation d'une place précise (par exemple, rang A, place 5)
char lettreRang = 'D'; // Lettre du rang de la place à réserver
int numeroPlace = 5; // Numéro de la place à réserver

// Recherche du rang correspondant à la lettre spécifiée
Rang? rang = theatre.ListRangs.Find(r => r.LettreRang == lettreRang);
if (rang != null) // Vérifie si le rang a été trouvé
{
  // Recherche de la place correspondant au numéro spécifié dans le rang trouvé
  Place? place = rang!.ListPlaces!.Find(p => p.Numero == numeroPlace);
  if (place != null) // Vérifie si la place a été trouvée
  {
    // Réservation de la place avec le nom du réservant
    place.Reservation(nom);
    // Affichage d'un message de confirmation de réservation
    Console.WriteLine($"La place {numeroPlace} dans le rang {lettreRang} a été réservée par {nom}.");
  }
  else
  {
    // Affichage d'un message d'erreur si la place n'existe pas dans le rang spécifié
    Console.WriteLine($"La place {numeroPlace} dans le rang {lettreRang} n'existe pas.");
  }
}
else
{
  // Affichage d'un message d'erreur si le rang spécifié n'existe pas dans le théâtre
  Console.WriteLine($"Le rang {lettreRang} n'existe pas dans ce théâtre.");
}

// Attente de la pression d'une touche avant de fermer la console
Console.ReadLine();
