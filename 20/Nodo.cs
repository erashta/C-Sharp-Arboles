using System;
using System.Collections.Generic;

namespace ArbolGrafoLista {
	class Nodo {
		//Atributos propios
		public string Cadena { get; set; }
		public char Caracter { get; set; }
		public int Entero { get; set; }
		public double NumReal { get; set; }

		public List<Nodo> Hijos; //Uso de una Lista para sostener los hijos del nodo

		public Nodo(string Cadena, char Caracter, int Entero, double NumReal) {
			this.Cadena = Cadena;
			this.Caracter = Caracter;
			this.Entero = Entero;
			this.NumReal = NumReal;
			Hijos = new List<Nodo>(); //Crea la lista vacía
		}

		public void AgregaHijo(Nodo hijo) {
			Hijos.Add(hijo); //Agrega hijo a la lista
		}

		//Imprime Contenido
		public void Imprime() {
			Console.Write("Cadena: " + Cadena + " Caracter: " + Caracter.ToString());
			Console.Write(" Entero: " + Entero.ToString() + " Real: " + NumReal.ToString());
			Console.WriteLine(" Número de hijos: " + Hijos.Count + "\r\n");
		}
	}
}
