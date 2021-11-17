using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioAdministrador:IRepositorioAdministrador
{  List<Administrador> Admin;
     public RepositorioAdministrador()
    { 
      Admin = new List<Administrador>()

     {new Administrador{

          Id = "10056A",
          Nombres = "William",
          Apellidos = "Arias",
          Telefono = 57360789133,
          Email = "CarlosA360@gmail.com",
          Direccion = "calle 22 #12 a 33-01",
          Cuidad = "Pereira"

        },
        
          new Administrador{

          Id = "15127B",
          Nombres = "Luz Mary ",
          Apellidos = "Gutierrez Bedoya",
          Telefono = 57360789133,
          Email = "melomam0@gmail.com",
          Direccion = "San andresito local",
          Cuidad = "Pereira"

        }

        };

    }
        public IEnumerable<Administrador> GetAll()
        {
          return Admin; 
        }
        public Administrador App(Administrador administrador)
        {
          throw new NotImplementedException();
        }
        public Administrador Update(Administrador administrador)
        {
          throw new NotImplementedException();
        }
        public void Delete(string Id_Administrador)
        {
          throw new NotImplementedException();
        }

        public Administrador Get(string Id_Administrador)
        {
          throw new NotImplementedException();
        }

    }

}

 
  
