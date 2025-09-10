namespace BaseConsoleApp
{
    // Henkilö-luokka
    public class Henkilo
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }
    }
    internal class Leffalippu
    {
        static void Main(string[] args)
        {
            List<Henkilo> henkilot = new List<Henkilo>();
            //henkilot.Capacity = 0;
            // Lipun hinnat
            int lapsiHinta = 5;
            int aikuinenHinta = 10;
            int senioriHinta = 8;
            //Pyydetään käyttäjän nimi ja ikä
            // Console.WriteLine("Kuinka monta teitä on?");
            //henkilot.Capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjoita nimenne");
            string nimi = Console.ReadLine();
            //nimi = Console.ReadLine();
            int userAge;
            

            //lapsihinta luokka alkaa ja loppuu
            int lapsiIkaMin = 0;
            int lapsiIkaMax = 12;

            // aikuisten hinta luokka alkaa ja loppuu
            int aikuinenIkaMin = 13;
            int aikuinenIkaMax = 64;

            //seniori ikä
            int senioriIkaMin = 65;


            
            while (true)
            {
                Console.WriteLine("Kirjoita iät");
                string ikä = Console.ReadLine();
                bool RealAge = int.TryParse(ikä, out userAge);
                // Tallennetaan henkilö listaan
                henkilot.Add(new Henkilo { Nimi = nimi, Ika = userAge });
                // Lista henkilöistä
                //List<Henkilo> henkilot = new List<Henkilo>();
                Console.WriteLine("Valitse lipputyyppi :");
                Console.WriteLine("1. Lapstenlippu (alle 12-vuotiaille)");
                Console.WriteLine("2. Aikuistenlippu (13-64-vuotiaille)");
                Console.WriteLine("3. Seniorilippu (65-vuotiaille ja vanhemmille)");

                string Lipputyyppi = Console.ReadLine();
                int lipputyyppiInt;
                //bool isValidLipputyyppi = int.TryParse(Lipputyyppi, out int LipputyyppiInt);
                if (!int.TryParse(Lipputyyppi, out lipputyyppiInt))
                {
                    Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                    continue;
                }
                foreach (var henkilo in henkilot)
                {
                    Console.WriteLine($"Henkilö: {henkilo.Nimi}, Ikä: {henkilo.Ika}");
                
                //lipputyypin valinta
                if (lipputyyppiInt == 1)
                {
                    //tarkistaa iän ja jos on oikein niin tulostaa hinnan
                    if (userAge >= lapsiIkaMin && userAge <= lapsiIkaMax)
                    {
                            Console.WriteLine($"Hei {nimi}, lapsen lippu maksaa {lapsiHinta} euroa.");
                            break;
                    }
                    else
                    {
                            Console.WriteLine("Ikäsi ei täsmää valitsemaasi lippuun. Yritä uudelleen.");
                    }
                }
                //lipputyypin valinta
                else if (lipputyyppiInt == 2)
                {
                        if (userAge >= aikuinenIkaMin && userAge <= aikuinenIkaMax)
                        {
                            Console.WriteLine($"Hei {nimi}, aikuisen lippu maksaa {aikuinenHinta} euroa.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ikäsi ei täsmää valitsemaasi lippuun. Yritä uudelleen.");
                        }
                }
                //lipputyypin valinta
                else if (lipputyyppiInt == 3)
                {
                        if (userAge >= senioriIkaMin)
                        {
                            Console.WriteLine($"Hei {nimi}, seniorin lippu maksaa {senioriHinta} euroa.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ikäsi ei täsmää valitsemaasi lippuun. Yritä uudelleen.");
                        }
                }
                    /* hinnat
                    int hinta;
                    hinta = lapsiHinta; 
                    hinta = aikuinenHinta;
                    hinta = senioriHinta;
                    Console.WriteLine($"{henkilo.Nimi}, {henkilo.Ika} vuotta: Lippu maksaa {hinta} euroa.");*/

                }
            }
        }
    }
}
