using System.Collections.Generic;

namespace TestOOP;
class Program
{
    static void Main(string[] args)
    {
        //bool corectInput = false;
        int inputZver = 0;
        int inputZamestnanci = 0;
        int inputMain = 0;

        Zoo zoo = new Zoo();

        while(inputMain!=3)
        {
            Console.WriteLine("HLAVNI MENU");
            Console.WriteLine("\t1-databaze se zamestnanci");
            Console.WriteLine("\t2-databaze se zviraty");
            Console.WriteLine("\t3-ukoncit program");

            //inputMain = Convert.ToInt32(Console.ReadLine());
            //inputMain = Zoo.ReadLineCheckInt();
            inputMain = Zoo.ReadLineCheckNum<int>();

            switch(inputMain)
            {
                case 1:
                    while(inputZamestnanci!=7)
                    {
                        Console.WriteLine("ZAMESTNANCI - HLAVNI MENU");
                        Console.WriteLine("\t1-pridej zamestnance");
                        Console.WriteLine("\t2-vypis vsechny evidovany zamestnance");
                        Console.WriteLine("\t3-smazani zamestnance z database");
                        Console.WriteLine("\t4-prepsat data u zamestnance");
                        Console.WriteLine("\t5-pocet zamestnancu");
                        Console.WriteLine("\t6-soucet mezd");
                        Console.WriteLine("\t7-prejit do hlavniho menu");

                        //inputZamestnanci = Convert.ToInt32(Console.ReadLine());
                        //inputZamestnanci= Zoo.ReadLineCheckInt();
                        inputZamestnanci=Zoo.ReadLineCheckNum<int>();

                        switch (inputZamestnanci)
                        {
                            case 1:
                                zoo.PridatZamestnance();
                                break;
                            case 2:
                                zoo.VypisZamestnancu();
                                break;
                            case 3:
                                zoo.SmazatZamestnance();
                                break;
                            case 4:
                                zoo.PrepsatZamestnance();
                                break;
                            case 5:
                                zoo.PocetZamestnancu();
                                break;
                            case 6:
                                zoo.SoucetMezd();
                                break;
                        }
                    }
                    

                    break;
                case 2:
                    while (inputZver != 7)
                    {
                        
                        Console.WriteLine("ZVIRATA - HLAVNI MENU");
                        Console.WriteLine("\t1-pridej zvire");
                        Console.WriteLine("\t2-vypis vsechna evidovana zvirata");
                        Console.WriteLine("\t3-smazani zvirete z database");
                        Console.WriteLine("\t4-prepsat data");
                        Console.WriteLine("\t5-pocet zvirat");
                        Console.WriteLine("\t6-vyhledej zvire podle nazvu");
                        Console.WriteLine("\t7-prejit do hlavniho menu");


                        //if (int.TryParse(Console.ReadLine(), out inputZver))
                        //{
                        //    corectInput = true;
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Spatne zadany vstup.");

                        //};
                        //inputZver = Zoo.ReadLineCheckInt();
                        inputZver=Zoo.ReadLineCheckNum<int>();


                        //int index;
                        switch (inputZver)
                        {
                            case 1:
                                zoo.PridatZvire();
                                break;
                            case 2:
                                zoo.VypisZvirat();
                                break;
                            case 3:
                                zoo.SmazatZvire();
                                break;
                            case 4:
                                zoo.PrepsatZvire();
                                break;
                            case 5:
                                zoo.PocetZvirat();
                                break;
                            case 6:
                                zoo.VyhledejZvire();
                                break;
                        }
                    }

                    break;
            }
        }
        
    }
}

