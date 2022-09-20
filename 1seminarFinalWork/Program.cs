void FillArray(string[] text)
{
    for (int i = 0; i < text.Length; i++)
    {
        System.Console.Write($"{i + 1}: ");
        text[i] = Console.ReadLine();
    }
}

int LengthOfArrey(string[] text)
{
    string[] array;
    int j = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            j++;
        }
    }
    return j;
}

void CutArrayString(string[] text, string[] array)
{
    int j = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            array[j] = text[i];
            j++;
        }
    }
}

void PrintStringArray(string[] array)
{
    if (array.Length == 0)
        Console.WriteLine("Строк с длинной меньше 4 символов не найдено");
    else Console.WriteLine("Строки с длинной меньше 4:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {array[i]}");
    }
}

Console.Write("Введите количество вводимых строк: ");

string input = Console.ReadLine();
int count;
bool result = int.TryParse(input, out count);
if (result)
{
    if (count < 1)
        Console.WriteLine("Ошибка, число не натуральное");
    else
    {
        string[] mytext = new string[count];
        FillArray(mytext);
        int n = LengthOfArrey(mytext);
        string[] outext = new string[n];
        CutArrayString(mytext, outext);
        PrintStringArray(outext);
    }
}
else Console.WriteLine("Что то пошло не так, попробуйте еще раз");