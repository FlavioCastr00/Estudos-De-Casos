using System;

namespace OperadoresDeAtribuição
{
    class Programa
    {
        static void Main(String[] args)
        {
            int x = 5, y = 7, z = 12, w = 3;
            
            x += 10; //O mesmo que x = x + 10
            y -= 4;  //O mesmo que y = y - 4
            z *= 2;  //O mesmo que z = z * 2
            w /= 3;  //O mesmo que w = w / 3
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);
        }
    }
}