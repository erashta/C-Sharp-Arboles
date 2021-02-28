//Grafo básico
using System;

namespace ArbolGrafoLista {
	class Program {
		public static void Main() {
			//Genera los nodos
			Nodo nodoA = new Nodo("aaaa");
			Nodo nodoB = new Nodo("bbbb");
			Nodo nodoC = new Nodo("cccc");
			Nodo nodoD = new Nodo("dddd");

			//Une los nodos para crear el grafo
			nodoA.Abajo = nodoB;
			nodoB.Arriba = nodoA;

			nodoB.Derecha = nodoC;
			nodoC.Izquierda = nodoB;

			nodoC.Arriba = nodoD;
			nodoD.Abajo = nodoC;

			//Imprime
			Console.WriteLine("nodoA: " + nodoA.Cadena);
			Console.WriteLine("nodoA->Abajo: " + nodoA.Abajo.Cadena);
			Console.WriteLine("nodoA->Abajo->Derecha: " + nodoA.Abajo.Derecha.Cadena);
			Console.WriteLine("nodoA->Abajo->Derecha->Arriba: " + nodoA.Abajo.Derecha.Arriba.Cadena);
			Console.ReadKey();
		}
	}
}