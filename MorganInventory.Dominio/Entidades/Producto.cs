using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela un Producto en el sistema
    /// </sumary>
    public class Producto
    {
        
        public int Id_Producto{get;set;}
        public float Preciocompra{get;set;}
        public float Precioventa{get;set;}
        public int Cantidad{get;set;} 
        public DateTime Añadido{get;set;}   
        public Venta Ventas{get;set;}  //Enumeration
        public List<Categoria> Listas{get;set;}
        public Estadoprod Condicion{get;set;}//Enumeration

    }
}

