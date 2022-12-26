/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.*/

string[] CreateStringArray()
{
    Console.Write("Input size of your array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] stringArray = new string[size];
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"Input a word or a sentence: ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}


void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}" + " ");
    Console.WriteLine();
}


int CountLetters(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}


string[] CreateMas(int count, string[] array)
{
    string[] LengthResult = new string[count];
    int ind = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            LengthResult[ind] = array[i];
            ind++;
        }
    }
    return LengthResult;
}

string[] mas = CreateStringArray();
int qnt = CountLetters(mas);

if (qnt != 0)
{
    string[] result = CreateMas(qnt, mas);
    Console.WriteLine();
    ShowArray(result);
}
else
{
    Console.WriteLine();
    Console.Write("There are no parameters, satisfying the task.");
}

