using TesteTarget.Calculadora;

internal class Program
{
    private static void Main(string[] args)
    {
        int soma = 0;
        int k = 0;
        int indice = 13;

        while (k < indice)
        {
            k = k + 1;
            soma = soma + k;
        }
        Console.WriteLine(soma);
    }
}