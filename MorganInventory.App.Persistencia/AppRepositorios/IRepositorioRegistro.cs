using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{

    public interface IRepositorioRegistro
    {
      IEnumerable<Registro> GetAll();
      Registro App(Registro crearcuenta); 
      Registro Update(Registro crearcuenta);
      void Delete(string idRegistro);
      Registro Get(string idRegistro);
  
    }
      
}    
