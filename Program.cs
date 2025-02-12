bool palindroma(string stringa)
{
    for (int i = 0; i < stringa.Length - i; i++)
    {
        if (stringa[i] != stringa[stringa.Length - i - 1])
        {
            return false;
        }
    }
    return true;
}


void spezzaMeta(string stringa)
{
    Console.Write("Inserisci una stringa: ");
    string input = Console.ReadLine();

    int metà = input.Length / 2;

    string primaParte = input.Substring(0, metà);
    string secondaParte = input.Substring(metà);

    Console.WriteLine(primaParte);
    Console.WriteLine(secondaParte);
}

int Converti_in_decimale(string stringa)
{
    int decimale = 0, potenza = 1;
    for (int i = stringa.Length - 1; i >= 0; i--)
    {
        if (stringa[i] == '1')
        {

            decimale += potenza;
            
        }
        potenza *= 2;
    }
    return decimale;
}


// MAIN 
// ESERCIZIO 4
string stringa = "";
Console.WriteLine("dimmi una parola");
stringa = Console.ReadLine();
Console.WriteLine(palindroma(stringa));

// ESERCIZIO 3
spezzaMeta(stringa);

// ESERCIZIO 1
string stringa2 = "";
Console.WriteLine("Dimmi un bianrio di massimo 8 bit");
stringa2 = Console.ReadLine();
Console.WriteLine(Converti_in_decimale(stringa));