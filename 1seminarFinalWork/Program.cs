string FillArray (string[] text, int j)
{
    for (int i = 0; i < j; i++)
    {
        text[j] = Console.ReadLine();
    }
}

string[] CutArrayString (string[] text, out string[] array)
{
    int j = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
            text[i] = array[j];
    }
}

void PrintStringArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
int count = 0;
string[] mytext;
Console.WriteLine("Введите количество вводимых строк");
int count = Convert.ToInt32(Console.ReadLine());
FillArray(mytext, count);
string[] outext;
CutArrayString(mytext, outext);
PrintStringArray(outext);


