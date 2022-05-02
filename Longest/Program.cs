string[] Longest(string a, string b)
{
    string common = a + b;
    string[] res = SetSplitter(common);
    Array.Sort(res);
    return res;
}
Display(Longest("aretheyhere", "yestheyarehere"));

void Display(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {Console.Write(arr[i] + " ");}
        Console.WriteLine();
    }
string[] SetSplitter(string x)
{
    string[] array = new string[x.Length];
    for(int i = 0; i <= x.Length - 1; i++)
    {
        if(!array.Any(n => n == Convert.ToString(x[i])))
        {
            array[i] = Convert.ToString(x[i]);
        }
    }return array;
}