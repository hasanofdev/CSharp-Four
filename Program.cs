using static System.Console;

namespace Csharp_Four;

public delegate void Func(string text);
class MyClass
{
    private string str;

    public MyClass(string str) => this.str = str;
    public void Space(string text)
    {
        foreach (char strch in text)
            Write($"{strch}_");
        WriteLine();
    }

    public void Reverse(string text)
    {
        for (int i = text.Length - 1; i >= 0; i--)
            Write(text[i]);
        WriteLine();
    }
}

class Run
{
    public void runFunc(Func func, string str)
    {
        func(str);
    }
}
class Program
{
    public static void Main()
    {
        WriteLine("Enter string: ");

        string? str = ReadLine();
        MyClass cls = new MyClass(str);
        Func funcDell = new Func(cls.Reverse);
        funcDell += cls.Space;
        Run run = new Run();
        run.runFunc(funcDell, str);
    }

}