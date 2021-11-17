using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioPedidoVentas
    {
      /*Lista de PedidoVentass el Ienumerable representa una lista*/
      IEnumerable<PedidoVentas> GetAll();
      PedidoVentas App(PedidoVentas Pedido); 
      PedidoVentas Update(PedidoVentas Pedido);
      void Delete(int Id_Pedido);
      PedidoVentas Get(int Id_Pedido);
    }
}