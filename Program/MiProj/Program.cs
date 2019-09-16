using System;
using Operacion;
namespace MiProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion.Operacion op = new Operacion.Operacion();
            Operacion.Operacion.operaciones delOpe = new Operacion.Operacion.operaciones(op.sumar);
            Console.WriteLine(delOpe.Invoke(10,5));
            delOpe += op.restar;                        
            Console.WriteLine(delOpe.Invoke(10,5));
            int[][] arr1 =new int[2][] {
    new [] {10,20,30},
    new [] {40,50,60}
};
///Multidimensional, Se guarda contiguo en la memoria
    int[,] arr2 = new int[2,3]{
        {10,20,30},
        {40,50,60}
    };
    foreach(int i in arr2)
    {
        Console.WriteLine(i);        
    };

        }
    }
}
