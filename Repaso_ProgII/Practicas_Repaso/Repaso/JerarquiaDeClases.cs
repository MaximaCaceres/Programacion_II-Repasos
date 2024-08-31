using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_Repaso.Repaso
{
    public abstract class JerarquiaDeClases//una clase abstracta representa ciertos conceptos que no pueden ser objetos del mundo real.
    {//una clase abstracta puede tener metodos concretos pero una clase concreta no puede tener metodos abstractos
        public string Nombre { get; protected set; }//Funciona como private pero las clases que heredan tambien tienen acceso.
        public int Edad { get;protected set; }
        public JerarquiaDeClases(string nombre)
        {
            Nombre = nombre;
        }

        #region  Polimorfismo se refiere a la capacidad de sobre-escribir metodos.
        public abstract string Sonido();//los metodos abstractos no tienen implementacion en la clase.

        public virtual string Saludar()//con la palabra "virtual" podemos sobre-escribir metodos ()
        {
            string saludo = Sonido();
            return saludo;
        }
        #endregion
    }
}
