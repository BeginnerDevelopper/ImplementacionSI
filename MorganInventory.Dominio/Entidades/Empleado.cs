using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela una entidad de Empleado en el sistema
    /// </sumary>
    public class Empleado: Persona
    {
       
        public string Id_Empleado{get;set;}
        public double Salario{get;set;}
        public Venta Ventas{get;set;}
        
    }
}

