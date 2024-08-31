using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_Repaso.Repaso
{
    public class JDC_ClaseHija:JerarquiaDeClases,IComparable//hereda de la clase padre y la interfaz "IComparable"
    {
        public JDC_ClaseHija(string nombre):base(nombre)
        {
            //Con la palabra "base" le pasamos los argmentos a la clase padre.
        }
        public override string Sonido()//con el override podemos sobre-escribir o dar un comportamiento a un metodo heredado.
        {
            string habla = "guau guau";
            return habla;
        }
        public override string Saludar()
        { //aca corcho nos saluda y aparte nos da la pata.
            string darPata = $"Corcho te dio la pata {base.Saludar()}";//el "base" nos permite llamar a metodos y propiedades de la clase padre.
            return darPata;
        }
        #region Metodo ToString() de la clase Object.

        //Todas las clases heredan de la clase object la cual tiene sus propios metodos que pueden ser sobre-escritos.

        //ejemplo: El metodo ToString() Funciona parecido al VerDetalle()

        public override string ToString()//podemos sobre-escribir este metodo e implementarlo de la manera que sea necesario.
        {
            string date = $"{base.Saludar()} y muerde miam miam";
            return date;
        }
        #endregion

        #region Jerarquia De Clases (2)
        //Cuando hereda de IComparable si o si hay que sobre-escribir el metodo CompareTo()
        public int CompareTo(object obj)//sirve para ordenar los objetos dentro de un ArrayList.
        {
            JDC_ClaseHija papurri = obj as JDC_ClaseHija;//el primer paso es hacer un casteo del objeto para poder ordenarlo.
            if (papurri != null)//nos aseguramos de que papurri no sea nulo.
                return Edad.CompareTo(papurri.Edad);//hacemos la comparacion entre los objetos segun la propiedad Nombre.
            return 1;//importante, no olvidar!
        }

        #endregion
    }
}
