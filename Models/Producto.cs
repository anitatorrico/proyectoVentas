
using System.Collections.Generic;

namespace webproject_ef_01.Models.Database{
    public class Producto{
          public Producto(){
            
        }
        public int ID {get; set;}
        public string Nombre {get; set;}
        public string Precio {get; set;}
        public string Descripcion {get; set;}//  public string ID Categoria {get; set;}
        
         //ManyToOne -> a Producto belongs to one Location, one Location can be linked to many Productos
         //producto pertenece a una categoria, permite relacionar a este producto con categoria
        // public Categoria Categoria {get; set;}

    }
}
