int[] CountPositivesSumNegatives(int[] input)
{
    int[] empty = new int[0];
    int[] result = new int[2]; 
    int count = 0;
    int sum = 0;
    if (input == null)
      {
      return empty;
    }
    foreach(int i in input)
    {
        if (i > 0)
        {
            count++;
        }else if (i < 0)
        {
            sum += i;
        }
    }
    if (input.Length == 0)
    {
        return empty;
    }else
    {
        result[0] = count;
        result[1] = sum;
        return result;
    }
}
