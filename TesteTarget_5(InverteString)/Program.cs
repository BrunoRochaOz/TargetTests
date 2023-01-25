
using System;
using System.Linq;
using static System.Console;


namespace StringInvertida
{
    class Program
    {
        public static string StringInvertida(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            string texto = "Bruno Rocha Oliveira (OZ) Teste 5 Target";
            WriteLine($"Texto Correto: {texto}");
            string textoInvertido = new string(texto.Reverse().ToArray());
            WriteLine($"Texto Invertido: {textoInvertido}");
            WriteLine(StringInvertida("Usando o método StringInvertida"));
            ReadLine();
        }
    }
}