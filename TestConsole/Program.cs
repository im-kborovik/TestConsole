using System;
using System.IO;

namespace TestConsole
{
    internal class Program
    {
        private const char Yes = 'y';
        public const string FilePath = "../../../template.html";
        private static bool _exit = false;
        
        private static void Main(string[] args)
        {
            // var switcher = BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly);
            // switcher.Run(args);

            // var tester = new Tester();
            //
            // tester
            //     .Underline()
            //     .RenderByScriban();

            while (!_exit)
            {
                CanStartQuestion();

                GenerateTemplate();
                
                SuggestToExit();
            }
        }

        private static void CanStartQuestion()
        {
            Console.WriteLine("Please press any key when system can read template.");
            Console.ReadKey();
        }

        private static void SuggestToExit()
        {
            Console.WriteLine("Would you like to stop?");
            var answer = Console.ReadKey();

            _exit = answer.KeyChar switch
                    {
                        Yes => true,
                        _ => false
                    };
        }

        private static void GenerateTemplate()
        {
            var content = File.ReadAllText(FilePath);
            var tester = new Tester(content);
            
            tester.WriteLine("Template Content")
                  .Underline()
                  .WriteTemplate()
                  .Underline()
                  .WriteLine("Scriban output")
                  .Underline()
                  .RenderByScriban()
                  .Underline();
        }
    }
}