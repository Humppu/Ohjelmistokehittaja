using System;

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
        SuurimmanEtsintä();
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
        Console.WriteLine("Anna ensimmäinen kokonaisluku, kiitos!")
            luvut[0] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Anna toinen kokonaisluku, kiitos!")
            luvut[1] = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Anna kolmas kokonaisluku, kiitos!")
            luvut[2] = Int32.Parse(Console.ReadLine());

    }

    if (luvut[0] < luvut[1])
    {
        Console.WriteLine("Ensimmmäinen kokonaisluku on suurin");
    }

    else if (luvut[0] < luvut[2])
    {
        Console.WriteLine("Ensimmmäinen kokonaisluku on suurin");
    }

    else if (luvut[1] < luvut[2])
    {
        Console.WriteLine("Toinen kokonaisluku on suurin");
    }

    else if ( luvut[1] < luvut[3])
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
        goto suurinalku; 
    }
}




static void SanaksiPieni()
{

}

