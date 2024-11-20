using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] initialArray = { "Hello", "2", "world", ":-)" };
        string[] result = GetShortString(initialArray);
        foreach (string i in result)
        {
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
    static string[] GetShortString(string[] array)

    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }
        string[] result = new string[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[index] = array[i];
                index++;
            }
        }
        return result;
    }
}