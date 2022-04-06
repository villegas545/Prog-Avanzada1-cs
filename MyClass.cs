using System;
using System.Collections.Generic;

namespace Programacion_Avanzada_1_Cs
{
    public class Persona
    {
        public string Name { get; set; }
    }
    public class Empleado:Persona{
        public int Id { get; set; }
    }
    public class Jefe:Empleado{

    }
    public class Becario:Empleado{

    }
    public static class Utilities{
        //invariant
        public static void ImprimirPersona(List<Persona> personas){
            foreach (Persona persona in personas)
            {
                Console.WriteLine($"El elemento actual es de tipo {persona.GetType().ToString()}");            
            }
        }
        //covariance
        public static void ImprimirPersonas(IEnumerable<Persona> personas){
            foreach (var persona in personas)
            {
                Console.WriteLine($"El elemento actual es de tipo {persona.GetType().ToString()}");
            }
        }
        //contravariance
        public static void RealizarActionBecario(Action<Becario> becarioAction)
        {
            Becario becario = new Becario();
            becarioAction(becario);
        }
    }
}