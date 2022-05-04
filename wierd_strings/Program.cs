string ToWeirdCase(string s)
{
    int count = 0;
    string reply = "";
    foreach(char i in s)
    {
        if(" ,.".Contains(i)) {count = 0; reply += i; continue;}
        if(count % 2 == 0)
        {
            reply += Convert.ToString(i).ToUpper();
        }else if((count % 2 != 0))
        {
            reply += Convert.ToString(i).ToLower();
        }
        else
        {
            reply += i;
        }count += 1;
    }return reply;
}
Console.WriteLine(ToWeirdCase("Boy")); /// ThIs Is A TeSt