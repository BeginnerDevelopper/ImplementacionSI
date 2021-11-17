using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioCategoria : IRepositorioCategoria
    {List<Categoria> categorias;

        public RepositorioCategoria() //constructor
        {
            categorias = new List<Categoria>()
            {new Categoria{
                Codigo = 2001,
                categoria = "Vestimenta"
            },
             new Categoria{
                Codigo = 2002,
                categoria = "Ordenadores"
                
            },

             new Categoria{
                Codigo = 2003,
                categoria = "Consola de videojuegos"
            },

            new Categoria{

                Codigo = 2004,
                categoria = "Peliculas para Play Station 3"
            }

            };
        }
        public IEnumerable<Categoria> GetAll() //Almacena información
        {
            return categorias;
        }
        public Categoria App(Categoria tipodeproducto)
        {
            throw new NotImplementedException();
        }
        public Categoria Update(Categoria tipodeproducto)
        {
            throw new NotImplementedException();
        }
        public void Delete(int Codigo)
        {
            throw new NotImplementedException();
        }
        public Categoria Get(int Codigo)
        {
            throw new NotImplementedException();
        }
  
    }   


        
}

