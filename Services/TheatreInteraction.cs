using System;
using ConsoleApp1.Models;
//ce code ne fonctionne pas cest un exemple de ce qu'il faudra implémenter plus tard  ce fichier recuillera la logique d'interaction avec lutilisateur 
namespace ConsoleApp1.Services
{
  public class TheatreInteraction
  {
    // Une méthode statique pour demander à l'utilisateur de saisir le nombre de rangs qu'il souhaite créer dans le théâtre.
    public static int DemanderNombreRangs()
    {
      Console.WriteLine("Combien de rangs de places souhaitez-vous créer ?");

      // Déclaration d'une variable pour stocker le nombre de rangs.
      int nombreRangs;

      // Utilisation d'une boucle while pour s'assurer que l'utilisateur entre un nombre valide.
      // Si la saisie de l'utilisateur ne peut pas être convertie en un entier ou si le nombre est inférieur ou égal à zéro, on redemande à l'utilisateur de saisir une valeur valide.
      while (!int.TryParse(Console.ReadLine(), out nombreRangs) || nombreRangs <= 0)
      {
        Console.WriteLine("Veuillez entrer un nombre valide.");
      }

      // Une fois que l'utilisateur a entré un nombre valide, la méthode retourne ce nombre de rangs.
      return nombreRangs;
    }

    // Une méthode statique pour afficher un récapitulatif du théâtre.
    public static void AfficherRecapitulatif(Theatre theatre)
    {
      // Affichage d'un message d'introduction pour le récapitulatif.
      Console.WriteLine("Récapitulatif :");

      // Affichage de la représentation textuelle du théâtre, qui sera obtenue en appelant la méthode ToString() de l'objet Theatre.
      Console.WriteLine(theatre);
    }

    // D'autres méthodes pour gérer les interactions avec l'utilisateur peuvent être ajoutées ici...
  }
}

