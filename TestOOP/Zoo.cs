using System;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Reflection;

namespace TestOOP
{
	public class Zoo
	{
		private List<Zvire> zvirata;
		private List<Zamestnanec> zamestnanci;

		public Zoo()
		{
			zvirata = new List<Zvire>();
			zamestnanci = new List<Zamestnanec>();
		}

        public static string ReadLineCheck()
        {
            string? output = string.Empty;
            int i = 0;
            do
            {
                if(i>0)
                {
                    Console.WriteLine("Nic nebylo zadano. Zadej vstup znovu.");
                }
                output = Console.ReadLine();
                
                i++;
            } while (string.IsNullOrEmpty(output));
            
            
            return output;

        }

        public static int ReadLineCheckInt()
        {
            int output = -1;
            do
            {
                
                try
                {
                    output = Convert.ToInt32(ReadLineCheck());   
                }
                catch
                {
                    
                    Console.WriteLine("Spatne zadany vstup. Zadej znovu.");
                }

            } while (output == -1);
            return output;

        }

        public static double ReadLineCheckDouble()
        {
            double output = -1;
            do
            {
                try
                {
                    output = Convert.ToDouble(ReadLineCheck());
                }
                catch
                {
                    Console.WriteLine("Spatne zadany vstup. Zadej znovu.");
                }

            } while (output == -1);
            return output;

        }

        public static T ReadLineCheckNum<T>()
        {
            string input = ReadLineCheck();
            T result=default;
            bool passed = false;
            do
            {
                try
                {
                    result= (T)Convert.ChangeType(input, typeof(T));
                    passed = true;
                }
                catch
                {
                    Console.WriteLine("Spatne zadany vstup. Zadej znovu.");
                    input = ReadLineCheck();
                }
            } while (passed == false);
            return result;
        }



        public void PridatZvire(string nazev,int vek, double vaha)
		{
			Zvire zvire = new Zvire(nazev, vek, vaha);

			zvirata.Add(zvire);
        }

		public void PridatZvire()
		{
            Console.WriteLine("Zadej nazev, vek a vahu zvirete.");
            string nazev = ReadLineCheck();
            //int vek = Convert.ToInt32(Console.ReadLine());  //podminka, aby to bylo dobre zadany
            //int vek = ReadLineCheckInt();
            int vek = ReadLineCheckNum<int>();
            //double vaha = Convert.ToDouble(Console.ReadLine());
            //double vaha = double.TryParse(ReadLineCheck(), out vaha) ? vaha : 0;
            double vaha= ReadLineCheckNum<double>();
            //zvirata.Add(new Zvire(nazev, vek, vaha));
            PridatZvire(nazev, vek, vaha);
        }

		public void SmazatZvire(int index)
		{
			zvirata.RemoveAt(index);
		}

        public void SmazatZvire()
        {
            VypisZvirat();
            Console.WriteLine("Vyber index zvirete kteryho chces smazat.");
            //int index = Convert.ToInt32(Console.ReadLine());
            //int index= ReadLineCheckInt();
            int index= ReadLineCheckNum<int>();
            SmazatZvire(index - 1);
        }


        public void VypisZvirat()
		{
			int i=0;
			foreach(Zvire zvire in zvirata)
			{
				i++;
				Console.WriteLine($"{i}. Zvire:");
				zvire.VypisDatOZvireti();
			}
		}

		public Zvire VyberZvire(int index)
		{
			return zvirata[index-1];
		}

        public void PrepsatZvire()
        {
            VypisZvirat();
            Console.WriteLine("Data u ktereho zvirete chces zmenit. Vyber index");
            //int index = Convert.ToInt32(Console.ReadLine());
            //int index = int.TryParse(ReadLineCheck(), out index) ? index : 0;
            //int index = ReadLineCheckInt();
            int index= ReadLineCheckNum<int>();
            Zvire zvire = VyberZvire(index);
            Console.WriteLine("Co chces upravit:");
            Console.WriteLine("\t1. nazev");
            Console.WriteLine("\t2. vek");
            Console.WriteLine("\t3. vaha");

            //int uprava = Convert.ToInt32(Console.ReadLine());
            //int uprava = int.TryParse(ReadLineCheck(), out uprava) ? uprava : 0;
            //int uprava= ReadLineCheckInt();
            int uprava= ReadLineCheckNum<int>();
            Console.WriteLine("Zadej novy vstup.");
            string novyVstup = ReadLineCheck();
            switch (uprava)
            {
                case 1:
                    zvire.PrepsatNazev(novyVstup);
                    break;
                case 2:
                    zvire.PrepsatVek(Convert.ToInt32(novyVstup));
                    break;
                case 3:
                    zvire.PrepsatVahu(Convert.ToDouble(novyVstup));
                    break;
            }
        }

        public void PocetZvirat()
        {
            //return zvirata.Count();
            Console.WriteLine($"Pocet zvirat v databazi je: {zvirata.Count()}");
        }

