using System;

namespace prova_paradigma.Utils
{
    public static class Logger
    {
        public static void ExceptionToConsole(string message)
        {
            var formatedMessage = $"Resultado: Exceção {message}";
            ToConsole(formatedMessage);
        }
        public static void ToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}