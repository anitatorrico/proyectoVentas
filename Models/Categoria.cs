
using System.Collections.Generic;

namespace webproject_ef_01.Models.Database{
    public class Categoria{
          public Categoria(){
            
        }
        public int IDCAT {get; set;}
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        
        //relaciona productos con categoria, hace una relacion de uno a muchos
        public ICollection<Producto> Productos {get;set;}
        
    }
}
