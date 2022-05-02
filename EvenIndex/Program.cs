int FindEvenIndex(int[] arr)
{
    int Sum(int[] array)
    {int res = 0; foreach(int i in array) res += i; return res;}
    for(int i = 0; i < arr.Length; i++)
    {
        int mod2 = i + 1;
        if(Sum(arr[0..i]) == Sum(arr[mod2..arr.Length]))
        {
            return i;
        }
    }return -1;
}
int[] x = {1,2,3,4,3,2,1};
Console.WriteLine(FindEvenIndex(x));