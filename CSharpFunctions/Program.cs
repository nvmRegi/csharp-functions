

//----- dichiarazioni di funzioni -----
void StampaArray(int[] array)
{

    Console.WriteLine("[ ");

    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length-1] + " ]");
}

int Quadrato(int numero)
{
    int risultato;
    risultato = numero ^ 2;
    return risultato;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    
    for(int i = 0; i < array.Length; i++)
    {
        copiaArray[i] = Quadrato(array[i]);
    }
    return copiaArray;
}

