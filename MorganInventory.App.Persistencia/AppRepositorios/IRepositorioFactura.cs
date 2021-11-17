using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioFactura
    {
      /*Lista de Facturas el Ienumerable representa una lista*/
      IEnumerable<Factura> GetAll();
      Factura App(Factura factura); 
      Factura Update(Factura factura);
      void Delete(int NumFactura);
      Factura Get(int NumFactura);
    }
}