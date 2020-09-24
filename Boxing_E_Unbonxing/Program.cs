using System;

namespace Boxing_E_Unbonxing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Boxing: É o processo de conversão de um objeto tipo VALOR
            para um objeto tipo referência compatível.
            Ele pega o valor da viriável original que esta na memória STACK
            e envia seu valor para a memória tipo HEAP ficando na memória stack
            apenas a variáves que aponta para esse valor.
            */

            int X = 20;

            Object obj1 = X;
            /* Object é um tipo genérico da linguagem C#, ou seja,
            ele aceita qualquer tipo de valor(int, double, string e etc...
            Ele também é um tipo REFERÊNCIA(CLASSE) ou seja ele serve para apontar
            para o valor atribuido a ele.
             */

            /*
            Unboxing: É o processo de conversão de um objeto tipo referência
            para um objeto tipo valor compatível.
            Pegando o valor que estava na memória HEAP e passando para a variável
            de destino na memória STACK.
             */

            int y = 20;
            Object obj2 = y;
            int z= (int)obj2; /*É o processo inverso do BOXING, ou seja,
                               ele atribui o valor do objeto para a variável*/
        }
    }
}
