using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using agregado para async
using Microsoft.EntityFrameworkCore;

namespace sistemaAspCore
{
    public class Paginacion<T> : List<T>
    {
        public int Pagina { get; private set; }
        public int Totalpagina { get; private set; }
        public int TotalR { get; private set; }
        public Paginacion(List<T> items, int count, int pagina, int pagesize)
        {
            Pagina = pagina;
            Totalpagina = (int)Math.Ceiling(count / (double)pagesize);

            TotalR = count;
            this.AddRange(items);
        }
        public bool HaspreviousPage
        {
            get
            {
                return (Pagina > 1);
            }
        }
        public bool HasnextPage
        {
            get
            {
                return (Pagina < Totalpagina);
            }
        }
        public static async Task<Paginacion<T>> CreateAsync(IQueryable<T> source, int Pagina, int pagesize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((Pagina - 1) * pagesize).Take(pagesize).ToListAsync();
            return new Paginacion<T>(items, count, Pagina, pagesize);
        }
    }
}
