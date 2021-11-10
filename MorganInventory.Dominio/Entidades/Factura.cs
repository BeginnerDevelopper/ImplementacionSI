using System;
namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela una Factura en el sistema
    /// </sumary>
    public class Factura
    {
        
        public int Id_Factura{get;set;}
        public int NumFactura{get;set;}
        public string Producto{get;set;}
        public float PrecioUnitario{get;set;}
        public string Categoria{get;set;}
        public string Cliente{get;set;}
        public string Vendedor{get;set;}     
        public DateTime Fechahora{get;set;}
        public Detallefactura Mostrar{get;set;}


    }
}

