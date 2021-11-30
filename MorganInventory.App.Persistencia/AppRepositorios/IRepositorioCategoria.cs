using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioCategoria
    {

      IEnumerable<Categoria> GetAll(); //Devuelve un valor
      Categoria App(Categoria tipodeproducto); 
      Categoria Update(Categoria tipodeproducto);
      void Delete(int idCategoria);
      Categoria Get(int idCategoria);
    }
}