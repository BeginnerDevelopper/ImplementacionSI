using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioInformeCompras
    {

      IEnumerable<InformeCompras> GetAll(); //Devuelve un valor
      InformeCompras App(InformeCompras compras); 
      InformeCompras Update(InformeCompras compras);
      void Delete(int idInformecompras);
      InformeCompras Get(int idInformeCompras);
    }
}