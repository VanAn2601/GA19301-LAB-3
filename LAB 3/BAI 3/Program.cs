using System;
using System.IO;

class Program
{
    static void Main()
    {

        string dataDir = "data";
        Directory.CreateDirectory(dataDir);


        string dataFilePath = Path.Combine(dataDir, "data.txt");
        using (StreamWriter sw = new StreamWriter(dataFilePath))
        {
            sw.WriteLine("Msvv");
            sw.WriteLine("họ và tên");
        }

        string data2Dir = "data2";
        Directory.CreateDirectory(data2Dir);

        foreach (string file in Directory.GetFiles(dataDir))
        {
            string fileName = Path.GetFileName(file);
            string destFile = Path.Combine(data2Dir, fileName);
            File.Copy(file, destFile, true);
        }
    }
}