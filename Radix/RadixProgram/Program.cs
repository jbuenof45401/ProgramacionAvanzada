using System;

namespace RadixProgram
{
    class Program
    {
        ///Recorre un arreglo y aplica el metodo de ordenamiento radix 
        ///para ordenar los numeros de dicho arreglo.
        static void Main(string[] args)
        {
            Console.WriteLine("Comenzando programa");
            /// inicialización de arreglos
            int[] orArr = new int[5]{20,3,502,72,-10};//arreglo original
            int[] anArr = new int[19]{-9,-8,-7,-6,-5,-4,-3,-2,-1,0,1,2,3,4,5,6,7,8,9};//arreglo de ordenamiento
            //se abre un stream para escribir el el archivo result.txt.
            using (System.IO.StreamWriter file = 
                            new System.IO.StreamWriter(@"result.txt"))
            {              
                /// Arreglo de unidades(hasta centenas)  
                for (int u = 0; u < 3; u++)
                {
                    int[] resultArr =new int[orArr.Length];
                    int cont=-1;
                    int unidad = 0;
                        /// escribe numero de iteración
                        file.WriteLine("Iteración No. "+(u+1));
                        /// arreglo anArr lo recorre para asignar a cada paquete las unidades correspondientes
                        foreach(int i in anArr){                    
                            /// arreglo original, recorre las posiciones y asigna las unidades 
                            foreach(int o in orArr){
                                /// segun el primer arreglo, se analizan las unidades, decenas o centenas.
                                if(u==0)
                                    unidad = (o%100)%10;                        
                                else if(u==1)
                                    unidad = (o%100)/10;    
                                else
                                    unidad = (o/100);       
                                // si coincide el numero del arreglo original con el arreglo de ordenamiento
                                // se lo asigna al arreglo resultante, en el orden de coincidencia.                                  
                                if(unidad==i){
                                    resultArr[++cont]=o;
                                    file.WriteLine(i+":"+o);                                    
                                }                        
                            }
                        }
                        cont = -1;
                        ///Iguala el arreglo resultante al arreglo original
                        for (int m = 0; m <= resultArr.Length-1; m++)
                            {
                                orArr[m]=resultArr[m];
                            }            
                        ///Imprime el resultado de la iteración.
                        string resultado="Vector resultante: [";             
                        foreach(int l in orArr){
                            resultado += l+",";
                        }
                        resultado = resultado.Substring(0,resultado.Length-1);
                        resultado +="]";
                        file.WriteLine(resultado);
                    }
            }
            Console.WriteLine("Termino Programa");
        }
    }
}
