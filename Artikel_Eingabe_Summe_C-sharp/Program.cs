using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artikel_Eingabe_Summe_C_sharp
{
	class Program
	{	// TODO: Fehler Abfangen, Kommazahlen bei Preisen und Summen(Euro) ermöglichen, €-Zeichen...
		static void Main(string[] args)
		{
		string art1 = "";
		string art2 = "";
		string art3 = "";
		int anzArt1 = 0;
		int anzArt2 = 0;
		int anzArt3 = 0;
		int preisArt1 = 0;	//double verwenden! @ Preisen, Summen
		int preisArt2 = 0;
		int preisArt3 = 0;
		int summeArt123Anz = 0;
		int summeArt1 = 0;
		int summeArt2 = 0;
		int summeArt3 = 0;
		int summeArt123 = 0;
		
		int anzahlArtikel;

		Console.Write("Bitte geben sie die Anzahl der Artikel ein: ");
		anzahlArtikel = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("_________________________________________________");
		

			for (int i = 0; i < anzahlArtikel; i++)
			{
				if (i == 0)
				{
					Console.WriteLine("Bitte geben sie den Namen des {0}. Artikels ein: ", i+1);
					art1 = Console.ReadLine();
				}
				if (i == 1)
				{
					Console.WriteLine("Bitte geben sie den Namen des {0}. Artikels ein: ", i+1);
					art2 = Console.ReadLine();
				}
				if (i == 2)
				{
					Console.WriteLine("Bitte geben sie den Namen des {0}. Artikels ein: ", i+1);
					art3 = Console.ReadLine();
				}
			}
			Console.WriteLine();
			Console.WriteLine("Bitte geben sie nun die Menge der Artikel ein:");
			Console.WriteLine("_________________________________________________");	
			for (int i = 0; i < anzahlArtikel; i++)
			{
				if (i == 0)
				{
					Console.WriteLine("Bitte geben sie die Menge des {0}. Artikels ein: ", i+1);
					anzArt1 = Convert.ToInt32(Console.ReadLine());
				}
				if (i == 1)
				{
					Console.WriteLine("Bitte geben sie die Menge des {0}. Artikels ein: ", i+1);
					anzArt2 = Convert.ToInt32(Console.ReadLine());
				}
				if (i == 2)
				{
					Console.WriteLine("Bitte geben sie die Menge des {0}. Artikels ein: ", i+1);
					anzArt3 = Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine();
			Console.WriteLine("Bitte geben sie nun die Einzelpreise der Artikel ein:");
			Console.WriteLine("_________________________________________________");
			for (int i = 0; i < anzahlArtikel; i++)
			{
				if (i == 0)
				{
					Console.WriteLine("Bitte geben sie den Einzelpreis des {0}. Artikels ein: ", i+1);
					preisArt1 = Convert.ToInt32(Console.ReadLine());
				}
				if (i == 1)
				{
					Console.WriteLine("Bitte geben sie den Einzelpreis des {0}. Artikels ein: ", i+1);
					preisArt2 = Convert.ToInt32(Console.ReadLine());
				}
				if (i == 2)
				{
					Console.WriteLine("Bitte geben sie den Einzelpreis des {0}. Artikels ein: ", i+1);
					preisArt3 = Convert.ToInt32(Console.ReadLine());
				}
			}
			// VERARBEITUNG
			// Berechnung der Summe der Artikel
			summeArt1 = anzArt1 * preisArt1;
			summeArt2 = anzArt2 * preisArt2;
			summeArt3 = anzArt3 * preisArt3;
			summeArt123Anz = anzArt1 + anzArt2 + anzArt3;
			summeArt123 = summeArt1 + summeArt2 + summeArt3;

			// AUSGABE
			Console.WriteLine("_________________________________________________");
			// hier if einbauen!
			Console.WriteLine("Artikel: {0} | Menge: {1} | Preis {2} | SummePosten {3}", art1, anzArt1, preisArt1, summeArt1);
			Console.WriteLine("Artikel: {0} | Menge: {1} | Preis {2} | SummePosten {3}", art2, anzArt2, preisArt2, summeArt2);
			Console.WriteLine("Artikel: {0} | Menge: {1} | Preis {2} | SummePosten {3}", art3, anzArt3, preisArt3, summeArt3);
			Console.WriteLine("-----------------------------------------------------------------------");
			Console.WriteLine("-----------------------------------------------------------------------");
			Console.WriteLine("Die Gesamtanzahl der Artikel beläuft sich auf: {0} Stück",summeArt123Anz);
			Console.WriteLine("-----------------------------------------------------------------------");
			Console.WriteLine("Die Gesamtsumme(Brutto) der Artikel beläuft sich auf: {0}Euro",summeArt123);
			Console.WriteLine("Die Gesamtsumme(Netto) der Artikel beläuft sich auf: {0}Euro",summeArt123*1.19);
			Console.WriteLine("-----------------------------------------------------------------------");
			Console.Read();
		}
	}
}
