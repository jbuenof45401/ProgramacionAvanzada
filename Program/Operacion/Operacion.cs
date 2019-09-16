using System;

namespace Operacion
{
    public class Operacion
    {
        public  delegate int operaciones(int a, int b);
        public int sumar(int a, int b){
            return a+b;
        }
        public int restar(int a, int b){
            return a-b;
        }
    }
}
