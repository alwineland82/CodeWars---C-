using System;

int Number(List<int[]> PeopleListInOut)
{
    int inBus = 0;
    int outBus = 0;
    foreach(int[] i in PeopleListInOut)
    {
        inBus += i[0];
        outBus += i[1];
    }
    return inBus - outBus;
}

List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, 
                             new[] { 9, 1 }, new[] { 4, 10 }, 
                             new[] { 12, 2 }, new[] { 6, 1 }, 
                             new[] { 7, 10 } };
Console.WriteLine(Number(peopleList));