using System;
using System.Collections.Generic;
					
public class Program
{
	struct Livre {
		public string titre;
		public string auteur;
		public int annee;
		public int pages;
		public bool EstDisponnible;
	}
	
	public static void Main()
	{
		Livre livre1 = new Livre();
		livre1.titre = "njqznjd";
		livre1.auteur = "qznjdnklqz";
		livre1.annee = 2000;
		livre1.pages = 5385;
		livre1.EstDisponnible = true;
		
		Livre livre2 = new Livre();
		livre2.titre = "aku";
		livre2.auteur = "plftlphf";
		livre2.annee = 2040;
		livre2.pages = 400;
		livre2.EstDisponnible = false;
		
		Livre livre3 = new Livre();
		livre3.titre = "aka";
		livre3.auteur = "f:tmhmft";
		livre3.annee = 2020;
		livre3.pages = 2;
		livre3.EstDisponnible = true;
		
		
		List<Livre> livres = new List<Livre>();
		livres.Add(livre1);
		livres.Add(livre2);
		livres.Add(livre3);
		
		int totalpages = 0;
		int totallivres = 0;
		
		foreach (Livre livre in livres) {
			if (livre.EstDisponnible == true && livre.pages >= 300 && livre.annee > 2000) Console.WriteLine($"{livre.titre}, {livre.auteur}, {livre.annee}");
			totalpages+=livre.pages;
			totallivres+=1;
		}
		
		Console.WriteLine($"La bibliothèque contient {totalpages} pages\nLa bibliothèque contient {totallivres} livres");
		
		int choix = 0;
		while (choix != 6) {
			Console.WriteLine("1. Afficher tous les livres\n2. Afficher les livres disponibles\n3. Rechercher un livre\n4. Emprunter un livre\n5. Ajouté un nouveau livre\n6. Quitter");
			choix = int.Parse(Console.ReadLine());
			
			switch(choix) {
				case 1:
					list(livres);
					break;
				case 2:
					listDispo(livres);
					break;
				case 3:
					recherche(livres);
					break;
				case 4:
					emprunt(livres);
					break;
				case 5:
					ajout(livres);
					break;
				case 6:
					break;
			}
		}
	}
	
	static void recherche(List<Livre> livres) {
		Console.WriteLine("Saisissez un titre : ");
		string titre = Console.ReadLine();
		
		string a = "qzd";
		
		foreach (Livre livre in livres) {
			if (livre.titre == titre) a = $"{livre.titre}, {livre.auteur}, {livre.annee}";
		}
		
		if (a == "qzd") Console.WriteLine("Livre introuvable");
		else Console.WriteLine(a);
	}
	
	static void emprunt(List<Livre> livres) {
		Console.WriteLine("Quel titre souhaitez-vous emprunter : ");
		string titre = Console.ReadLine();

		int index = livres.FindIndex(l => l.titre == titre);

		if (index == -1) {
			Console.WriteLine("Livre introuvable");
			return;
		}

		Livre copie = livres[index];
		if (!copie.EstDisponnible) {
			Console.WriteLine("Emprunt impossible");
			return;
		}

		copie.EstDisponnible = false;
		livres[index] = copie;

		Console.WriteLine($"{copie.titre}, {copie.auteur}, {copie.annee} -> Emprunt validé");
	}
	
	static void ajout(List<Livre> livres) {
		Livre nouveau = new Livre();
		
		Console.WriteLine("Entrez le nom du livre : ");
		string titre = Console.ReadLine();
		nouveau.titre = titre;
		
		Console.WriteLine("Entrez l'auteur du livre : ");
		string auteur = Console.ReadLine();
		nouveau.auteur = auteur;
		
		Console.WriteLine("Entrez l'annee du livre : ");
		int annee = int.Parse(Console.ReadLine());
		nouveau.annee = annee;
		
		Console.WriteLine("Entrez le nombre de pages que possède le livre : ");
		int pages = int.Parse(Console.ReadLine());
		nouveau.pages = pages;
		
		Console.WriteLine("Est-ce que le libre est disponnible ? (oui/non) : ");
		string dispo = Console.ReadLine();
		nouveau.EstDisponnible = (dispo == "oui" ? true : false);
		
		livres.Add(nouveau);
		Console.WriteLine("Livre ajouté !");
	}
	
	static void list(List<Livre> livres) {
		foreach (Livre livre in livres)	{
			Console.WriteLine($"Titre : {livre.titre}, Auteur : {livre.auteur}, Année : {livre.annee}");
		}
	}
	
	static void listDispo(List<Livre> livres) {
		foreach (Livre livre in livres)	{
			if (livre.EstDisponnible == true) Console.WriteLine($"Titre : {livre.titre}, Auteur : {livre.auteur}, Année : {livre.annee}");
		}
	}

}