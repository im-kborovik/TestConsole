using System;
using System.IO;

namespace TestConsole
{
    internal class Program
    {
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
                        Constants.Yes => true,
                        _ => false
                    };
        }

        private static void GenerateTemplate()
        {
            var content = File.ReadAllText(Constants.FilePath);
            var tester = new Tester(content);
            
            tester.WriteLine("Template Content")
                  .Underline()
                  .WriteTemplate()
                  .Underline()
                  .WriteLine("Scriban output")
                  .Underline()
                  .RenderByScriban(AskAboutPreviewMode())
                  .Underline();
        }

        private static bool AskAboutPreviewMode()
        {
            Console.WriteLine("Is preview mode?");

            return Console.ReadKey()
                          .KeyChar
                          .IsYes();
        }
    }
}