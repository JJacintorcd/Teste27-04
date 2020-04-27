using System;
using System.Collections.Generic;
using System.Linq;

namespace Answers
{
    public class OneC
    {
        //função que recebe uma lista e a retorna após efetuar uma operação
      public static List<int> OperationList (ref List<int> listaAOperar)
        {
            //instancia uma lista onde vão ser guardados os resultados
            List<int> result = new List<int>();

            //itera sobre a lista recebida, aplicando a operação
            for (var i = 0; i < listaAOperar.Count; i++)
            {
               result.Add(listaAOperar[i] ^ 2 + 8 * 3);
            }

            //representa a nova lista com o resultado na consola
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
            return result;      
        }

        //public static List<int> OperationLINQ(ref List<int> listaAOperar)
        //{

        //    var nums = from num in listaAOperar select num;

        //    //representa a nova lista com o resultado na consola
        //    foreach (var num in nums)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    return nums;
        //}

    }

}
