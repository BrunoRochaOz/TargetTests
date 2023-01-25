
internal class Program
{
    private static void Main(string[] args)
    {
        int[] fibo = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597 };
        int num1 = 0, num2 = 1, aux;

        //Calculo Fibonacci       
        for (int i = 0; i​​​​​​​ < 60; i++)
        {
            aux = num1;
            num1 = num2;
            num2 = num1 + aux;
            Console.WriteLine("{0}", num2);

            //Entrada manual dos dados
            if (fibo.Contains(4))
            {
                Console.WriteLine("O numero {4} contém na sequencia Fibonacci");
            }
            else
            {
                Console.WriteLine("Esse numero não contém na sequencia Fibonacci");
            }
        }
    }
}
