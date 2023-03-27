using System;
namespace TestOOP
{
	public class Zamestnanec
	{
		private string Jmeno { get; set; }
        private string Prijmeni { get; set; }
        private DateTime DatumNarozeni { get; set; }
        private double Plat { get; set; }
        private string NazevPracovniPozice { get; set; }
        

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNarozeni, double plat, string nazevPracPozice)
		{
			Jmeno = jmeno;
			Prijmeni = prijmeni;
			DatumNarozeni = datumNarozeni;
			Plat = plat;
			NazevPracovniPozice = nazevPracPozice;
            

		}

        public void VypisDatOZamestnanci()
        {
            
            Console.WriteLine($"\tJmeno: {Jmeno}");
            Console.WriteLine($"\tPrijmeni: {Prijmeni}");
            Console.WriteLine($"\tDatum narozeni: {DatumNarozeni}");
            Console.WriteLine($"\tPlat: {Plat}");
            Console.WriteLine($"\tNazev pracovni pozice: {NazevPracovniPozice}");
        }

        public void PrepsatJmeno(string jmeno)
        {
            Jmeno = jmeno;
        }

        public void PrepsatPrijmeni(string prijmeni)
        {
            Prijmeni = prijmeni;
        }

        public void PrepsatDatumNarozeni(DateTime datumNarozeni)
        {
            DatumNarozeni = datumNarozeni;
        }

        public void PrepsatPlat(double plat)
        {
            Plat = plat;
        }

        public void PrepsatNazevPracovniPozice(string pracovniPozice)
        {
            NazevPracovniPozice = pracovniPozice;
        }

        public double UkazPlat()
        {
            return Plat;
        }


    }
}

