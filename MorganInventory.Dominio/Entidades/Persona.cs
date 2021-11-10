using System;

namespace MorganInventory.Dominio.Entidades
{
    /// <sumary>
    ///  Modela una persona en el sistema
    /// </sumary>
    public class Persona
    {
        public int Id{get;set;}
        public string Nombres{get;set;}
        public string Apellidos{get;set;}
        public string Telefono{get;set;}
        public string Email{get;set;}
        public string Direccion{get;set;}

    }
}