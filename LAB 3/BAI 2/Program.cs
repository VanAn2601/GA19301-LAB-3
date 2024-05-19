using System;

public class Program
{
    static void Main(string[] args)
    {
        string username = "1";
        string password = "2";
        string time = "20/1";
        var sw = new StringWriter();
        sw.WriteLine("username: " + username);
        sw.WriteLine("password: "+ password);
        sw.WriteLine("time:"+time);
        var content = sw.ToString();
        Console.WriteLine(content);

        var sr = new StreamReader(content);
        String Line1 = sr.ReadLine();
        Console.WriteLine("Line1:"+ Line1);
        String Line2 = sr.ReadLine();
        Console.WriteLine("Line2: "+ Line2);

        string Line = sr.ReadLine();
        while(Line != null)
        {
            Console.WriteLine(Line);
            Line = sr.ReadLine();
        }
        Console.WriteLine(sr.ReadToEnd());
    }
}