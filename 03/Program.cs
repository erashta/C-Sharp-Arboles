using System;

namespace ArbolGrafoLista {
	class Program {
		static void Main() {
			//Crea la lista
			Nodo lista = new Nodo("aaaa", 'A', 1, 0.1, null);
			lista = new Nodo("bbbb", 'B', 2, 0.2, lista);
			lista = new Nodo("cccc", 'C', 3, 0.3, lista);
			lista = new Nodo("dddd", 'D', 4, 0.4, lista);
			lista = new Nodo("eeee", 'E', 5, 0.5, lista);
			lista = new Nodo("ffff", 'F', 6, 0.6, lista);
			lista = new Nodo("gggg", 'G', 7, 0.7, lista);
			lista = new Nodo("hhhh", 'H', 8, 0.8, lista);
			lista = new Nodo("iiii", 'I', 9, 0.9, lista);

			//Pasea la lista, imprimiéndola
			Nodo pasea = lista;
			while(pasea != null) {
				pasea.Imprime();
				pasea = pasea.Apuntador;
			}

			Console.ReadKey();
		}
	}
}
