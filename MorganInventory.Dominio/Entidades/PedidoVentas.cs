using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela un Pedido ventas para clientes en el sistema
    /// </sumary>
    public class PedidoVentas

    {
        public int Id_Pedido{get;set;}
        public string Nombre{get;set;}
        public string Apellidos{get;set;}
        public long Nitcedula{get;set;}
        public int Cantidad{get;set;}
        public double Precioventa{get;set;}
        public string Estado{get;set;}
        public DateTime Fecha {get;set;}
        public string Descripcion{get;set;}
        
        
    }
}

