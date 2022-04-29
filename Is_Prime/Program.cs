bool Is_Prime(int num)
{
    if(num == 1 | num <= 0)
    {
        return false;
    }
    for(int i = 2; i * i <= num; i++)
    {
        if(num % i == 0)
        {
            return false;
        }
    }return true;
}

Console.WriteLine(Is_Prime(49));