        public void VyhledejZvire()
        {
            Console.WriteLine("Zadej nazev zvirete, ktere hledas.");
            string nazev= ReadLineCheck();
            bool found=false;

            foreach(Zvire zvire in zvirata)
            {
                
                if (zvire.ZobrazNazev().Equals(nazev, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Nasleduji data o hledanem zvireti");
                    zvire.VypisDatOZvireti();
                    found = true;
                }

            }

            if (!found) { Console.WriteLine($"Zvire {nazev} neni v seznamu"); }
            
            
        }


        //----------------------- Zamestnanci -------------------------

        public void PridatZamestnance(string jmeno, string prijmeni, DateTime datumNarozeni, double plat, string nazevPracPozice)
		{
            Zamestnanec zamestnanec = new Zamestnanec(jmeno, prijmeni, datumNarozeni,plat,nazevPracPozice);

            zamestnanci.Add(zamestnanec);
        }

        public void PridatZamestnance()
        {
            Console.WriteLine("Postupne zadej data zamestnance, ktereho chces pridat do databaze.");
            Console.Write("Zadej jmeno:");
            string jmeno = ReadLineCheck();

            Console.Write("Zadej prijmeni:");
            string prijmeni = ReadLineCheck();

            CultureInfo provider = CultureInfo.InvariantCulture;
            Console.Write("Zadej datum narozeni ve formatu dd/mm/yyyy:");
            //DateTime datumNarozeni = Convert.ToDateTime(Console.ReadLine());
            DateTime datumNarozeni = DateTime.ParseExact(ReadLineCheck(),"dd/MM/yyyy", provider);

            Console.Write("Zadej plat:");
            //double plat = Convert.ToDouble(Console.ReadLine());
            //double plat= ReadLineCheckDouble();
            double plat= ReadLineCheckNum<double>();

            Console.Write("Zadej nazev pracovni pozice:");
            string pracovniPozice = ReadLineCheck();

            PridatZamestnance(jmeno, prijmeni, datumNarozeni, plat, pracovniPozice);

            
        }

        public void SmazatZamestnance(int index)
        {
            zamestnanci.RemoveAt(index);
        }

        public void SmazatZamestnance()
        {
            VypisZamestnancu();
            Console.WriteLine("Vyber index zamestnance kteryho chces smazat.");
            //int index = Convert.ToInt32(Console.ReadLine());
            //int index = int.TryParse(ReadLineCheck(), out index) ? index : 0;
            //int index= ReadLineCheckInt();
            int index= ReadLineCheckNum<int>();
            //zoo.SmazatZvire(index - 1);
            SmazatZamestnance(index - 1);
        }


        public void VypisZamestnancu()
        {
            int i = 0;
            foreach (Zamestnanec zamestnanec in zamestnanci)
            {
                i++;
                Console.WriteLine($"{i}. Zamestnanec:");
                zamestnanec.VypisDatOZamestnanci();
            }
        }

        public Zamestnanec VyberZamestnance(int index)
        {
            return zamestnanci[index - 1];
        }

        public void PrepsatZamestnance()
        {
            VypisZamestnancu();
            Console.WriteLine("Data u ktereho zamestnance chces zmenit. Vyber index");
            //int index = Convert.ToInt32(Console.ReadLine());
            //int index= ReadLineCheckInt();
            int index= ReadLineCheckNum<int>();
            Zamestnanec zamestnanec = VyberZamestnance(index);
            Console.WriteLine("Co chces upravit:");
            Console.WriteLine("\t1. jmeno");
            Console.WriteLine("\t2. prijmeni");
            Console.WriteLine("\t3. datum narozeni");
            Console.WriteLine("\t4. plat");
            Console.WriteLine("\t5. nazev pracovni pozice");

            //int uprava = Convert.ToInt32(Console.ReadLine());
            //int uprava= ReadLineCheckInt();
            int uprava= ReadLineCheckNum<int>();
            Console.WriteLine("Zadej novy vstup.");
            string novyVstup = ReadLineCheck();
            switch (uprava)
            {
                case 1:
                    zamestnanec.PrepsatJmeno(novyVstup);
                    break;
                case 2:
                    zamestnanec.PrepsatPrijmeni(novyVstup);
                    break;
                case 3:
                    zamestnanec.PrepsatDatumNarozeni(Convert.ToDateTime(novyVstup));
                    break;
                case 4:
                    zamestnanec.PrepsatPlat(Convert.ToDouble(novyVstup));
                    break;
                case 5:
                    zamestnanec.PrepsatNazevPracovniPozice(novyVstup);
                    break;
            }
        }

        public void PocetZamestnancu()
        {
            //return zamestnanci.Count();
            Console.WriteLine($"Pocet zamestnancu v databazi je: {zamestnanci.Count()}");
        }

        public void SoucetMezd()
        {
            double soucetMezd=0;
            foreach(Zamestnanec zamestnanec in zamestnanci)
            {
                soucetMezd+=zamestnanec.UkazPlat();
            }
            //return soucetMezd;
            Console.WriteLine($"Soucet mezd vsech zamestnancu v databazi je: {soucetMezd}");
        }
    }
}

