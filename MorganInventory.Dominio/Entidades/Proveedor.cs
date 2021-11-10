using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio.Entidades
{
    /// <sumary>
    ///  Modela un Proveedor en el sistema
    /// </sumary>
    public class Proveedor: Persona
    {
        public int Id_Proveedor{get;set;}
        public string Lineadeproductos{get;set;}
        public List<Mercancías> Abastece{get;set;}
        
    }
}

