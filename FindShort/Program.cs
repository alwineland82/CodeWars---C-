int FindShort(string s)
{
    string[] temp = s.Split(' ');
    int res = 100;
    foreach(string i in temp)
    {
        if(i.Length < res)
        {
            res = i.Length;
        }
    }
    return res;
}

Console.WriteLine(FindShort("bitcoin take over the world maybe who knows perhaps"));