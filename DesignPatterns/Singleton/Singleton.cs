using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        // Solo para objetos de los que se puede usar uno.

        // Static es para que no sea instanciable, solo se puede hacer uso de ella si se usa la clase.

        //Objeto unico que existe ni bien se compile
        private static readonly Singleton _instance = new Singleton();


        //Metodo de Acceso al objeto ... devuelve el objeto
        public static Singleton Instance
        {
            get
            { return _instance; }
        }

        //Constructor privado impide poder crear un obj de esta clase
        private Singleton() { }


    }
}
