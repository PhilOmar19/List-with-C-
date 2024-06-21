using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args) 
        { 
            Lista le= new Lista();
            le.insertar();
            le.insertar();
            le.insertar();
            le.insertar();
            le.insertar();
            le.insertar();
            le.insertar();
            Console.Clear();
            Console.WriteLine("Los datos ingresados son: ");
            Console.WriteLine("Del primero al ultimo");
            le.mostrarListaPF();
            le.borrar();
        }
    }
}
