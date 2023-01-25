using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

 static void LerArquivoJson(string dados)
 {
    using (StreamReader r = new StreamReader(dados))
    {
        string json = r.ReadToEnd();
        JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        dynamic array = serializer.DeserializeObject(json);
        Console.WriteLine("");
        Console.WriteLine(serializer.Serialize(array));
        Console.WriteLine("");
        Console.ReadKey();
    }
}


int aux = 0;
float valorMaior = 0;
float valorMenor = 0;
int soma = 0;
int media = 0;

for (dia in dados)
{
    if (dia("valor") != 0)
        aux = dia("valor");

        if (aux > valorMaior)
        {
        valorMaior = aux;
        }

        if (valorMenor == 0)
        {
        valorMenor = aux;
        }else (aux < valorMenor)
        {
        valorMenor = aux;
        }

    soma += dia("valor");

    Console.WriteLine("O maior valor de faturamento do mês foi: R$ " + valorMaior + ".");
    Console.WriteLine("O menor valor de faturamento do mês foi: R$ " + valorMenor + ".");

    int diasFaturamento;

    media = soma / dados;

    for (i in dados)
    {
        if(i("valor") != 0)
        {
            diasFaturamento += (in("dia")+ " ");

        Console.WriteLine("Os dias em que o faturamento foram maiores que a média foram {dia} " + diasFaturamento);
        }
    }

}