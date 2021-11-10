using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio.Entidades
{
    /// <sumary>
    ///  Modela un Empleado en el sistema
    /// </sumary>
    public class Empleado: Persona
    {
       
        public int Id_Empleado{get;set;}
        public float Salario{get;set;}
        public Venta Ventas{get;set;}
        
    }
}

