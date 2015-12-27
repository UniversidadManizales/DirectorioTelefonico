using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directorio
{
    public class PersonaDirectorio
    {
        // Atributos de mi Clase
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public bool Favorito { get; set; }

        // Constructor por defecto
        public PersonaDirectorio() { }
        
        // Constructor pasandole los parametros
        public PersonaDirectorio(string _nombre, string _apellido, string _celular, bool _favorito){
	  Nombre = _nombre;
	  Apellido = _apellido;
	  Celular = _celular;
	  Favorito = _favorito;
        }
    }
}
