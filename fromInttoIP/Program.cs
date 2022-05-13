using System.Linq;
using System.Text.RegularExpressions;
using System;

string UInt32ToIP(uint num)
{
    string two = "";
    while(num / 2 != 0)
    {   
        two = Convert.ToString(num % 2) + two;
        num = num / 2; 
    }two =  string.Concat(Enumerable.Repeat("0", 31 - two.Length)) + Convert.ToString(num) + two;
    string Converter(string num, string reply="")
    {
        if(num.Length == 0) return reply.TrimEnd('.');
        Regex pattern = new Regex(@"\d{8}");
        string text = Convert.ToString(pattern.Match(num));
        var result = 0;
        for(int i = 128, j = 0; i > 0; i=i/2, j++ ){result += Convert.ToByte(Convert.ToString(text[j])) * i;}
        reply += Convert.ToString(result) + '.';
        return Converter(num[8..], reply);}
    return Converter(two);

}

Console.WriteLine(UInt32ToIP(32));


