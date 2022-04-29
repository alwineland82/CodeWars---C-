int Descending_Order(int num)
{
    string d = Convert.ToString(num);
    string res = "";
    foreach(char y in d)
    {   
        int max = 0;
        foreach(char i in d)
        {   
            if (max < Convert.ToInt32(Convert.ToString(i)))
            {
            max = Convert.ToInt32(Convert.ToString(i));
            }
        }
        int index = d.IndexOf(Convert.ToString(max));
        if(index >= 0)
        d = d.Remove(index, Convert.ToString(max).Length);
        res += max;
    }
    num = Convert.ToInt32(res);
    return num;
}
Console.WriteLine(Descending_Order(453634735));
