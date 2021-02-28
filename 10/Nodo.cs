using System;

namespace ArbolGrafoLista {
	class Nodo {
		//Atributos propios
		public string Cadena { get; set; }
		public char Caracter { get; set; }
		public int Entero { get; set; }
		public double NumReal { get; set; }

		//Apuntadores para listas doblemente enlazadas
		public Nodo NodoIzq;
		public Nodo NodoDer;

		//Constructor
		public Nodo(string Cadena, char Caracter, int Entero, double NumReal, Nodo NodoDer) {
			this.Cadena = Cadena;
			this.Caracter = Caracter;
			this.Entero = Entero;
			this.NumReal = NumReal;
			NodoIzq = null;
			this.NodoDer = NodoDer;
			if (NodoDer != null) NodoDer.NodoIzq = this;
		}

		//Imprime Contenido
		public void Imprime() {
			Console.Write("Cadena: " + Cadena + " Caracter: " + Caracter.ToString());
			Console.WriteLine(" Entero: " + Entero.ToString() + " Real: " + NumReal.ToString());
		}
	}
}
