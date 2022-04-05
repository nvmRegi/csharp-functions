//----- programma principale ----------
Console.WriteLine("BENVENUTO NEL MIO PROGRAMMA!\n");
Console.WriteLine("Quanti numeri vuoi inserire?");

int numUtente = Convert.ToInt32(Console.ReadLine());
int[] arrayUtente = new int[numUtente];

for(int i = 0; i < numUtente; i++)
{
    Console.Write("Inserire il " + (i + 1) + "° numero: ");
    arrayUtente[i] = Convert.ToInt32(Console.ReadLine());
}

stampaArray(arrayUtente);
stampaArray(elevaArrayAlQuadrato(arrayUtente));
stampaArray(arrayUtente);

int sum = sommaElementiArray(arrayUtente);

Console.WriteLine("La somma di tutti i numeri è: " + sum);

int sumAlQuadrato = sommaElementiArray(elevaArrayAlQuadrato(arrayUtente));

Console.WriteLine("La somma di tutti i numeri elevati al quadarto è: " + sumAlQuadrato);





//----- dichiarazioni di funzioni -----
void stampaArray(int[] array) //stampa a video
{

    Console.Write("[ ");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + " ]");
}

int quadrato(int numero)
{
    int risultato;
    risultato = (int)Math.Pow(numero, 2);
    return risultato;
}

int[] elevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < array.Length; i++)
    {
        copiaArray[i] = quadrato(copiaArray[i]);
    }
    return copiaArray;
}

int sommaElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += copiaArray[i];
    }
    return somma;
}