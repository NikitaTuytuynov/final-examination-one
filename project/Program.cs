Console.Clear();
Console.Write("Ведите слова разделяя их ТОЛЬКО пробелом: ");
string s = Convert.ToString(Console.ReadLine());
Console.WriteLine($"Исходная строка: {s}");
void Print(string x)
{
    string[] subs = x.Split(' ');
    foreach (var sub in subs)
    {
        int i = sub.Length;
        if (i <= 3) Console.WriteLine($"-> {sub}");
    }
}
Print(s);