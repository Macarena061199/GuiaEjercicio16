using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaEjercicio16
{
    internal class Ejercicio
    {
        /* 16.	Solicite un ingreso al usuario y determine si puede ser interpretado como un número entero.
        (De aquí en más todos los ingresos del usuario deben ser verificados, finalizando el programa con un 
        mensaje de error en caso de ser inválidos)*/

        public void Ejercicio16()
        {
            bool flag = false;
            do
            {
                Console.Write("Por favor ingrese un número entero: ");
                string ingreso = Console.ReadLine();
                flag = ValidadNumero(ingreso);

                if(flag==true)
                {
                    Console.WriteLine($"El número ingresado fue {ingreso}.");
                }
               
            }while(flag==false);
            

            
        }

        private bool ValidadNumero(string ingreso)
        {
            bool flag = false;
            if(!int.TryParse(ingreso, out int salida))
            {
                Console.WriteLine("Por favor ingrese un valor numérico.");
            }
            else if(salida < 0)
            {
                Console.WriteLine("Por favor ingrese un número posiivo.");
            }
            else
            {
                flag=true;
            }
            return flag;

        } 
    }
}
