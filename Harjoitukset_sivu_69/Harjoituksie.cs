
using System;

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


	switch(paatos)
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
		Console.WriteLine("Anna 10:nt‰ suurempi arvo: ");
		Console.Clear();

		luku = Int32.Parse(Console.ReadLine()); 

	}


	catch (Exception ex)
	{

		Console.WriteLine("Antamasiluku on virheellinen. Yrit‰ uudelleen, Kiitos!"); 
		Console.WriteLine(ex.Message);

		goto alku;
	}


	for( int a = 0; a < luku; a++) {
	
	for (int b = 0; b < luku; b++)
		{
			Console.WriteLine(luku + " ");
		}
		Console.WriteLine();	

		for ( int c = 0; c < luku; c++)
		{
			Console.WriteLine(luku); 
		}

		Console.WriteLine(); 
				

	}




}