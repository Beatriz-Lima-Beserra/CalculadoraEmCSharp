using System;

namespace CalcaladoradaMallu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Numero1, Numero2, Resultado = 0.0;
            char operacao;
            int opcao;

            Console.WriteLine("Olá Mallu, digite qualquer tecla para iniciar a sua calculadora");
            Console.ReadLine();

            Console.WriteLine("Digite o primeiro número: ");
            Numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            Numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a operação que deseja realizar(+,-,*,/): ");
            operacao = Convert.ToChar(Console.ReadLine());

            if(operacao == '+')
            {
                Resultado = Numero1 + Numero2;
            }else if(operacao == '-')
            {
                Resultado = Numero1 - Numero2;
            }else if(operacao == '*')
            {
                Resultado = Numero1 * Numero2;
            }else if(operacao == '/')
            {
                Resultado = Numero1 / Numero2;
            }
            Console.WriteLine("O resultado da operação é: " + Resultado);

            Console.WriteLine("Mallu, digite a opção que deseja: ");
            Console.WriteLine("1 - Encerrar calculadora");
            Console.WriteLine("2 - Reiniciar a calculadora");
            
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    {
                        Console.WriteLine("Calculadora encerrada!");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Vamos continuar!");
                        break;
                    }


            }



            


          







        }
    }
}
