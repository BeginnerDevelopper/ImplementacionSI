using System;
namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela una Factura en el sistema
    /// </sumary>
    public class Factura
    {
        
        public int NumFactura{get;set;}
        public string Cliente{get;set;}
        public string Vendedor{get;set;}     
        public DateTime Fechahora{get;set;}
        public double Neto{get;set;}
        public float Iva{get;set;}
        public double Total{get;set;}
        public Detallefactura Mostrar{get;set;}


    }
}

