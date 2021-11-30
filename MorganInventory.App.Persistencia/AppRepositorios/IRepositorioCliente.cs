using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioCliente
    {
      IEnumerable<Cliente> GetAll();
      Cliente App(Cliente clientes); 
      Cliente Update(Cliente clientes);
      void Delete(string idCliente);
      Cliente Get(string idCliente);
  
    }
      
}    