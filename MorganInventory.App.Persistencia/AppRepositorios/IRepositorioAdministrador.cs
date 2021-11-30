using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioAdministrador
    {
      /*Administradores del sistema el Ienumerable representa una lista*/
      IEnumerable<Administrador> GetAll(); //Devuelve un valor
      Administrador App(Administrador administrador); 
      Administrador Update(Administrador administrador);
      void Delete(string idAdministrador);
      Administrador Get(string idAdministrador);
    }
}