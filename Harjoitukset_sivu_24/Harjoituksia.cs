using System;
using System.Net;

alku:

int luku;
Console.WriteLine("Valitse ohjelma, jonka haluat suorittaa");
Console.WriteLine("1. Lukujen järjestäminen");
Console.WriteLine("2. Suurimman luvun etsiminen 3:sta luvusta");
Console.WriteLine("3. Luvun (0-9) muunto");
Console.WriteLine("4. Suurimman luvun etsiminen");
Console.WriteLine("5. Käyttäjän syöttövalinta");
Console.WriteLine("6. Bonuspisteet");
Console.WriteLine("7. Luvun (0-999) muunto sanaksi");

string kluku = Console.ReadLine();

try
{
    luku = Int32.Parse(kluku)
}


catch (Exception ex)
{
    Console.WriteLine("Syöttöarvon pitää olla lukuarvo")´;
    Console.WriteLine(ex.Message);
    goto alku;
}

switch (luku)
{
    case 1:
        LukujenJarjestys();
        break;


    case 2:
        SuurimmanEtsinta3();
        break;


    case 3:
        SanaksiPieni();
        break;


    case 4:
        SuurimmanEtsinta5();
        break;


    case 5:
        SyottoValinta();
        break;


    case 6:
        BonusPisteet(); 
        break;


    case 7:
        MuuntoSanaksi();
        break;
}


static void LukujenJarjestys()
{ 
    string kluku1, kluku2;
    int luku1, luku2;

Ljalku:
    Console.WriteLine("Ohjelma pyytää kahta kokonaislukua ja tulostaa ne suuruusjärjestyksessä.");
    Console.WriteLine("Anna luku 1. ");

    kluku1 = Console.ReadLine();

    Console.WriteLine("Anna luku 2. ");

    kluku2 = Console.ReadLine();

    try
    {
        luku1 = Int32.Parse(kluku1);
        luku2 = Int32.Parse(kluku2);
    }

    catch (Exception ex)
    {
        Console.WriteLine("Antamasi luvut eivät ole kokonaislukuja");
        Console.WriteLine(ex.Message);

        goto Ljalku; 
    }

    if (luku2 > luku1)
    {
        Console.WriteLine("Lukujen järjestys {0}, {1}", luku1, luku2); 

    }

    else
    {
        Console.WriteLine("Lukujen järjestys {0}, {1}", luku2, luku1); 

    }

    Console.WriteLine("Aloitetaanko alusta, (k/e)?");

    string vastaus = Console.ReadLine();

    if ( vastaus == "k" || vastaus == "K")
    {
        goto Ljalku;
    }

}



static void SuurimmanEtsinta3()
{
    int[] luvut = new int[3]; 

suurinalku: 

    try
    {
        Console.WriteLine("Anna ensimmäinen kokonaisluku, kiitos!");
            luvut[0] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Anna toinen kokonaisluku, kiitos!");
            luvut[1] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Anna kolmas kokonaisluku, kiitos!");
            luvut[2] = Int32.Parse(Console.ReadLine());

    }

    if (luvut[0] <= luvut[1])
    {
        Console.WriteLine("Ensimmmäinen kokonaisluku on suurin");
    }

    else if (luvut[0] <= luvut[2])
    {
        Console.WriteLine("Ensimmmäinen kokonaisluku on suurin");
    }

    else if (luvut[1] <= luvut[2])
    {
        Console.WriteLine("Toinen kokonaisluku on suurin");
    }

    else if ( luvut[1] <= luvut[3])
    {
        Console.WriteLine("Toinen kokonaisluku on suurin")
    }

    else
    {
        Console.WriteLine("Kolmas kokonaisluku on suurin")
    }

    string vastaus = Console.ReadLine();

    if (vastaus != "/ ^\d +/")
    {
        Console.WriteLine("Et antanut oikeaa arvoa");

        goto suurinalku; 
    }
}




static void SanaksiPieni()
{
    string kluku1;
    int luku;

alku:
    Console.WriteLine("Anna kokonaisluku ja ohjelma muuttaa sen sanaksi");
    Console.WriteLine("Anna ensimmäinen luku.");

        kluku1 = Console.ReadLine(); 

    try
    {
        luku = Int32.Parse(kluku1); 
    }

    catch (Exception ex)

    {
        Console.WriteLine("Arvot jotka annoit eivät ole kokonaislukuja");
        Console.WriteLine(ex.Message);

        goto alku;
            }



    switch(luku)
    {
        case "0":
            Console.WriteLine("Nolla")
        break;

        case "1":
            Console.WriteLine("Yksi");
        break;

        case "2":
            Console.WriteLine("Kaksi");
        break;


        case "3":
            Console.WriteLine("Kolme");
        break;


        case "4":
            Console.WriteLine("Neljä");
        break; 

        case "5":
            Console.WriteLine("Viisi");
        break;

        case "6":
            Console.WriteLine("Kuusi");
        break;

        case "7":
            Console.WriteLine("Seitsemän");
        break;

        case "8":
            Console.WriteLine("Kahdeksan");
        break;

        case "9":
            Console.WriteLine("Yhdeksän");
        break;


        default: Console.WriteLine("Annoit virheellisen arvon");
        break;

            goto alku; 
    }
}


