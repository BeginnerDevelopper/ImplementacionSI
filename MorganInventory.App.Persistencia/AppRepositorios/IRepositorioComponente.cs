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
      void Delete(int Id_Componente);
      Componente Get(int Id_Componente);
  
    }
      
}    