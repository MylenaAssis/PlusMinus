using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

/*Given an array of integers, calculate the ratios of its elements that are positive, negative and zero. Print the decimal value of each fraction on a new line with 6 places aftes the decimal.
*/

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        List<int> arrayRecebido = arr;
        int totalElementos = arrayRecebido.Count;
        decimal positivos = 0;
        decimal negativos = 0;
        decimal zeros = 0;

        foreach (int a in arrayRecebido)
        {
            if (a > 0)
            {
                positivos++;
            }
            if (a < 0)
            {
                negativos++;
            }
            if (a == 0)
            {
                zeros++;
            }
        }

        decimal porcentagemPositivos = positivos / totalElementos;
        string porcentagemPositivosFormat = porcentagemPositivos.ToString("F6");
        decimal porcentagemNegativos = negativos / totalElementos;
        string porcentagemNegativosFormat = porcentagemNegativos.ToString("F6");
        decimal porcentagemZeros = zeros / totalElementos;
        string porcentagemZerosFormat = porcentagemZeros.ToString("F6");

        Console.WriteLine(porcentagemPositivosFormat);
        Console.WriteLine(porcentagemNegativosFormat);
        Console.WriteLine(porcentagemZerosFormat);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        Result.plusMinus(arr);
    }
}

