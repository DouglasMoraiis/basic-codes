using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingInterface
{
    /*
        Uma interface tem o papel de exigir que 
        a classe que a implementar deve implementar
        também os métodos declarados nela.
    */
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var consoleLogger = new ConsoleLogger();
            consoleLogger.LogInfo("Essa é uma mensagem de informação!");
            consoleLogger.LogError("Essa é uma mensagem de error!");
        }
    }
}
