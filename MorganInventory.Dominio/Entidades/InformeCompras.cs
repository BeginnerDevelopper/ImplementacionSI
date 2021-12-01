using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela InformeCompras en el sistema
    /// </sumary>
    public class InformeCompras
    {
        
        public int Id_Compra{get;set;}
        public string Proveedor{get;set;}
        public string Empleado{get;set;}
        public float Neto{get;set;}
        public float Iva{get;set;}
        public float Total{get;set;} 
        public DateTime Fecha{get;set;}   
        
        

    }
}

