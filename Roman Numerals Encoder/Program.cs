string Solution(int n)
{
    string res = Convert.ToString(n);
    string reply = "";
    int counter = 0;
    var lathin_numerals = new Dictionary<char, string>()
    {
        {'1', "I X C M"},
        {'2', "II XX CC MM"},
        {'3', "III XXX CCC MMM"},
        {'4', "IV XL CD"},
        {'5', "V L D"},
        {'6', "VI LX DC"},
        {'7', "VII LXX DCC"},
        {'8', "VIII LXXX DCCC"},
        {'9', "IX XC CM"},
    };
    foreach(char i in res)
    {
        counter += 1;
        if(i == '0') continue;
        string[] x = lathin_numerals[i].Split(' ');
        reply += x[res.Length - counter];
        
    }
    return reply;
}
Console.WriteLine(Solution(2250));