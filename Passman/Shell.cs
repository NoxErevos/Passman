namespace Passman;

using System;
public class Shell
{
    public static void ShellInit()
    {
        var EXIT_STATUS = false;
        while (!EXIT_STATUS)
        {
            Console.Write("pshell> ");
            var input = (Console.ReadLine() ?? "").Trim();
            switch (input)
            {
                case "help":
                    Console.WriteLine("help invoked");
                    break;
                case "bye" or "exit":
                    Console.WriteLine("Exiting");
                    return;
                default:
                    Console.WriteLine("No such command");
                    break;
            }
        }
    }
}