
bool controlla_parentesi(string esp)
{
    int aperte = 0, chiuse = 0;
    for (int i = 0; i < esp.Length; i++)
    {
        if (esp[i] == '(')
        {
            aperte++;
        }
        else if (esp[i] == ')')
        {
            chiuse++;
        }

        if (chiuse > aperte)
        {
            return false;
        }
    }
    if (aperte == chiuse)
    {
        return true;
    }
    return false;
}


// main

Console.WriteLine("dimmi espressione");
string espressione = Console.ReadLine();
Console.WriteLine(controlla_parentesi(espressione));