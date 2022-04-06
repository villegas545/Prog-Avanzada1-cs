using System;

namespace Programacion_Avanzada_1_Cs
{
    public static class Functions
    {
        //funcion numeros pares
        public static int[] NumerosPares(int[] numeros)
        {
            int[] numerosPares = new int[0];
            int contador = 0;
                  foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    Array.Resize(ref  numerosPares,  numerosPares.Length+1);
                    numerosPares[contador] = numero;
                    contador++;
                }
            }
            return numerosPares;
        }
        //funcion numeros impares
        public static int[] NumerosImpares(int[] numeros)
        {
            int[] numerosImpares = new int[0];
            int contador = 0;
            foreach (int numero in numeros)
            {
                if (numero % 2 != 0)
                {
                    Array.Resize(ref numerosImpares, numerosImpares.Length + 1);
                    numerosImpares[contador] = numero;
                    contador++;
                }
            }
            return numerosImpares;
        }
        //Ascending order
        public static int[] OrdenarLista(int[] numeros)
        {
            int[] numerosOrdenados = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                numerosOrdenados[i] = numeros[i];
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numerosOrdenados[i] < numerosOrdenados[j])
                    {
                        int aux = numerosOrdenados[i];
                        numerosOrdenados[i] = numerosOrdenados[j];
                        numerosOrdenados[j] = aux;
                    }
                }
            }
            return numerosOrdenados;
        }
        public static int[] OrdenarListaDescendente(int[] numeros)
        {
            int[] numerosOrdenados = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                numerosOrdenados[i] = numeros[i];
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numerosOrdenados[i] > numerosOrdenados[j])
                    {
                        int aux = numerosOrdenados[i];
                        numerosOrdenados[i] = numerosOrdenados[j];
                        numerosOrdenados[j] = aux;
                    }
                }
            }
            return numerosOrdenados;
        }
        
        public static bool EsMultiploDeTres(int numero)
        {
            if (numero % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
 
   public static void Imprimir(string valor)
        {
            Console.WriteLine(valor);
        }
        public static int Maximo(int[] numeros)
        {
            int maximo = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (maximo < numeros[i])
                {
                    maximo = numeros[i];
                }
            }
            return maximo;
        }

        public static int Minimo(int[] numeros)
        {
            int minimo = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (minimo > numeros[i])
                {
                    minimo = numeros[i];
                }
            }
            return minimo;
        }
        public static double Promedio(int[] numeros)
        {
            double promedio = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                promedio += numeros[i];
            }
            promedio = promedio / numeros.Length;
            return promedio;
        }
        public static double RMS(int[] numeros)
        {
            double suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                suma += Math.Pow(numeros[i], 2);
            }
            suma = suma / numeros.Length;
            return Math.Sqrt(suma);
        }
       

    }
}