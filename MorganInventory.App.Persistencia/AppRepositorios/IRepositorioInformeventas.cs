using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioInformeventas
    {

      IEnumerable<Informeventas> GetAll(); //Devuelve un valor
      Informeventas App(Informeventas ventas); 
      Informeventas Update(Informeventas ventas);
      void Delete(int idInformeventas);
      Informeventas Get(int idInformeventas);
    }
}