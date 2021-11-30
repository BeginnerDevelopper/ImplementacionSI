using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioComponente
    {
      IEnumerable<Componente> GetAll();
      Componente App(Componente componentes); 
      Componente Update(Componente componentes);
      void Delete(int idComponente);
      Componente Get(int idComponente);
  
    }
      
}    