using System;

namespace URI_1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            int impar1 = 0;
            int impar2 = 0;
            int impar3 = 0;
            int impar4 = 0;
            int impar5 = 0;
            int impar6 = 0;

            if (valor % 2 == 0){
                impar1 = valor + 1;
                impar2 = impar1 + 2;
                impar3 = impar2 + 2;
                impar4 = impar3 + 2;
                impar5 = impar4 + 2;
                impar6 = impar5 + 2;
                Console.WriteLine(impar1);
                Console.WriteLine(impar2);
                Console.WriteLine(impar3);
                Console.WriteLine(impar4);
                Console.WriteLine(impar5);
                Console.WriteLine(impar6);
            }
            else {
                impar1 = valor;
                impar2 = impar1 + 2;
                impar3 = impar2 + 2;
                impar4 = impar3 + 2;
                impar5 = impar4 + 2;
                impar6 = impar5 + 2;
                Console.WriteLine(impar1);
                Console.WriteLine(impar2);
                Console.WriteLine(impar3);
                Console.WriteLine(impar4);
                Console.WriteLine(impar5);
                Console.WriteLine(impar6);
            }               
            
        }
    }
}

