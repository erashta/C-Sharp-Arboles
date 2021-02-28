using System;

namespace ArbolGrafoLista {
	class Program {
		static void Main() {
			//Crea la lista
			Nodo lista = new Nodo("aaaa", 'A', 1, 0.1, null);
			lista = new Nodo("bbbb", 'B', 2, 0.2, lista);
			lista = new Nodo("cccc", 'C', 3, 0.3, lista);

			//Imprime la lista
			lista.Imprime(); //Primer nodo
			lista.Apuntador.Imprime(); //Segundo nodo
			lista.Apuntador.Apuntador.Imprime(); //Tercer nodo
			Console.ReadKey();
		}
	}
}
