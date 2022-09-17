int[] testArray = { 2, 6, 7, 5, 3, 9 };
Console.WriteLine("Quanti numeri vuoi inserire?");
int maxLength = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[maxLength];
for (int i = 0; i < maxLength; i++)
{
    Console.WriteLine("Inserisci un nuovo numero: ");
    int newNumber = Convert.ToInt32(Console.ReadLine());
    userArray[i] = newNumber;
}

void StampaArray(int[] array)
{
    Console.Write("[");
    int i;
    for(i = 0; i < array.Length - 1; i++) {
        Console.Write(array[i]);
        Console.Write(",");
    }
    Console.Write(array[i]);
    Console.WriteLine("]");
}

int Quadrato(int numero)
{
    return Convert.ToInt32(Math.Pow(numero, 2));
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    Array.Copy(array, 0, arrayCopy, 0, array.Length);
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = Quadrato(array[i]);
    }
    return arrayCopy;
}

int sommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}


Console.Write("Array originale: ");
StampaArray(userArray);

Console.WriteLine();

Console.Write("Array al quadrato: ");
StampaArray(ElevaArrayAlQuadrato(userArray));
Console.WriteLine();
Console.Write("Array originale: ");
StampaArray(userArray);

Console.WriteLine();

Console.Write("La somma di tutti gli elementi dell'arary originale è: ");
Console.WriteLine(sommaElementiArray(userArray));

Console.WriteLine();

Console.Write("La somma di tutti gli elementi dell'array elevato al quadrato è: ");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(userArray)));