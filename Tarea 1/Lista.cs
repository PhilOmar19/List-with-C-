using Lista_enlazada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Lista
    {
        private Nodo inicio = new Nodo();
        private Nodo final = new Nodo();

        public Lista()
        {
            inicio = null;
            final = null;
        }

        public void insertar()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato al nuevo nodo: ");
            nuevo.Dato = (Console.ReadLine());

            if (inicio == null)
            {
                inicio = nuevo;
                inicio.Sig = null;
                inicio.Ant = null;
                final = inicio;
            }
            else
            {
                final.Sig = nuevo;
                nuevo.Sig = null;
                nuevo.Ant = null;
                final = nuevo;
            }
            Console.WriteLine("\n Nodo ingresado exitosamente \n");
        }
        public void mostrarListaPF()
        {
            Nodo actual = new Nodo();
            actual = inicio;

            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual = actual.Sig;
            }
        }
        public void borrar()
        {
            Console.WriteLine("¿Desea borrar algún elemento de la lista? (s/n)");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "s")
            {
                Console.WriteLine("Ingrese el dato del nodo que desea borrar: ");
                string datoABorrar = Console.ReadLine();

                Nodo actual = inicio;

                while (actual != null && actual.Dato != datoABorrar)
                {
                    actual = actual.Sig;
                }

                if (actual != null)
                {
                    if (actual.Ant != null)
                    {
                        actual.Ant.Sig = actual.Sig;
                    }
                    else
                    {
                        inicio = actual.Sig;
                    }

                    if (actual.Sig != null)
                    {
                        actual.Sig.Ant = actual.Ant;
                    }
                    else
                    {
                        final = actual.Ant;
                    }

                    Console.WriteLine($"Nodo con dato '{datoABorrar}' borrado exitosamente.");
                }
                else
                {
                    Console.WriteLine($"No se encontró un nodo con el dato '{datoABorrar}'.");
                }
            }
        }
    }
}
