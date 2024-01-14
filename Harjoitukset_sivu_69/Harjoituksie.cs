
using System;
using System.Diagnostics.Eventing.Reader;

string kysymykset;

do
{

	int paatos;

alku:

	Console.Clear();
	Console.WriteLine("Valitse jokin ohjelma alla olevista vaihtoehdoista:");
	Console.WriteLine("1. Annettu ik‰.");
	Console.WriteLine("2. Luvun toistaminen.");
	Console.WriteLine("3. Ensimm‰isen ja viimeisen kirjaimen vaihto.");
	Console.WriteLine("4. Tarkistaa onko annetut luvut positiivisia vai negatiivisia.");
	Console.WriteLine("5. Tulostaa pisimm‰n sanan.");
	Console.WriteLine("6. Tulostaa parittomat luvut.");
	Console.WriteLine("7. Tulostaa luvut jotka ovat 3 jaollisia.");

	try
	{
		paatos = Int32.Parse(Console.ReadLine());

	}


	catch (Exception ex)
	{

		Console.WriteLine("Arvo jonka annoit ei ole kokonaisluku. Yrit‰ uudelleen! Kiitos!");
		Console.WriteLine(ex.Message);

		goto alku;
	}


	switch (paatos)
	{
		case 1:
			AnnettuIka();
			break;

		case 2:
			LukujenToisto();
			break;

		case 3:
			KirjainJarjestys();
			break;

		case 4:
			PosNeg();
			break;

		case 5:
			TulostaPisin();
			break;

		case 6:
			ParittomatLuvut();
			break;

		case 7:
			JaollisetKolmella();
			break;

		default:
			Console.WriteLine("Annoit v‰‰r‰n arvon. Anna arvo v‰lilt‰ 1-7. Yrit‰ uudelleen! Kiitos!");

			goto alku;
			break;

	}







	static void AnnettuIka()
	{
		string ika;

		Console.Clear();
		Console.WriteLine("Anna ik‰: ");

		ika = Console.ReadLine();

		Console.WriteLine("{0} - n‰yt‰t ik‰ist‰si nuoremmalta", ika);


	}








	static void LukujenToisto()

		int luku

		alku:


	try
	{
		Console.Clear();
		Console.WriteLine("Anna 10:nt‰ suurempi arvo: ");


		luku = Int32.Parse(Console.ReadLine());

	}


	catch (Exception ex)
	{

		Console.WriteLine("Antamasiluku on virheellinen. Yrit‰ uudelleen, Kiitos!");
		Console.WriteLine(ex.Message);

		goto alku;
	}


	for (int a = 0; a < luku; a++) {

		for (int b = 0; b < luku; b++)
		{
			Console.WriteLine(luku + " ");
		}
		Console.WriteLine();

		for (int c = 0; c < luku; c++)
		{
			Console.WriteLine(luku);
		}

		Console.WriteLine();


	}



	static void KirjainJarjestys()
	{
		string sana, usana;

		int spituus;

		Console.Clear();
		Console.WriteLine("Anna sana. Sanan ensimm‰inen ja viimeinen kirjain vaihdetaan toisinp‰in: ");

		sana = Console.ReadLine();
		spituus = sana.Length;

		char[] taulukko = new char[spituus];

		for (int a = 0; a < spituus; a++)
		{
			taulukko[a] = (sana[a]);

			taulukko[0] = sana[spituus - 1];
			taulukko[spituus - 1] = sana[0];
			usana = String.Join(" ", taulukko);
		}
		Console.WriteLine("Annoit sanan {0} ja se on muutettu {1}", sana, usana);



	}








	static void PosNeg()
	{ int luku, luku1;

	alku:


		Console.Clear();
		Console.WriteLine("Ohjalema pyyt‰‰ kaksi lukua ja tarkistaa onko ne positiivisia vai negatiivisia. ");



		try
		{
			Console.WriteLine("Anna ensimm‰inen kokonaisluku: ");
			luku = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Anna toinen kokonaisluku: ");
			luku1 = Int32.Parse(Console.ReadLine());
		}

		catch (Exception ex)
		{

			Console.WriteLine("Arvot jotka annoit eiv‰t ole kokonaislukuja. Yrit‰ uudelleen! Kiitos!");
			Console.WriteLine(ex.Message);

			goto alku;

		}

		if (luku > 0 && luku1 > 0)
		{
			Console.WriteLine("Antamasi arvot ovat positiivisia");
		}

		else if (luku < 0 && luku1 < 0)
		{
			Console.WriteLine("Antamasi arvot ovat negatiivisia");
		}

		else
		{
			Console.WriteLine("Annetuista luvuista toinen on positiivinen ja toinen on negatiivinen ");

		}


	}












	static void TulostaPisin()
	{
		Console.Clear();
		Console.WriteLine("Ohjelma pyyt‰‰ lausetta ja n‰ytt‰‰‰ lauseen pisimm‰n sanan");



		string sana

			Console.WriteLine("Anna jokin lause: ");
		sana = Console.ReadLine();

		String[] taulukko = sana.Split(" ");
		String spisin = taulukko[0];

		for (int a = 1; a < taulukko.Length; a++)
		{
			if (talukko[a].Lenght > spisin.Length)
			{
				spisin = taulukko[a];
			}
		}

		Console.WriteLine("Antamasi lause on {0}, ja pisin sana on {1}.", sana, spisin);

	}








	static void ParittomatLuvut()
	{
		Console.Clear();
		Console.WriteLine("Ohjelma tulostaa parittomat luvut 1-99 v‰lilt‰. ");

		for (int a = 1; a < 99; a += 2) {

			Console.WriteLine(a + " ");
		}
		else
		{
			Console.WriteLine("Annoit v‰‰r‰nlaisen arvon! Yrit‰ uudelleen! Kiitos!");

		}
	}







	static void JaollisetKolmella()
	{
		Console.Clear();
		Console.WriteLine("Ohjelma tulostaa kolmella jaolliset arvot 1-99 v‰lilt‰.");

		for (int a = 3; a <= 99; a += 3) {

			Console.WriteLine(a + " "); }

	}

		else
	{
		Console.WriteLine("Annoit v‰‰r‰nlaisen arvon! Yrit‰ uudelleen! Kiitos!");
	}


	Console.WriteLine("Lopetetaanko ohjelma? paina 0 + Enter lopettaaksesi ohjelman. Mik‰ tahansa muu n‰pp‰in jatkaa ohjelmaa.");
	Console.ReadLine();

} while (kysymys != "0"); 