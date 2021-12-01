using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela un Informeventas en el sistema
    /// </sumary>
    public class Informeventas
    {
        
        public int Id_Venta{get;set;}
        public string Vendedor{get;set;}
        public string Cliente{get;set;}
        public float Neto{get;set;}
        public float Iva{get;set;}
        public float Total{get;set;} 
        public DateTime Fecha{get;set;}   
        
        

    }
}

