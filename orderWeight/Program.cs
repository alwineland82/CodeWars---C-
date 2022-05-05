string orderWeight(string strng)
{
    string[] strngList = strng.Split(' ');
    Array.Sort(strngList);
    int Sum(string num){int sum = 0; foreach(var i in num){sum += Convert.ToInt32(Convert.ToString(i));}return sum;}
    string reply = "";
    int count = 0;
    while (count < strngList.Length)
    {
        int min = 10000000;
        string adder = "";
        foreach(var i in strngList)
        {
            if(min > Sum(i)) {min = Sum(i); adder = i;}
        }reply += adder + " ";
        strngList[Array.IndexOf(strngList, adder)] = "99999999";
        count += 1;

    }return reply.TrimEnd();
}
Console.WriteLine(orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));


int Sum(string num){int sum = 0; foreach(var i in num){sum += Convert.ToInt32(Convert.ToString(i));}return sum;}

int[] array = {1, 2, 3, 4, 5};
array[0] = 99999;
Console.WriteLine(Array.IndexOf(array, 99999));

///Console.WriteLine(Sum("2000"));
///Console.WriteLine(Sum("11"));


///List<string> result = names.Split(',').ToList();