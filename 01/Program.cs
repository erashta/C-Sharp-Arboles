using System;

namespace ArbolGrafoLista {
	class Program {
		static void Main() {
			//Crea dos nodos separados
			Nodo primero = new Nodo("Rafael", 'A', 16, 8.32);
			Nodo segundo = new Nodo("Moreno", 'P', 9, 2.9);
			Nodo tercero = new Nodo("Sally", 'C', 2010, 7.18);

			//Une el primer nodo con el segundo, creando una simple lista
			primero.Apuntador = segundo;

			//Une el segundo nodo con el tercero, aumentando la lista
			segundo.Apuntador = tercero;

			//Imprime la lista
			primero.Imprime();
			primero.Apuntador.Imprime();
			primero.Apuntador.Apuntador.Imprime();
			Console.ReadKey();
		}
	}
}
