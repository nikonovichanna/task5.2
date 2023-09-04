int length = Promt("Длина массива: ");
int[] array = GenereteArray(length);
PrintArray(array);
System.Console.WriteLine(SumOddPosition(array));

int Promt (string message)
{
    System.Console.WriteLine(message);
    string readInput = System.Console.ReadLine();
    int result =int.Parse(readInput);
    return result;
}

int[] GenereteArray(int length)
    {
        int[] result = new int[length];
        for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}

void PrintArray(int[] array)
{
    foreach (int i in array) 
    {
        System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
} 

int SumOddPosition(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
        summ += array[i];
        }
    }
    return summ;
}