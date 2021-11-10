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
        public int Id_Mercancías{get;set;}
        public float Precio{get;set;}
        public int Cantidad{get;set;}
        public string Estado{get;set;}     
        public Venta Ventas{get;set;}  //Enumeration
        public List<Categoria> Listas{get;set;}
        public Estadoprod Condicion{get;set;}//Enumeration

    }
}

