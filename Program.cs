﻿bool palindroma(string stringa)
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

int Converti_in_decimale(string binario)
{
    int decimale = 0, potenza = 1;
    for (int i = binario.Length - 1; i >= 0; i--)
    {
        if (binario[i] == '1')
        {

            decimale += potenza;
            
        }
        potenza *= 2;
    }
    return decimale;
}

void EliminaSpaziEcesso (string stringa)
{
    string[] frase = stringa.Split(" ");
    for(int i = 0; i< frase.Length; i++)
    {
        if (frase[i] != "")
        {
            Console.Write(frase[i] + " ");
        }
    }
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
Console.WriteLine(Converti_in_decimale(stringa2));

// ESERCIZIO 2
Console.WriteLine("dimmi una parola con tanti spazi");
stringa = Console.ReadLine();
EliminaSpaziEcesso(stringa);