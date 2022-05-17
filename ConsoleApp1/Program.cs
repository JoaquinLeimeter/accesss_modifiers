using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregamos la referencia a el ensamble ClassLibrary1 
//y lo agregamos usando la palabra "using"
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos un objeto de la clase E1_C1.
            E1_C1 someClass = new E1_C1();
            //notamos cuales son los m'etodos que nos deja utilizar, solo los públicos.
            //y los propios de todo objeto.
            someClass.doSomething();
            someClass.GetType();
            //podríamos usar ClassLibrary1 directo sin "using"
            //pero se nota que no es muy lindo así.
            //ademas VS nos sugiere simplificar el nombre.
            ClassLibrary1.E1_C1 otherObject = new ClassLibrary1.E1_C1();

            //sucede lo mismo con "System"
            System.Console.WriteLine();
            Console.WriteLine();
            
        }
    }
}
