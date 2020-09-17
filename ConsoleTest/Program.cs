using System;
using SalarieDll;

namespace ConsoleTest
{
    class Program
    {

        static void Main(string[] args)
        {
            //DateTime Date19eme= new DateTime(2010, 11, 10);
            //DateTime DateDeNaissance = new DateTime(1984, 11, 10);
            //int age = DateTime.Now.Year - DateDeNaissance.Year;
            //Console.WriteLine(Salarie.MatriculeVerif("12aer56") == true);
            //Console.WriteLine(Salarie.PrenomVerif("romain") == true);
            //Console.WriteLine(Salarie.TauxVerif(0.4) == true);
            //Console.WriteLine(Salarie.DateNaissanceVerif(DateDeNaissance) == true);
            //Console.WriteLine(Salarie.DateNaissanceVerif(Date19eme) == true);
            //Console.WriteLine(DateDeNaissance);
            // Console.WriteLine(age);
            //Console.WriteLine("nb de salariés: {0}", Salarie.Compteur);
            //Salarie Salarie1 = new Salarie("12aze56", "sire", "romain");
            //Salarie salarie2 = new Salarie("12zer98", "picard", "fernand");
            //Salarie Salarie3 = new Salarie("12aze56", "durand", "Gilles");
            //Console.WriteLine(Salarie1.Matricule);
            // Console.WriteLine("prenom du salarié 2: {0}, nom: {1}, matricule: {2}",salarie2.Prenom, salarie2.Nom, salarie2.Matricule);

            //  Console.WriteLine("nb de salariés: {0}",Salarie.Compteur);
            // Console.WriteLine(Salarie1.ToString());
            Commercial commercial1 = new Commercial(100000, 0.25, "12aze65", "dupont", "roger", 50000, 0.1);
            Commercial commercial2 = new Commercial(100000, 0.50, "96azf00", "dupont", "roger", 50000, 0.1);
            Console.WriteLine(commercial1.CalculerSalaireNet());
            string test1 = commercial2.ToString();
            Console.WriteLine(test1);

        }
    }
}
