using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioAdministrarUsuarios
    {
      IEnumerable<AdministrarUsuarios> GetAll();
      AdministrarUsuarios App(AdministrarUsuarios usuario); 
      AdministrarUsuarios Update(AdministrarUsuarios usuario);
      void Delete(int idAdministrarUsuarios);
      AdministrarUsuarios Get(int idAdministrarUsuarios);
  
    }
      
}    