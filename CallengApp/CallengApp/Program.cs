//==============================================================================
// Dzien 4 - zadanie

//dane do podania:
string yourName = "Ewa";  // podaj imie:        dowolne imie
char yourSex = 'K';       // podaj płac:        K - kobieta, M- Meszczyżna , .... dowolna płec , ==> podaj płac odpowiednia dla imienia
var yourAge = 33;         // podaj ile ma lat:  od 0 do nieskonczonosci


// kod - start

if (yourSex == 'K')  //wybór kobiety
{
    if (yourAge >= 30 && yourName == "Ewa")
    { Console.WriteLine(yourName + ", lat " + yourAge); }

    else if (yourAge >= 30)
    { Console.WriteLine("Kobieta, lat " + yourAge); }

    else if (yourAge < 30 && yourAge >= 18)
    { Console.WriteLine("Kobieta poniżej 30 lat"); }

    else if (yourAge < 18)
    { Console.WriteLine("Niepełnoletnia Kobieta"); }
}

if (yourSex == 'M') // wybór męszczyzny
{
    if (yourAge >= 30 && yourName == "Piotr")
    { Console.WriteLine(yourName + ", lat " + yourAge); }

    else if (yourAge >= 30)
    { Console.WriteLine("Meszczyża, lat " + yourAge); }

    else if (yourAge < 30 && yourAge >= 18)
    { Console.WriteLine("Męszczyzna poniżej 30 lat"); }

    else if (yourAge < 18)
    { Console.WriteLine("Niepełnoletni Męszczyzna"); }
}

if (yourSex != 'K' && yourSex != 'M') // wybór LGTB
{
    if (yourAge >= 30)
    { Console.WriteLine("LGTB, lat " + yourAge); }

    else if (yourAge < 30 && yourAge >= 18)
    { Console.WriteLine("LGTB poniżej 30 lat"); }

    else if (yourAge < 18)
    { Console.WriteLine("Niepełnoletni LGTB"); }
}

// kod - koniec
//=========================================================================