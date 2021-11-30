using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioAutenticaruser
    {
      IEnumerable<Autenticaruser> GetAll();
      Autenticaruser App(Autenticaruser autenticacion); 
      Autenticaruser Update(Autenticaruser autenticacion);
      void Delete(string idAutenticaruser);
      Autenticaruser Get(string idAutenticaruser);
  
    }
      
}    