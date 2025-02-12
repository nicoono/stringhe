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

// MAIN 
// ESERCIZIO 4
string stringa = "";
Console.WriteLine("dimmi una parola");
stringa = Console.ReadLine();
Console.WriteLine(palindroma(stringa));