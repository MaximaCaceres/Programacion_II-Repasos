using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_Repaso.Repaso 
{
   public class AbstraccionYEncapsulamiento
    {
        /*
         * Propiedades (lagas y cortas)
         * Constructores
         * Modificadores de acceso
         * Referencia de instancia (this)
         */

        #region Propiedades (Largas y Cortas)
        //Las propiedades cortas las utilizamos cuando tenemos que almacenar un valor constante.
            public string Ejemplo { get; private set; }//por lo general el set siempre es privado.
        //Modificador de alcance//

        //A las largas las usamos cuando necesitamos almacenar un valor dinamico.

        //Imagine que necesitamos calcular un descuento de una compra.
        public double Valor = 0; //Necesitamos un atributo para guardar el valor de la compra el cual es diferente.
        public double Ejemplo2//en esta propiedad guardaremos el valor del descuento.
        {
            get//utilizamos getter para calcular el descuento.
            {
                double ret = Valor * 0.25;
                return ret;
            }
            //como queremos mantener el setter en private no lo definimos.
        }
        
        #endregion
        public AbstraccionYEncapsulamiento(double Valor)//Un constructor funciona como un metodo pero nos sirve para crear objetos.
        {                                               //"Le da al obj un estado inicial".
            this.Valor = Valor;//con el "this" diferenciamos el atributo de una variable (local o de instancia).
        }
    }
}
