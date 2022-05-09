using System.Text.RegularExpressions;

string StripComments(string text, string[] commentSymbols)
{
    var sym = @"";
    string pattern = @"[";
    string pattern2 = @"].+";
    foreach(var i in commentSymbols) sym += i;
    pattern = pattern + sym + pattern2 + '|' + "^" + pattern + sym + pattern2 + "|^" + '[' + sym + ']' + '|' + '[' + sym + ']';
    string target = "";
    Regex regex = new Regex(pattern);
    var reply = "";
    foreach(var i in text.Split('\n'))
    {
        var temp = regex.Replace(i, target);
        reply += temp.TrimEnd() + '\n';
    }var index = reply.Length - 1;
    return reply[..index];  
}






var x = "apples, pears # and bananas\ngrapes\nbananas !apples";
string[] n = { "#", "!" };
//var list = x.Split('\n');
//foreach(var i in list) {x += i + '\n';}
///int index = x.Length - 1;
///Console.WriteLine(x[..index]);


Console.WriteLine(StripComments(x, n));