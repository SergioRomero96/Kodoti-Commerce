using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Common.Collection
{
    public class DataCollection<T>
    {
        public bool HasItems
        {
            get
            {
                return Items != null && Items.Any();
            }
        }

        public IEnumerable<T> Items { get; set; }
        //Cantidad de registros que hay
        public int Total { get; set; }
        //Cantidad de pagina en la que se encuentra
        public int Page { get; set; }
        //Cantidad de paginas que ha generado dicha paginación
        public int Pages { get; set; }
    }
}
