using System.Diagnostics;
using System.Security.AccessControl;

namespace VScode;

public class Program
{

    enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

    static void Main()
    {
        bool escolheusair = false;
        while (!escolheusair)
        {
            Console.WriteLine("Seja bem vindo a Calculadora. Selecione uma das opções: ");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

            Menu opcao = (Menu)int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case Menu.Sair:
                    escolheusair = true;
                    break;
                case Menu.Subtracao:
                    Subtracao();
                    break;
                case Menu.Multiplicacao:
                    Multiplicacao();
                    break;
                case Menu.Soma:
                    Soma();
                    break;
                case Menu.Divisao:
                    Divisao();
                    break;
                case Menu.Potencia:
                    Potencia();
                    break;
                case Menu.Raiz:
                    Raiz();
                    break;
            }

            Console.Clear();
        }




    }

    static void Soma()
    {
        Console.WriteLine("Soma de dois valores");
        Console.WriteLine("Digite o primeiro valor: ");
        int valora = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int valorb = int.Parse(Console.ReadLine());
        int resultadosoma = valora + valorb;
        Console.WriteLine($"O total da soma é {resultadosoma} .");
        Console.WriteLine("Aperte ENTER para voltar ao menu");
        Console.ReadLine();

    }
    static void Subtracao()
    {
        Console.WriteLine("Subtração de dois valores");
        Console.WriteLine("Digite o primeiro valor: ");
        int valora = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int valorb = int.Parse(Console.ReadLine());
        int resultadosub = valora - valorb;
        Console.WriteLine($"O total da subtração é {resultadosub} .");
        Console.WriteLine("Aperte ENTER para voltar ao menu");
        Console.ReadLine();
    }

    static void Multiplicacao()
    {
        Console.WriteLine("Multiplicação de dois valores");
        Console.WriteLine("Digite o primeiro valor: ");
        int valora = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        int valorb = int.Parse(Console.ReadLine());
        int resultadox = valora * valorb;
        Console.WriteLine($"O total da multiplicação é {resultadox} .");
        Console.WriteLine("Aperte ENTER para voltar ao menu");
        Console.ReadLine();
    }

    static void Divisao()
    {
        Console.WriteLine("Divisão de dois valores");
        Console.WriteLine("Digite o primeiro valor: ");
        float valora = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        float valorb = float.Parse(Console.ReadLine());
        float resultadodiv = valora / valorb;
        Console.WriteLine($"O total da divisão é {resultadodiv} .");
        Console.WriteLine("Aperte ENTER para voltar ao menu");
        Console.ReadLine();
    }

    static void Potencia()
    {
        Console.WriteLine("Potência de um valor");
        Console.WriteLine("Digite a base: ");
        int baseNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o expoente: ");
        int expo = int.Parse(Console.ReadLine());
        int resultadox = (int)Math.Pow(baseNum, expo);
        Console.WriteLine($"O resultado é {resultadox} .");
        Console.WriteLine("Aperte ENTER para voltar ao menu");
        Console.ReadLine();
    }
    
    static void Raiz()
    {
        Console.WriteLine("Raiz quadrada de um número");
        Console.WriteLine("Digite o número: ");
        int a = int.Parse(Console.ReadLine());
        double raiz = Math.Sqrt(a);
        Console.WriteLine($"O resultado é {raiz} .");
        Console.WriteLine("Aperte ENTER para voltar ao menu");
        Console.ReadLine();
    }
}







