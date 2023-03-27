using System;
namespace TestOOP
{
	public class Zvire
	{
		private string Nazev { get; set; }
		private int Vek { get; set; }
		private double Vaha { get; set; }
		

		public Zvire(string nazev,int vek, double vaha)
		{
			Nazev = nazev;
			Vek = vek;
			Vaha = vaha;
			
		}

		public void VypisDatOZvireti()
		{
			//Console.WriteLine("Vypis dat o zvireti");
			Console.WriteLine($"\tNazev: {Nazev}");
            Console.WriteLine($"\tVek: {Vek}");
            Console.WriteLine($"\tVaha: {Vaha}");
        }

		public void PrepsatNazev(string nazev)
		{
			Nazev = nazev;
		}

        public void PrepsatVek(int vek)
        {
            Vek=vek;
        }

        public void PrepsatVahu(double vaha)
        {
            Vaha=vaha;
        }

		public string ZobrazNazev()
		{
			return Nazev;
		}
    }
}

