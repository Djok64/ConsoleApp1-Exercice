using System.Linq.Expressions; // Importation du namespace System.Linq.Expressions pour utiliser List<T>

namespace ConsoleApp1.Models
{
  // Définition de la classe Theatre
  public class Theatre
  {
    // Propriété pour stocker la liste des rangs du théâtre
    public List<Rang> ListRangs { get; set; }

    // Constructeur de la classe Theatre
    public Theatre(int[] nombrePlaceParRang)
    {
      ListRangs = new List<Rang>(); // Initialisation de la liste des rangs

      // Boucle pour créer et ajouter les rangs à la liste en fonction du nombre de places par rang
      for (int i = 0; i < nombrePlaceParRang.Length; i++)
      {
        char lettreRang = (char)(i + 65); // Calcul de la lettre du rang à partir de son index
        Rang rang = new Rang(nombrePlaceParRang[i], lettreRang); // Création d'un nouveau rang
        ListRangs.Add(rang); // Ajout du rang à la liste
      }
    }

    // Méthode pour ajouter un rang à la liste des rangs du théâtre
    public void AjouterRang(Rang rang)
    {
      ListRangs.Add(rang); // Ajout du rang à la liste
    }

    // Méthode pour obtenir une représentation textuelle du théâtre
    public override string ToString()
    {
      string tmp = ""; // Variable temporaire pour stocker la représentation textuelle du théâtre

      // Boucle pour concaténer les représentations textuelles de chaque rang dans la variable temporaire
      foreach (Rang rang in ListRangs)
      {
        tmp += rang.ToString(); // Ajout de la représentation textuelle du rang
      }

      return tmp; // Retourne la représentation textuelle complète du théâtre
    }
  }
}
