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


// MAIN 
// ESERCIZIO 4
string stringa = "";
Console.WriteLine("dimmi una parola");
stringa = Console.ReadLine();
Console.WriteLine(palindroma(stringa));

// ESERCIZIO 3
spezzaMeta(stringa);