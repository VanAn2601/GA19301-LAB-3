using System;
using System.Security;

public class Program
{
    public void Main(string[] args)
    {
        string path = "data.txt";
        using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write)) 
        {
            using(StreamWriter sr = new StreamWriter(fs)) 
            {
                sr.WriteLine("Username: myUsername");
                sr.WriteLine("Password: myPassword");
            }
        }
        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}