using System;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela un administrador en el sistema
    /// </sumary>
    public class Administrador: Persona
    {
        public string Id_Administrador{get;set;}
        public string Listarusuarios{get;set;}
        public string Registroinventario{get;set;}
        public Inventarioinsumo gestiona{get;set;} //enumeration
        
    }
}

