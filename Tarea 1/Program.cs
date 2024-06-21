using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Lista_enlazada
{
    class Nodo
    {
        private string dato;
        private Nodo sig;
        private Nodo ant;

        public string Dato 
        {  
            get { return dato; } 
            set {  dato = value; } 
        }
        public Nodo Sig
        {
            get { return sig; }
            set { sig = value; }
        }
        public Nodo Ant
        {
            get { return ant; }
            set { ant = value; }
        }
    }
}