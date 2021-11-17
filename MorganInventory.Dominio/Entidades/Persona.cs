using System;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela una persona en el sistema
    /// </sumary>
    public class Persona
    {
        public string Id{get;set;}//dato entero con capacidad de 4 bytes
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public long Telefono{get;set;} // datos enteros largos con capacidad de 8 bytes
        public string Email{get;set;}
        public string Direccion{get;set;}
        public string Cuidad {get;set;}
       

    }
}