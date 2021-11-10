using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio.Entidades
{
    /// <sumary>
    ///  Modela un Cliente en el sistema
    /// </sumary>
    public class Cliente: Persona
    {
        public int Id_Cliente{get;set;}
        public int Identificacion{get;set;}
        public float Descuento{get;set;}
        public List<PedidoVentas> Pedidos{get;set;}
        public Factura Solicita{get;set;}
        
    }
}

