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
    //FALTA TERMINAR
        public IEnumerable<Componente> GetAll()
        {
          return Componentes;
        }
        public Componente App(Componente componentes)
        {
          componentes.Id_Componente=Componentes.Max(r=>r.Id_Componente)+1;
          Componentes.Add(componentes);
          return componentes;
          
        }
        public Componente Update(Componente componentes)
        {          
           var componenteEncontrado = Componentes.SingleOrDefault(p=>p.Id_Componente==componentes.Id_Componente);
      
           if(componenteEncontrado!=null){
           
              componenteEncontrado.Id_Proveedor = componentes.Id_Proveedor;
              componenteEncontrado.Descripcion =componentes.Descripcion;
              componenteEncontrado.Cantidad =componentes.Cantidad;
              componenteEncontrado.Valorunitario =componentes.Valorunitario;
              componenteEncontrado.Catalogo = componentes.Catalogo;
           } 
            return componenteEncontrado;
        }
        public void Delete(int idComponente)
        {
         var componentes = Componentes.SingleOrDefault(p => p.Id_Componente == idComponente);
          if (componentes == null)
                return;
          Componentes.Remove(componentes);
 
        }

      public Componente Get(int idComponente)
        {
          return Componentes.SingleOrDefault(p => p.Id_Componente == idComponente);
        } 

      }




}