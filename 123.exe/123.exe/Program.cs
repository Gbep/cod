using System;
using System.IO;

public interface IRead
{
    string Read(string filePath);
}

public interface IWrite
{
    void Write(string filePath, string content);
}
class TestClass
{
    static void Main(string[] args)
    {
        
    }
}

public class FileService : IRead, IWrite
{
    public string Read(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Hello World.");
            return null!;
        }
        string text = File.ReadAllText(filePath);
        Console.WriteLine(text);
        return text;
    }

    public void Write(string filePath, string content)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Hello World.");
            return;
        }
        File.WriteAllText(filePath, content);
        Console.WriteLine("Hello World.");
    }
}
