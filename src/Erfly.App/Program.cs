using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace Erfly.App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var code = File.ReadAllText(@"Soul.csx");
                await CSharpScript.RunAsync(
                    code,
                    globals: new Globals()
                    {
                        Treshold = 7
                    },
                    globalsType: typeof(Globals)
                    );
            }
            catch(Exception exception)
            {
                var diagnosisService = new DiagnosisService();
                diagnosisService.DignoseTreshold();
                Console.WriteLine(exception);
            }

            Console.ReadLine();
        }
    }

    public class Globals
    {
        public int Treshold { get; set; }
    }
}
