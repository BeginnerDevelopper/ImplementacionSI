using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
   public class RepositorioComponente : IRepositorioComponente
   { List<Componente> Componentes;

     public RepositorioComponente()
     {
         Componentes = new List<Componente>()
        { new Componente{
            Id_Componente = 1001,
            Id_Proveedor = "1005k",
            Valorunitario = 350.000F,  
            Cantidad = 8,
            Catalogo = "Novaventa",
            Descripcion = "Bocina Panasonic XT-500 Ultraboost"

        },
        
          new Componente{
            Id_Componente = 1002,
            Id_Proveedor = "1006k",
            Valorunitario = 1.200000F,  
            Cantidad = 05,
            Catalogo = "No hay",
            Descripcion = "Televisor Full HD Samsung 52' pulg."

        },

           new Componente{
            Id_Componente = 1003,
            Id_Proveedor = "1007k",
            Valorunitario = 350.000F,  
            Cantidad = 18,
            Catalogo = "RockDreams",
            Descripcion = "Unidad de camisas y buzos para dama y caballero"
        
        }




        }; 
     }

        public IEnumerable<Componente> GetAll()
        {
          return Componentes;
        }
        public Componente App(Componente componentes)
        {
          throw new NotImplementedException();
        }
        public Componente Update(Componente componentes)
        {
          throw new NotImplementedException();
        }
        public void Delete(int Id_Componente)
        {
          throw new NotImplementedException();
        }

      public Componente Get(int Id_Componente)
        {
          throw new NotImplementedException();
        } 

      }




}