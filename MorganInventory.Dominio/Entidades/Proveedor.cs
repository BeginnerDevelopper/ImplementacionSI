using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela un Proveedor en el sistema HEREDA DE PERSONA
    /// </sumary>
    public class Proveedor: Persona
    {
        public string Id_Proveedor{get;set;}
        public string Lineadeproductos{get;set;}
        public List<Componente> Abastece{get;set;}
        
    }
}

