using System;

class Program
{

    class Compte
    {
        public string nom {get; set;}
        public int numero { get; set; }
        public int solde { get; set; }
    }
    static void Main(string[] args)
    {
        Compte c1 = new Compte() { numero = 1, nom = "feur", solde = 9999 };
        Compte c2 = new Compte() { numero = 2, nom = "kqzd", solde = 99 };
        Compte c3 = new Compte() { numero = 3, nom = "fffffffffff", solde = 999 };
        Compte c4 = c1;

        if (c1.solde > 0) c1.solde += 500;
        if ((c4.solde - 100) < 0) c4.solde -= 100;

        List<Compte> comptes = new List<Compte>();
        comptes.Add(c1);
        comptes.Add(c2);
        comptes.Add(c3);
        comptes.Add(c4);

        foreach (var compte in comptes)
        {
            Console.WriteLine($"Nom : {compte.nom}\nNuméro : {compte.numero}\nSolde : {compte.solde}\n\n");
        }
    }
}