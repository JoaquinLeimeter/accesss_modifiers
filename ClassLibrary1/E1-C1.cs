using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //accesible dentro de este proyecto y cualquier otro de la solución.
    public class E1_C1
    {
        //si lo cambio a internal object private, tengo un error en ConsoleApp1.
        public E1_C1() { }
        public void doSomething()
        {
            Console.WriteLine("doSomething called");
        }

        //pero acá no se puede porque no tengo acceso a clase_privada.
        //void test()
        //{
        //    clase_privada hola = new clase_privada();
        //    hola.doSomething();
        //}
    }

    //accesible solo dentro de este proyecto
    internal class clase_interna
    {
        public clase_interna() { }
        public void doSomething()
        {
            Console.WriteLine("doSomething called en clase_interna");
        }
        
        //este método por defecto private hace uso de clase_privada. creo
        private void test()
        {
            clase_privada hola = new clase_privada();
            hola.doSomething();
        }
        //accesible solo dentro de esta clase interna
        private class clase_privada
        {
            public clase_privada() { }
            public void doSomething()
            {
                Console.WriteLine("doSomething called en clase_privada");
            }

            clase_privada hola = new clase_privada();
        }
    }
}
