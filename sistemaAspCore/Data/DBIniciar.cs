using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using sistemaAspCore.Models;

namespace sistemaAspCore.Data
{
    public class DBIniciar
    {
        public static void Iniciar(sistemaAspCoreContext context)
        {
            //creo la bd
            context.Database.EnsureCreated();
            //buscar si existen registros en la tabla categoria
            if (context.Categoria.Any())
            {
                return;
            }
            //lleno la tabla categoria
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programacion",Descripcion="Cursos de programacion",Estado=true},
                new Categoria{Nombre="Diseño grafico",Descripcion="Cursos de diseño grafico",Estado=true},
                new Categoria{Nombre="Ingles",Descripcion="Ingles basico",Estado=true},
                new Categoria{Nombre="Economia",Descripcion="Economia actual",Estado=true},
                new Categoria{Nombre="Contabilidad",Descripcion="Contabilidad financiera",Estado=true}
            };
            //recorrer el vector y agrego cada obj
            foreach (Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }
            context.SaveChanges();
        }
    }
}
