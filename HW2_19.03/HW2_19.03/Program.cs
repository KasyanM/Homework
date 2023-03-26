using System.Data;

namespace Homework2;

public static class Program
{
    public static void Main()
    {
        Console.Write("Введите размер массива: ");
        int numbersSize = ReadInt();

        try
        {
            if (numbersSize < 2)
            {
                throw new ArraySizeException();
            }
            
        }
        catch (ArraySizeException ex)
        {
            Console.WriteLine("Чтобы вычислить второй максимальный элемент массива, его размер должен быть больше 1");
            return;
        }

        int[] numbers = new int[numbersSize];
        for (int i = 0; i < numbersSize; i ++)
        {
            Console.Write($"Введите значение {i} элемента массива: ");
            numbers[i] = ReadInt();
        }

        int max1 = numbers[0];
        for (int i = 0; i < numbersSize; i ++)
        {
            if (numbers[i] > max1)
            {
                max1 = numbers[i];
            }
        }
        Console.WriteLine("Максимальный элемент массива: " + max1);

        int max2 = numbers[0];
        for (int i = 0; i < numbersSize; i++)
        {
            if (numbers[i] > max2 && numbers[i] != max1)
            {
                max2 = numbers[i];
            }
        }
        try
        {
            if (max1 == max2)
            {
                throw new EqualElementsException();
            }
        }
        catch (EqualElementsException ex)
        {
            Console.WriteLine("Нельзя вычислить второй максимальный элемент массива, так как все элементы массива одинаковы");
            return;
        }
        Console.WriteLine("Второй максимальный элемент массива: " + max2);

    }

    public static int ReadInt()
    {
            if (Int32.TryParse(Console.ReadLine(), out var value))
            {
                return value;
            }
            else
            {
                throw new Exception ("Укажите значение в виде целого числа");
            }
    }
}
