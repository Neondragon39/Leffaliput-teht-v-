namespace BaseConsoleApp
{

    internal class Leffalippu
    {
        static void Main(string[] args)
        {

            //henkilot.Capacity = 0;
            // Lipun hinnat
            int lapsiHinta = 5;
            int aikuinenHinta = 10;
            int senioriHinta = 7;

            //Pyydetään käyttäjän nimi ja ikä
            Console.WriteLine("Kirjoita nimenne");


            string nimi = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(nimi) || !nimi.Replace(" ", "").All(char.IsLetter))
            {
                Console.WriteLine("Nimi ei voi olla tyhjä ja Nimen täytyy sisältää vain kirjaimia. Yritä uudelleen.");
                return; // Lopeta ohjelma, jos nimi on tyhjä
            }

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
                //kysytään ikää
                Console.WriteLine("Kirjoita iät");
                string ikä = Console.ReadLine()!;
                if (int.TryParse(ikä, out userAge))
                {
                    //break; // Syöte oli kelvollinen kokonaisluku
                }
                else
                {
                    Console.WriteLine("Virheellinen syöte. Anna ikä numerona.");
                    continue;
                }
                //pyydetään lippuanne
                Console.WriteLine("Valitse lipputyyppi :");
                Console.WriteLine("1. Lapstenlippu (alle 12-vuotiaille)");
                Console.WriteLine("2. Aikuistenlippu (13-64-vuotiaille)");
                Console.WriteLine("3. Seniorilippu (65-vuotiaille ja vanhemmille)");

                //vastaan ottaa käyttäjän vastauksen
                string Lipputyyppi = Console.ReadLine()!;
                int lipputyyppiInt;
                //bool isValidLipputyyppi = int.TryParse(Lipputyyppi, out int LipputyyppiInt);
                if (!int.TryParse(Lipputyyppi, out lipputyyppiInt))
                {
                    //jos väärä yritä uudelleen
                    Console.WriteLine("Virheellinen valinta. Yritä uudelleen.");
                    continue;
                }
                //foreach (var henkilo in henkilo)


                Console.WriteLine($"Henkilö: {nimi}, Ikä: {userAge}");

                Console.WriteLine("Onko sinulla alennuskoodi? (Kyllä/Ei)");
                string hasDiscount = Console.ReadLine()!;
                double discount = 0.0;

                string discountCode = "ALE20";

                if (hasDiscount == "Kyllä")
                {
                    Console.WriteLine("Syötä alennuskoodi:");
                    string userDiscount = Console.ReadLine()!;

                    if (userDiscount == discountCode) {
                        discount = 0.20;
                        Console.WriteLine("Alennuskoodi hyväksytty! Saat 20% alennusta.");
                    } else
                    {
                        Console.WriteLine("Väärä alennuskoodi.");
                    }
                    
                }


                //lipputyypin valinta
                if (lipputyyppiInt == 1)
                {
                    //tarkistaa iän ja jos on oikein niin tulostaa hinnan
                    if (userAge >= lapsiIkaMin && userAge <= lapsiIkaMax)
                    {
                        Console.WriteLine($"Hei {nimi}, lapsen lippu maksaa {lapsiHinta} euroa. Alennettu hinta on {lapsiHinta - lapsiHinta * discount}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ikäsi ei täsmää valitsemaasi lippuun. Yritä uudelleen.");
                        continue;
                    }
                }
                //lipputyypin valinta
                else if (lipputyyppiInt == 2)
                {
                    if (userAge >= aikuinenIkaMin && userAge <= aikuinenIkaMax)
                    {
                        Console.WriteLine($"Hei {nimi}, aikuisen lippu maksaa {aikuinenHinta} euroa. Alennettu hinta on {aikuinenHinta - aikuinenHinta * discount}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ikäsi ei täsmää valitsemaasi lippuun. Yritä uudelleen.");
                        continue;
                    }
                }
                //lipputyypin valinta
                else if (lipputyyppiInt == 3)
                {
                    if (userAge >= senioriIkaMin)
                    {
                        Console.WriteLine($"Hei {nimi}, seniorin lippu maksaa {senioriHinta} euroa. Alennettu hinta on {senioriHinta - senioriHinta * discount}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ikäsi ei täsmää valitsemaasi lippuun. Yritä uudelleen.");
                        continue;
                    }
                }
                break;
            }
        }
    }
}
