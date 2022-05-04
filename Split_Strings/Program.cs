string[] Solution(string str)
{
    string[] res = {};
    List<string> EmptyList = new List<string>();
    if(str.Length % 2 != 0) str += "_";
    string inter = "";
    foreach(char i in str)
    {
        inter += i;
        if(inter.Length == 2)
        {
            EmptyList.Add(inter);
            inter = "";

        } 
    }
    res = EmptyList.ToArray();
    return res;
}
foreach(string i in Solution("dfgsdhsfghsf"))
{
    Console.WriteLine(i);
}