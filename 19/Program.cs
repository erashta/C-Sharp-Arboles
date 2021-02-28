//Recorrido por niveles de un árbol binario
using System;
using System.Collections.Generic;

namespace ArbolGrafoLista {
	class Program {
		static void Main(string[] args) {
			List<NodosNivel> niveles = new List<NodosNivel>();

			//Crea el árbol
			Nodo Arbol = new Nodo('P');
			Arbol.Izquierda = new Nodo('F');
			Arbol.Derecha = new Nodo('S');
			Arbol.Izquierda.Izquierda = new Nodo('B');
			Arbol.Izquierda.Derecha = new Nodo('H');
			Arbol.Izquierda.Derecha.Izquierda = new Nodo('G');
			Arbol.Derecha.Izquierda = new Nodo('R');
			Arbol.Derecha.Derecha = new Nodo('Y');
			Arbol.Derecha.Derecha.Izquierda = new Nodo('T');
			Arbol.Derecha.Derecha.Derecha = new Nodo('Z');
			Arbol.Derecha.Derecha.Izquierda.Derecha = new Nodo('W');

			//Recorrido por niveles
			Console.WriteLine("Recorrido por niveles");

			//Arma la lista con la información de Nodo y Altura
			ArmaLista(niveles, Arbol, 0);
			
			//Una vez armada la lista entonces la explora usando como llave la altura
			bool ExisteNivel;
			int Altura = 0;
			do {
				ExisteNivel = false;

				//Muestra los nodos de esa altura en particular
				for(int cont=0; cont<niveles.Count; cont++)
					if (niveles[cont].Altura == Altura) {
						Console.Write(niveles[cont].nodo.Letra + " -- ");
						ExisteNivel = true;
					}
				
				//Salta al siguiente nivel
				Console.WriteLine(" ");
				Altura++;
			} while (ExisteNivel);

			Console.ReadKey();
		}

		//Arma la lista con la información del nodo y su altura
		public static void ArmaLista(List<NodosNivel> niveles, Nodo arbol, int altura) {
			niveles.Add(new NodosNivel(altura, arbol));
			if (arbol.Izquierda != null) ArmaLista(niveles, arbol.Izquierda, altura + 1);
			if (arbol.Derecha != null) ArmaLista(niveles, arbol.Derecha, altura + 1);
		}
	}
}
