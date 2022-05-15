using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingMethod1stTry
{
    internal class Buss
    {
        public Passagerare[] aPassagerare;
        public Buss()
        {
            Passagerare[] passagerare = new Passagerare[25];

            passagerare[0] = new Passagerare("Aron Aronsson", 20, "man", 0, "Hoförs", 1);
            passagerare[1] = new Passagerare("Benji Bengtsson", 45, "man", 1, "Borlänge", 2);
            passagerare[2] = new Passagerare("Celin Christiansson", 17, "kvinna", 0, "Sandviken", 3);
            passagerare[3] = new Passagerare("Dolly Dartmund", 58, "kvinna", 2, "Falun", 4);
            passagerare[4] = new Passagerare("Erika Eriksson", 35, "kvinna", 0, "Storvik", 5);
            passagerare[5] = new Passagerare("Felicia Fredriksson", 22, "kvinna", 1, "Sandviken", 6);
            passagerare[6] = new Passagerare("Göran Göransson", 68, "man", 0, "Sandviken", 7);
            passagerare[7] = new Passagerare("Hanna Hellström", 25, "kvinna", 0, "Falun", 8);
            passagerare[8] = new Passagerare("Ida Stigsson", 5, "kvinna", 0, "Borlänge", 9);
            passagerare[9] = new Passagerare("Jesper Jespersson", 28, "man", 1, "Hoförs", 13);
            passagerare[10] = new Passagerare("Kian Kristiansdotter", 38, "man", 0, "Sandviken", 14);
            passagerare[11] = new Passagerare("Ludmila Stigsson", 32, "kvinna", 1, "Borlänge", 10);
            passagerare[12] = new Passagerare("Malwin Stigsson", 39, "man", 1, "Borlänge", 11);
            passagerare[13] = new Passagerare("Nilson Skogberg", 40, "man", 0, "Storvik", 15);
            passagerare[14] = new Passagerare("Olaf Olafsson", 47, "man", 0, "Hoförs", 16);
            passagerare[15] = new Passagerare("Patricia Lund", 32, "kvinna", 2, "Falun", 17);
            passagerare[16] = new Passagerare("Kamala Västerskog", 29, "kvinna", 0, "Storvik", 18);
            passagerare[17] = new Passagerare("Rikard West", 28, "man", 0, "Sandviken", 19);
            passagerare[18] = new Passagerare("Stig Stigsson", 10, "man", 0, "Borlänge", 12);
            passagerare[19] = new Passagerare("Tobias Strömberg", 20, "man", 0, "Sandviken", 20);
            passagerare[20] = new Passagerare("Usa Westberg", 52, "kvinna", 0, "Storvik", 21);
            passagerare[21] = new Passagerare("Vivian Vallberg", 65, "kvinna", 0, "Sandviken", 22);
            passagerare[22] = new Passagerare("William Thor", 42, "man", 1, "Falun", 23);
            passagerare[23] = new Passagerare("Xaviar Gomez", 40, "man", 0, "Sandviken", 24);
            passagerare[24] = new Passagerare("Tomplats", 0, "N/A", 0, "N/A", 25);
            aPassagerare = passagerare;
        }


        public void Run()
        {

            Console.WriteLine("Välkommen");
            Meny();
        }
        public void Meny()
        {
            bool RunMeny = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Väjl alternativ");
                Console.WriteLine("Tryck 1 för namn och ålder lista");
                Console.WriteLine("Tryck 2 för antal passagerare");
                Console.WriteLine("Tryck 3 för antal bagage");
                Console.WriteLine("Tryck 4 för total ålder");
                Console.WriteLine("Tryck 5 för passagerarnas genomsnittligt ålder");
                Console.WriteLine("Tryck 6 för antal kön män och kvinnor");
                Console.WriteLine("Tryck 7 för sittplats");
                Console.WriteLine("Tryck 8 för att lägga till en passagerare");
                Console.WriteLine("Tryck 9 för att avsluta programmet");


                string val = Console.ReadLine();
                switch (val)
                {
                    case "1":
                        NamnList();
                        break;
                    case "2":
                        AntalPassagerare();
                        break;
                    case "3":
                        aBagage();
                        break;
                    case "4":
                        TotalÅlder();
                        break;
                    case "5":
                        GenomsnitligtÅlder();
                        break;
                    case "6":
                        Kön();
                        break;
                    case "7":
                        LedigPlats();
                        break;
                    case "8":
                        LäggaTill();
                        break;
                    case "9":
                        RunMeny = false;
                        break;
                    default: Console.WriteLine("Felaktig inmatning");
                        break;

                }
            } while (RunMeny);
        }

        public void NamnList()
        {
            Console.Clear();
            Console.WriteLine("Namn                          ålder");
            Console.WriteLine("------------------------------------------------------");
            for (int i = 0; i < aPassagerare.Length; i++)
            {
                if (aPassagerare[i].namn == "Tomplats")
                {
                }
                else
                {
                    Console.WriteLine(aPassagerare[i].namn + "                   " + aPassagerare[i].ålder);
                }
            }
            //Console.WriteLine("Tryck Enter för att återgå till Meny.");
            Console.ReadKey();
        }

        public void AntalPassagerare()
        {
            Console.Clear();
            int AntalPassagerare = 0;
            for (int i = 0; i < aPassagerare.Length; i++)
            {
                if ("Tomplats" != aPassagerare[i].namn)
                {
                    AntalPassagerare++;
                }
            }
            Console.WriteLine("Det finns " + AntalPassagerare + " personer på bussen.");
            Console.WriteLine("Det finns " + (25 - AntalPassagerare) + " lediga platser. ");

            Console.WriteLine("Tryck Enter för att återgå till Meny.");
            Console.ReadKey();
        }

        public void aBagage()
        {
            Console.Clear();
            int aBagage = 0;
            for (int i = 0; i < aPassagerare.Length; i++)
            {
                aBagage += aPassagerare[i].bagage;
            }
            Console.WriteLine("Det finns " + aBagage + " bagage på bussen");

            Console.WriteLine("Tryck Enter för att återgå till Meny.");
            Console.ReadKey();
        }

        public void TotalÅlder()
        {
            Console.Clear();
            int aÅlder = 0;
            for (int i = 0; i < aPassagerare.Length; i++)
            {
                aÅlder += aPassagerare[i].ålder;
            }
            Console.WriteLine("Total ålder av alla passagerare är " + aÅlder + " år");

            Console.WriteLine("Tryck Enter för att återgå till Meny.");
            Console.ReadKey();
        }

        public void GenomsnitligtÅlder()
        {
            Console.Clear();
            int aÅlder = 0;
            for (int i = 0; i < aPassagerare.Length; i++)
            {
                aÅlder += aPassagerare[i].ålder;
            }
            int AntalPassagerare = 0;
            for (int i = 0; i < aPassagerare.Length; i++)
            {
                if ("Tomplats" != aPassagerare[i].namn)
                {
                    AntalPassagerare++;
                }
            }
            int MedelÅlder = aÅlder / AntalPassagerare;
            Console.WriteLine("Genomsnitligt ålder av passagerare är " + MedelÅlder + ".");

            Console.WriteLine("Tryck Enter för att återgå till Meny.");
            Console.ReadKey();

            //total age divide by 24 
        }

        public void Kön()
        {
            Console.Clear();
            int kvinna = 0;
            int man = 0;
            for (int i = 0; i < aPassagerare.Length; i++)
            {
                if ("kvinna" == aPassagerare[i].kön)
                {
                    kvinna++;
                }
                else if ("man" == aPassagerare[i].kön)
                {
                    man++;
                }
            }
            Console.WriteLine("Antal kvinnor är " + kvinna);
            Console.WriteLine("Antal män är " + man);

            Console.WriteLine("Tryck Enter för att återgå till Meny.");
            Console.ReadKey();

            // answer in män = number, kvinnor = number
        }


        public void LedigPlats()
        {
            Console.Clear();
            int aSittplats = 0;
            for (int i = 0; i < aPassagerare.Length; i++)
            {
                if ("Tomplats" == aPassagerare[i].namn)
                {
                    aSittplats++;
                    Console.WriteLine("Det finns " + aSittplats + " lediga platser.");
                    Console.WriteLine("Plats nummer " + aPassagerare[i].sittplats + " är ledig.");
                }
            }
            Console.WriteLine("Tryck Enter för att återgå till Meny.");
            Console.ReadKey();

            //should be 1 available 
        }

        public void LäggaTill()  //användaren får lägga till en passagerare 
        {
            Console.Clear();
            
            string namn;
            int ålder;
            string kön;
            int bagage;
            string destination;
            int sittplats = 0; 

            for (int i = 0; i < aPassagerare.Length; i++)
            {
                if ("Tomplats" == aPassagerare[i].namn)
                {
                   sittplats = aPassagerare[i].sittplats;
                }
            }

            if (sittplats == 0)
            {
                Console.WriteLine("Det finns inte ledig plats.");
                Console.ReadKey(); 
            }
            else
            {
                Console.WriteLine("Skriv in passagerarens namn och efternamn ");
                namn = Console.ReadLine();
                Console.WriteLine("Skriv in passagerarens ålder ");
                ålder = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv in passagerarens kön ");
                kön = Console.ReadLine();
                Console.WriteLine("Skriv in antal bagage passagerarens har ");
                bagage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Skriv in passagerarens destination ");
                destination = Console.ReadLine();
                Console.WriteLine();
                aPassagerare[sittplats - 1] = new Passagerare(namn, ålder, kön, bagage, destination, sittplats);
                Console.WriteLine("Passagerare är registrerad.");
                Console.ReadLine();
            }
            
        }
    }
    } 


