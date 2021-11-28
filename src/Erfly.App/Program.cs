using System;
using System.IO;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace Erfly.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = File.ReadAllText(@"Soul.csx");
            CSharpScript.RunAsync(code);

            Console.ReadLine();
        }
    }
}
