using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace Passman;


internal class Program
{
    private const string Version = "v0.0.1";
    public static int Main()
    {
        Console.WriteLine($"Welcome to Passman {Version}");
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Register");
        Console.WriteLine("3. Exit");
        Console.Write("> ");
        var option = Convert.ToInt32(Console.ReadLine());
        switch (option)
        {
            case 1:
                Login();
                break;
            case 2:
                Register();
                break;
            case 3:
                return 1;
        }

        return 0;
    }

    private static void Login()
    {
        string passman;
        // This is a very early stage for this program, so I haven't bothered encrypting ANYTHING. If you use this program(which nobody will) you're just fucking stupid.
        try
        {
            passman = File.ReadAllText("Passman.json");
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("File Passman.json not found. Please specify your own file");
            Console.Write("> ");
            var input = (Console.ReadLine() ?? "").Trim();
            try
            {
                passman = File.ReadAllText(input);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File not found. Exiting");
                return;
            }
        }

        var deserializedData = new JsonStruct();
        try
        {

            deserializedData = JsonConvert.DeserializeObject<JsonStruct>(passman);
        }
        catch (Newtonsoft.Json.JsonReaderException)
        {
            Console.WriteLine("JSON is corrupt or wrong.");
            return;
        }

        if (passman.Length < 2)
        {
            Console.WriteLine("Insufficient information in the file");
            return;
        }
        // var loginUser = passman[0];
        // var loginPass = passman[1];
        // Console.WriteLine("Enter username: ");
        // Console.Write("user> ");
        // var inputUser = Console.ReadLine();
        // Console.WriteLine("Enter password: ");
        // Console.Write("password> ");
        // var inputPass = Console.ReadLine();
        // Console.WriteLine($"Raw: {inputPass}, Hashed: {Convert.ToHexStringLower(SHA256.HashData(Encoding.UTF8.GetBytes((inputPass) ?? ""))).Replace("-", "")}");
        // if (loginUser != inputUser || loginPass != inputPass)
        // {
        //     Console.WriteLine("Rejected");
        //     return;
        // }
        // Console.WriteLine("Welcome to passman utility shell. Enter help for more information");
        // if (passman.Length == 2)
        // {
        //     Console.WriteLine("No login information saved yet. Create one to view it");
        // }

        Shell.ShellInit();
    }

    private static void Register()
    {
        return;
    }
}