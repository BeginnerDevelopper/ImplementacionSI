using System;
using System.Collections.Generic;
using System.Linq;
using MorganInventory.Dominio;
namespace  MorganInventory.App.Persistencia
{
    public class RepositorioCategoria : IRepositorioCategoria
    {List<Categoria> Categorias;

        public RepositorioCategoria() //constructor
        {
            Categorias = new List<Categoria>()
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
            return Categorias;
        }
        public Categoria App(Categoria tipodeproducto)
        {
            tipodeproducto.Codigo = Categorias.Max(r=>r.Codigo)+1;
            Categorias.Add(tipodeproducto);
            return tipodeproducto;
        }
        public Categoria Update(Categoria tipodeproducto)
        {
            var ctgEncontrada = Categorias.SingleOrDefault(p => p.Codigo == tipodeproducto.Codigo);
            if (ctgEncontrada != null)
            {
                ctgEncontrada.categoria = tipodeproducto.categoria;  
            }
            return ctgEncontrada;
        }
        public void Delete(int idCategoria)
        {
           var tipodeproducto = Categorias.SingleOrDefault(p => p.Codigo == idCategoria);
          if (tipodeproducto == null)
                return;
          Categorias.Remove(tipodeproducto);

        }
        public Categoria Get(int idCategoria)
        {
            return Categorias.SingleOrDefault(p => p.Codigo == idCategoria);
        }
  
    }   


        
}

