using System;
using System.Collections.Generic;

namespace Programacion_Avanzada_1_Cs
{
    internal class Program
    {
           public delegate void ImprimirDelegado(string value);
        static void Main(string[] args)
        {
            int[] numeros = { 10, 2, 31, 34, 45, 46, 37, 28, 19, 100 };
                Console.WriteLine("------------------PARES----------");

            int[] numerosPares = Functions.NumerosPares(numeros);
            foreach (int numero in numerosPares)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("------------------IMPARES----------");
            int[] numerosImpares = Functions.NumerosImpares(numeros);
            foreach (int numero in numerosImpares)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("------------------ORDER ASC------------");
            int[] numerosOrdenados = Functions.OrdenarLista(numeros);
            foreach (int numero in numerosOrdenados)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("------------------ORDER DESC-------------");
              int[] numerosOrdenadosdesc = Functions.OrdenarListaDescendente(numeros);
            foreach (int numero in numerosOrdenadosdesc)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine("------------------DELEGATE---------------");

            ImprimirDelegado imprimirDelegado = new ImprimirDelegado(Functions.Imprimir);
            imprimirDelegado("texto de ejemplo");

            Console.WriteLine("------------------MAX---------");
            int maxNum=Functions.Maximo(numeros);
            Console.WriteLine(maxNum);
            Console.WriteLine("------------------MIN-----------");
            int minNum = Functions.Minimo(numeros);
            Console.WriteLine(minNum);
            Console.WriteLine("------------------AVG-----------");
            double promedio=Functions.Promedio(numeros);
            Console.WriteLine(promedio);
            Console.WriteLine("------------------RMS---------------");
            int[] numerosrms={2,3,5,6,7};
            double RMS = Functions.RMS(numerosrms);
            Console.WriteLine(RMS);
            Console.WriteLine("------------------INVARIANT--------------");
            var listaPersonas = new List<Persona>(){
                new Becario(),
                new Jefe()
            };
            Utilities.ImprimirPersona(listaPersonas);

            Console.WriteLine("------------------CONTRAVARIANCE----------- ");
            var listaBecarios = new List<Becario>()
            {
                new Becario(),
                new Becario()
            };
            Utilities.ImprimirPersonas(listaBecarios);
            Console.WriteLine("------------------COVARIANCE------------------"); 
            var accionEmpleado = new Action<Empleado>(z => Console.WriteLine("trabajo duro"));
            Utilities.RealizarActionBecario(accionEmpleado);
            Console.WriteLine("------------------DELEGATES------------------");
            Action<string> imprimirAction = v => Console.WriteLine(v);
            Func<int, string> resultado = v => $"el resultado es{v}";
            Predicate<int> mayorDeEdad = e => e >= 18;
            imprimirAction("hola");
            Console.WriteLine(resultado(10));
            if(mayorDeEdad(20))
            {
                Console.WriteLine("es mayor de edad");
            }
            else
            {
                Console.WriteLine("es menor de edad");
            }
        }

        
    }
}
