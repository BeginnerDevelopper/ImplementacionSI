using System;
using System.Collections.Generic;

namespace MorganInventory.Dominio
{
    /// <sumary>
    ///  Modela un Pedido ventas para clientes en el sistema
    /// </sumary>
    public class PedidoVentas

    {
        public int Codigo{get;set;}
        public DateTime Fechahora {get;set;}
        public string Nombre{get;set;}
        public int Apellidos{get;set;}
        public int Cantidad{get;set;}
        public float Valorunitario{get;set;}
        public string Estado{get;set;}
        public string Descripcion{get;set;}
        public int Id_Mercancías{get;set;}
        
    }
}

