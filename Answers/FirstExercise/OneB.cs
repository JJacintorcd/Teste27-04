using System;

namespace Answers
{
    public static class OneB
    {
        //função que reecbe string e retorna a metade arredondada para baixo da mesma
        public static string ReceiveStringHalf(string str)
        {
            //retorna o valor da metade da palavra
            double halfDown = Math.Floor(str.Length / 2.0);
            //converte o double obtido num inteiro
            int halved = Convert.ToInt32(halfDown);
            //define a última metade da palavra a ser retornada
            var result = str.Substring(halved, halved);
            return result;          
        }

        //função que valida se a string começa por "a" e acaba em "z"
        public static bool ValidateStringAZ(string str1)
        {
            //valor booleano de validação
            bool validate;
            //converte a string introduzida para letra minuscula, para evitar erros caso haja letras maiusculas
            string low = str1.ToLower();
            //confere se começa por "a"
            var begin = low.StartsWith("a");
            //confere se acaba "z"
            var end = low.EndsWith("z");

            //faz a validação da condição
            if (begin == true && end == true) validate = true;
            else validate = false;

            return validate;
        }

        //função que "limpa" os espaços no inicio e fim de uma string 
        public static string ReturnCleanString(string espaco)
        {
            espaco = espaco.Trim();
            return espaco;
        }

    }  
}
