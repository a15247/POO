using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            float temp1 = 0.0f;
            float temp2 = 0.0f;

            //Introduzir valores para a conversão
            Console.WriteLine("celsius:");
            temp1 = float.Parse(Console.ReadLine());
            Console.WriteLine("fahrenheit:");
            temp2 = float.Parse(Console.ReadLine());
           
            //Calculo da conversao de celsius para fahrenheit e vise versa
            //float celsius = (temp1 - 32) * 5 / 9;
            //float fahrenheit = (temp2 * 9) / 5 + 32;


            for (int i = 0; i < 10; i++)
            {
                if ( temp1 < -10 || temp2 < -10  || temp1 > 100 || temp2 > 100)
                {
                    break;
                }
                else
                {
                    //Calculo da conversao de celsius para fahrenheit e vise versa
                    float celsius = (temp1 - 32) * 5 / 9;
                    float fahrenheit = (temp2 * 9) / 5 + 32;

                    //Apresentar resultados
                    Console.WriteLine("{0} graus Celcius equivale a {1} graus Fahrenheit", temp1, celsius);
                    Console.WriteLine("{0} graus Fahrenheit equivale a {1} graus Celcius", temp2, fahrenheit);


                }

                Console.WriteLine("celsius:");
                temp1 = float.Parse(Console.ReadLine());
                Console.WriteLine("fahrenheit:");
                temp2 = float.Parse(Console.ReadLine());

            }
        }
    }
}