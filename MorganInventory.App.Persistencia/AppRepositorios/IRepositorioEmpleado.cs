using System.Collections.Generic;
using System;
using MorganInventory.Dominio;
namespace MorganInventory.App.Persistencia
{
    public interface IRepositorioEmpleado
    {
      IEnumerable<Empleado> GetAll(); //Devuelve un valor
      Empleado App(Empleado empleado); 
      Empleado Update(Empleado empleado);
      void Delete(string Id_Empleado);
      Empleado Get(string Id_Empleado);
  
    }
      
}    