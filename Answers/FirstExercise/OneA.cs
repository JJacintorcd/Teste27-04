using System;
using System.Collections.Generic;

namespace Answers
{
    public static class OneA
    {

        //função para retornar um número impar maior que 50 e divisivel por 9 num array
        public static int ReceiveAndReturnArray(int a, int b, int c, int d, int e)
        {
            //criar um novo array
            int[] array = new int[5] { a, b, c, d, e };

            //foreach para iterar sobre o array 
            foreach(var num in array)
            {
                if (num > 50 && num % 2 != 0 && num % 9 == 0) return num;
            }
            return 0;
        }

        //função para retornar um número impar maior que 50 e divisivel por 9 numa lista
        public static int ReceiveAndReturnList(int a, int b, int c, int d, int e)
        {
            //criar uma nova lista
            List<int> listaDeNumeros = new List<int> { a, b, c, d, e };

            //iterar sobre a lista
            foreach (var num in listaDeNumeros)
            {
                if (num > 50 && num % 2 != 0 && num % 9 == 0) return num;
            }
            return 0;
        }
    }

  
}
