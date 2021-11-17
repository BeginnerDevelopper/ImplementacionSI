using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioProducto
    {
      /*Lista de Productos el Ienumerable representa una lista*/
      IEnumerable<Producto> GetAll(); //Devuelve un valor
      Producto App(Producto producto); //App muestra la lista de los productos
      Producto Update(Producto producto);
      void Delete(int Id_Producto);
      Producto Get(int Id_Producto);
    }
}