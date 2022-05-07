bool ValidParentheses(string input)
{   
    int res = 0;
    foreach(var i in input)
    {
        if(i == '(') res += 1;
        if(i == ')') res -= 1;
        if(res < 0) return false;
    }return res == 0;
}

string x = "((()))()";

Console.WriteLine(ValidParentheses(x));    
