int[] DeleteNth(int[] arr, int x)
{
    int Count(List<int> arr, int n){int count = 0; foreach(int i in arr){if(i == n) count += 1;} return count;}
    int[] res = {};
    List<int> EmptyList = new List<int>();
    foreach(int i in arr)
    {
        if(Count(EmptyList, i) < x)
        {
            EmptyList.Add(i);
        }
    }res = EmptyList.ToArray();
    return res;
}


Console.WriteLine(DeleteNth(new int[] {1,1,3,3,7,2,2,2,2}, 3));