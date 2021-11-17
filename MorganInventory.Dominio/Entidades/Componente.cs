using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela un Componente de proveedor en el sistema
    /// </sumary>
    public class Componente
    {
        public int Id_Componente{get;set;}
        public string Id_Proveedor{get;set;}
        public string Descripcion{get;set;}
        public int Cantidad{get;set;}
        public double Valorunitario{get;set;}
        public string Catalogo{get;set;}
        
    }
}

