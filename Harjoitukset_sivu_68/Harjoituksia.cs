using System;

string kysymys; 

do
{
kaikenalku:

    string luku;
    int luku2;

    Console.WriteLine("Valitse jokin tehtävä 10 tehtävästä: ");
    Console.WriteLine("1. Laskee kaksi numero yhteen.");
    Console.WriteLine("2. Muuttaa Celsiukset Farenheiteksi.");
    Console.WriteLine("3. Tekee 4 laskutoimitusta");
    Console.WriteLine("4. Laskee jakojäännöksen. ");
    Console.WriteLine("5. Kirjoittaa viestin käyttäjälle.");
    Console.WriteLine("6. Sama, kun tehtävä 1. käyttäjä antaa numerot.");
    Console.WriteLine("7. Sama, kun tehtävä 1. käyttäjä antaa asteet.");
    Console.WriteLine("8. Sama, kun tehtävä 1. käyttäjä antaa luvut.");
    Console.WriteLine("9. Sama, kun tehtävä 1. käyttäjä antaa luvut.");
    Console.WriteLine("10. Laskee käyttäjän antamista luvuista kertotaulun.");

    try
    {
        luku = Console.ReadLine();
        luku2 = Int32.Parse(luku)
    }


    catch (Exception ex)
    {
        Console.WriteLine("Laittamasi arvo ei kelvannut.");
        Console.WriteLine(ex.ToString());

        goto kaikenalku; 
    }


    switch (luku2)
    {
        case 1:
            LaskeYhteen(5, 7);

            break;

        case 2:
            Farenheit(30);

            break;

        case 3:
            Laskutoimitukset(10, 12);
            break;

        case 4:
            Jakolasku(8, 4);
            break;


        case 5:
            Viesti();
            break

            case 6:
            LaskeeYhteen();
            break;


        case 7:
            FarenheitLuvuista();
            break;

        case 8:
            LaskutoimituksetLuvuista();
            break;

        case 9:
            JakoLuvuista();
            break;

        case 10:
            KertotauluLuvuista();
            break;

        default:
            Console.WriteLine("Annoit väärän arvon, anna arvo väliltä 1-10, Kiitos!")


                goto kaikenalku;
    }






    static void LaskeYhteen( int a, int b)
    {
        Console.WriteLine("Summa on: " + (a + b)); 

    }

    static void Farenheit(int a )
    {

    Console.WriteLine(a + "Celsius asteita on " + ((a * 1.8) + 32);
    }






    static void Laskutoimitukset(int a, int b)
    {
        int summa, tulo, erotus;

        double jako;

        summa = a + b;

        tulo = a * b; 

        erotus = a - b;

        jako = (double) a / b;


        Console.WriteLine("Lukujen " + a + " ja " + b);
        Console.WriteLine("Summa: " + summa);
        Console.WriteLine("Erotus: " + erotus);
        Console.WriteLine("Tulo: " + tulo);
        Console.WriteLine("Osamäärä on " + jako); 
    }






    static void Jakolasku(int a, int b)
    {
        int jako = a % b;

        Console.WriteLine("Lukujen " + a + " ja " + b);
        Console.WriteLine("Jakolaskun tulos on: " + jako); 
    }






    static void Viesti()
    {
        string viesti;
        Console.WriteLine("Laita etunimesi: ");
        
        viesti = Console.ReadLine();    
        Console.WriteLine("Hei" + viesti);


    }




    static void LaskeeYhteen()
    {
        int luku, luku1, summa;

        Console.WriteLine("Ohjelma laskee yhteen antamasi arvot."); 

        alku: 

        try
        {

            Console.WriteLine("Anna ensimmöinen arvo: ");
            luku = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Anna toinen arvo: ");
            luku1 = Int32.Parse(Console.ReadLine()); 

        }



        catch (Exception ex)
        {
            Console.WriteLine("Antamasi arvot eivot ole kokonaislukuja. Täytä arvot oikein. Kiitos!"); 
            Console.WriteLine(ex.Message);

            goto alku; 

        }


        summa = luku + luku1;
        Console.WriteLine("Arvojen " + luku + " ja " + luku1 + "summa on" + summa); 

    }




    static void FarenheitLuvuista()
    {
        Double cluku, fluku;
        Console.WriteLine("Ohjelma muuttaa antamasi celsiusarvon farenheiteiksi.");
        
        cfalku: 

            
        try
        {
            Console.WriteLine("Anna celsiusaste: ");
            cluku = Double.Parse(Console.ReadLine()); 

        }

        catch(Exception ex)
        {
            Console.WriteLine("Annoit vääränlaisen arvon. Anna numeraalinen arvo, kiitos!"); 
            Console.WriteLine(ex.Message);

            goto cfalku;

        }


        fluku = (cluku * 1.8) + 32;
        Console.WriteLine(cluku + "Celsiusastetta on " + fluku + " Fahrenheittiä");

    }







    static void LaskutoimituksetLuvuista()
    {

        Console.WriteLine("Ohjelma laskee laskutoimitukset antamistasi kokonaisluvuista. "); 

        int 15, 30, summa, erotus, tulo;

        double osamaara; 

        alku: 

        try
        {

            Console.WriteLine("Anna ensimmainen luku: ");
            15 = Int32.Parse(Console.ReadLine()); 

            Console.WriteLine("Anna toinen luku": );
            30 = Int32.Parse(Console.ReadLine());
        }

        catch (Exception ex) {
    
            Console.Writeline("Antamasi arvot eivät ole kokonaislukuja, yritä uudelleen. Kiitos!");
            Console.WriteLine(ex.Message);

            goto alku; 
        }

        summa = 15 + 30;
        erotus = 15 - 30;
        tulo = 15 * 30;
        osamaara = (double 15/30);

        Console.WriteLine("Arvojen {0} ja {1} laskutoimituksen arvot ovat seuraavat: " 15, 30);
        Console.WriteLine("Summa: {0} ", summa);
        Console.WriteLine("Erotus: {0} ", erotus);
        Console.WriteLine("Tulo: {0} ", tulo);
        Console.WriteLine("Osamäärä: {0} ", osamaara); 

    }









    static void JakoLuvuista()
{
    Console.WriteLine("Ohjelma laskee jakojäännöksen antamastasi luvuista.");

    int luku, luku1, jako;

alku:

    try
    {
        Console.WriteLine("Anna jaettava luku: ")
            luku = Int32.Parse(Console.ReadLine());

        Console.WriteLine(ex.Message);
        luku1 = Int32.Parse(Console.ReadLine());
    }


    catch (Exception ex)
    {
        Console.WriteLine("Antamasi arvot eivät ole kokonaislukuja. Yritä uudelleen. Kiitos!");
        Console.WriteLine(ex.Message);

        goto alku; }

    jako = luku % luku1;
    Console.WriteLine("Lukujen {0} ja {1} jakojäännös on {2}.", luku, luku1, jako); 


}




static void KertotauluLuvuista()
{
    Console.WriteLine("Ohjelma tekeee kertotaulun 10 antamastasi kokonaisluvusta");

    int luku; 

    alku: 

    try
    {
        luku = Int32.Parse(Console.ReadLine()); 

    }

    catch (Exception ex)
    {
        Console.WriteLine("Laittamasi arvo ei ole kokonaisluku. Yritä uudelleen! Kiitos!");
        Console.WriteLine(ex.Message);

        goto alku;
    }

    Console.WriteLine(" 1 x " + luku + " = " + (1 * luku));
    Console.WriteLine(" 2 x " + luku + " = " + (2 * luku));
    Console.WriteLine(" 3 x " + luku + " = " + (3 * luku));
    Console.WriteLine(" 4 x " + luku + " = " + (4 * luku));
    Console.WriteLine(" 5 x " + luku + " = " + (5 * luku));
    Console.WriteLine(" 6 x " + luku + " = " + (6 * luku));
    Console.WriteLine(" 7 x " + luku + " = " + (7 * luku));
    Console.WriteLine(" 8 x " + luku + " = " + (8 * luku));
    Console.WriteLine(" 9 x " + luku + " = " + (9 * luku));
    Console.WriteLine(" 10 x " + luku + " = " + (10 * luku));
}


Console.WriteLine("Lopetetaanko ohjelmat? 0 + Enter lopettaa ohjelmat"); 
kysymys = Console.ReadLine();
} 

while (kysymys != "0") ; 