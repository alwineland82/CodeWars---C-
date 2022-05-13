using System;


Person tom = new Person();

class Person 
{
    public string name = "Undefined";   // имя
    public int age;                     // возраст
 
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}
