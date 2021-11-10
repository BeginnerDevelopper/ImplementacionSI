using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela un Componente de proveedor en el sistema
    /// </sumary>
    public class Mercancías
    {
        public int Id_Mercancías{get;set;}
        public int Id_Proveedor{get;set;}
        public int Idmercancia{get;set;}
        public string Descripcion{get;set;}
        public int Cantidad{get;set;}
        public float Valorunitario{get;set;}
        public string Catalogo{get;set;}
        
    }
}

