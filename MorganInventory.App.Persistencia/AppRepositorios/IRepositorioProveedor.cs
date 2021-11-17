using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioProveedor
    {
      IEnumerable<Proveedor> GetAll();
      Proveedor App(Proveedor proveedor); 
      Proveedor Update(Proveedor proveedor);
      void Delete(string Id_Proveedor);
      Proveedor Get(string Id_Proveedor);
  
    }
      
}    