static void SuurimmanEtsinta5()
{
    int[] luvut = new int[5];

alku:

    try
    {
        Console.WriteLine("Anna ensimmäinen kokonaisluku, kiitos!");
            luvut[0] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Anna toinen kokonaisluku, kiitos!");
            luvut[1] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Anna kolmas kokonaisluku, kiitos!");
            luvut[2] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Anna neljäs kokonaisluku, kiitos!");
            luvut[3] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Anna viides kokonaisluku, kiitos!");
            luvut[4] = Int32.Parse(Console.ReadLine());
    }

    catch(Exception ex)
    {
        Console.WriteLine("Luvut mitä annoit eivät ole kokonaislukuja!");
        Console.WriteLine(ex.Message);


        goto alku;
    }

    Array.Sort(luvut);
    int.lastone = luvut.Length;

    Console.WriteLine("Suurin luku on: " + luvut[lastone - 1]); 
    }






static void SyottoValinta()
{
    int kluku; 
    double dluku
    string mjono, syote;

salku:

    Console.WriteLine("Minkälaisen tiedon haluat syöttää (double, int, string (d/i/s)):");

    syote = Console.ReadLine(); 

    if(syote == "d" || syote == "i" || syote == "s" || syote == "D" || syote == "I" || syote == "S")
    {
        switch(syote)

        {
            case "d":
            case "D":

                dalku:
                Console.Write("Syötä double: "); 

           try
                {
                    dluku = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Laitoit luvun" + dluku + " tulos on " + (dluku + 1)); 
                }
           
            catch (Exception ex)
                {
                    Console.WriteLine("Anna doubleluku, Kiitos!");
                    Console.WriteLine(ex.Message);

                    goto dalku;
                }
            break; 


            case "s":
            case "S":
                Console.WriteLine("Syötä merkkijono: ");

                mjono = Console.ReadLine();
                mjono += "*";

                Console.WriteLine("Uusi jono on: " + mjono);
                break;


            case "i":
            case "I":

            ialku:
                Console.WriteLine("Anna kokonaisluku: "); 

                try
                {
                    kluku = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Annoit luvun " + kluku + " tulos on " + (kluku + 1));

                }

                catch (Exception ex)
                {

                    Console.WriteLine("Anna kokonaisluku, Kiitos!");
                    Console.WriteLine(ex.Message);

                    goto ialku;
                }
                break;

            default:
                Console.WriteLine("Olet täyttänyt jotkin tiedot väärin! Tarkista missä on virhe!");

                break;
        }
    }

    else
    {
        Console.WriteLine("Annoit väärän arvon. Anna vain jokin kirjaimista: (d/i/s) kirjain koolla ei ole väliä!");

        goto salku; 
    }
}
    


static void BonusPisteet()
{
    int ibonus;

balku:

    Console.WriteLine("Anna bonuspisteiden määrä: (1-9): "); 

    try
    {
        ibonus = Int32.Parse(Console.ReadLine());
    }

    catch (Exception ex)
    {
        Console.WriteLine("Antamasi luku ei ole kokonaisluku!");
        Console.WriteLine(ex.Message);

        goto balku;
    }

    switch(ibonus)
    {
        case 1:
        case 2:
        case 3:
            ibonus *= 3;
        break;


        case 4:
        case 5:
        case 6:
            ibonus *= 100;
            break;

        case 7:
        case 8:
        case 9:
            ibonus *= 1000;
            break;

        default:
            Console.WriteLine("Antamasi luku ei ole väliltä 1-9!");

            goto balku;
            break; 
    }

    Console.WriteLine("Bonuspisteet on: " + ibonus); 

}






static void MuuntoSanaksi()
{
    int luku;
asana:

    Console.WriteLine("Anna arvo väliltä 0-999, ohjelma muuntaa luvun sanaksi: ");

    try
    {
        numero = Int32.Parse(Console.ReadLine()); 
    }

    catch(Exception ex) {
        Console.WriteLine("Arvo jonka annoit ei ole kokonaisluku");
        Console.WriteLine(ex.Message);

        goto asana; 
    }

    if (luku > 999 || luku < 0)
    {
        Console.WriteLine("Täytit arvon, joka ei ole väliltä 0-999!");
        goto asana; 
    }

    else if (luku < 10)
    {
        string first;
        first = first(luku);
        Console.WriteLine(first); 
    }

    else if (luku < 20)
    {
        string ptens;
        ptens = pten(luku);
        Console.WriteLine(ptens); 
    }

    else if (luku < 100)
    {
        string ten;
        ten = tens(luku);
        Console.WriteLine(ten);
    }

    else if (luku < 1000)
    {
        string hund;
        hund = hundres(luku);
        Console.WriteLine(hund);
    }


    static string first (int luku)
    {
        switch (luku)
        {
            case 1: 
                return "Yksi"
                break;

            case 2:
                return "Kaksi"
                break;

            case 3:
                return "Kolme"
                break;

            case 4:
                return "Neljä"
                break;

            case 5:
                return "Viisi"
                break;

            case 6:
                return "Kuusi"
                break;

            case 7:
                return "Seitsemän"
                break;

            case 8:
                return "Kahdeksan"
                break;

            case 9:
                return "yhdeksän"
                break;

            default: 
                return "Turhaa"
                break;
        }
    }


}


