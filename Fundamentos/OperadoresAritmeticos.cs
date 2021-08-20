﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos 
    {
        public  static void Executar()
        { // preço com Desconto
            var preco = 1000.0;
            var imposto= 355;
            var desconto = 0.1;
            double total = preco + imposto;
            var totalComDesocnto = total - (total * desconto);
            Console.WriteLine("Total final é {0} ", totalComDesocnto);
            Console.WriteLine(" Total final é " + totalComDesocnto);
            //IMC
            double peso = 91.2;
            double altura = 1.82;
            // double imc =peso/ (altura *altura) // ou usar o metodo Math.Pow() 
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine(" IMC é :"+ imc.ToString("F2"));

            // Numero Par / Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine(" {0}/2 tem resto {1} ", par ,par%2);
             Console.WriteLine( par +"/2 tem resto "+ par % 2);
            Console.WriteLine(" {0}/2 tem resto {1} ", impar, impar % 2);
            Console.WriteLine( impar +"/2 tem resto "+ impar % 2);

        }
    }

}

