using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._4
//Crear un programa para calcular  el salario semanal de unos empleados a los que se les paga 15 dólares por hora si éstas no superan las 35 horas. 
//Cada hora por encima de 35 se considerará extra y se paga a 22 dólares.  
//El programa pide las horas del trabajador y devuelve el salario que se le debe pagar. 
//Además, el programa debe preguntar si deseamos calcular otro salario, si es así el programa se repite. 

{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("------SALARIO SEMANAL------");

                int hrs_trabajadas = 0;
                int salario = 0;
                int opcion = 0;

                do
                {
                    Console.WriteLine(" Ingrese las horas trabajadas ");
                    hrs_trabajadas = Convert.ToInt32(Console.ReadLine());

                    if (hrs_trabajadas <= 35)
                    {
                        salario = hrs_trabajadas * 15;
                    }
                    else
                    {
                        salario = ((35 * 15) + (hrs_trabajadas - 35) * 22);
                    }
                    Console.WriteLine(" El salario semanal del empleado es " + salario);
                    Console.WriteLine(" ¿Desea consultar otro salario? ");
                    Console.WriteLine(" 1). SI");
                    Console.WriteLine(" 2). NO");

                    opcion = Convert.ToInt32(Console.ReadLine());

                } while (opcion != 2);

                Console.WriteLine(" ");
                Console.WriteLine("------FIN DEL PROGRAMA------");
                Console.ReadKey();      
        }
    }
}
