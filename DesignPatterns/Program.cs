// See https://aka.ms/new-console-template for more information

using DesignPatterns.Singleton;

class Program
{
    static void Main(string[] args)
    {
        //    Console.WriteLine("Hello, World!");

        //    //var singleton = DesignPatterns.Singleton.Singleton.Instance;
        //    var singleton = Singleton.Instance;



        var log = Log.InLog;
        log.Save("a");
        log.Save("b");
    }


}