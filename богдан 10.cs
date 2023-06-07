
public class FixedLengthStringArray
{
    private string[] array;

    public FixedLengthStringArray(int length)
    {
        array = new string[length];
    }

    public void FillArray()
    {
        Console.WriteLine($"Введите {array.Length} строк:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }
    }

    public void DisplayArray()
    {
        Console.WriteLine("Массив строк:");
        foreach (string s in array)
        {
            Console.WriteLine(s);
        }
    }

    public void SearchArray(string searchString)
    {
        bool found = false;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == searchString)
            {
                Console.WriteLine($"Строка найдена в ячейке {i}");
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Строка не найдена");
        }
    }
}