using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas_Repaso.Repaso
{
    public class JerarquiaDeObjetos//este es el {todo}, tambien llamado {claseContenedora}
    {
        //Una relacion entre clases esta dada por el {todo} y sus partes.
        //para establecer esta relacion tenemos que representar dos cosas: "La cardinalidad y el tipo de relacion"
        #region Para representar la cardinalidad: (casi siempre es privada)
        public AbstraccionYEncapsulamiento unoAuno { get; private set; }//0..1 //la propiedad debe ser del tipo de la parte.
        public AbstraccionYEncapsulamiento[] deN_a_M = new AbstraccionYEncapsulamiento[5];//0..n o n..m
        ArrayList muchos = new ArrayList();//0..* o n..* //dinamico.
        #endregion

        #region Composicion y Agregacion. (la relacion se establece segun donde se encuentre la palabra reservada new)
        //La composicion es una relacion en donde el {todo} se encarga de crear la parte.

        AbstraccionYEncapsulamiento composicion = new AbstraccionYEncapsulamiento(12);//esta es la {parte}
        //aqui el todo se encarga de crear la parte.

        //La agregacion es una relacion donde la parte se crea afuera del todo.
        public JerarquiaDeObjetos(AbstraccionYEncapsulamiento obj)//aca el todo recibe a la parte
        {
            unoAuno = obj;
        }

        #endregion

        #region Metodos Ver y Agregar
        public void Agregar(AbstraccionYEncapsulamiento obj)//otra forma de que se cumpla la relacion de agregacion
        {
            muchos.Add(obj);
        }
        public string VerDetalle()
        {
            string date = $"{unoAuno}";
            return date;
        }

        #endregion

    }
}
