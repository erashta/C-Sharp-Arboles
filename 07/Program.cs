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

			//Añade un nodo en una determinada posición
			Nodo particular = new Nodo("zzzz", 'Z', 7, 0.7, null);
			lista = AdicionaNodo(particular, lista, 3);
			ImprimeLista(lista);

			Console.ReadKey();
		}

		//Adiciona un nodo en determinada posición
		static public Nodo AdicionaNodo(Nodo nodo, Nodo lista, int posicion) {
			//Si es al inicio de la lista
			if (posicion == 0) {
				nodo.Apuntador = lista;
				return nodo;
			}

			//Si es en una ubicación intermedia
			int ubicacion = 0;
			Nodo pasear = lista;
			while (pasear != null) {
				if (ubicacion + 1 == posicion) {
					nodo.Apuntador = pasear.Apuntador;
					pasear.Apuntador = nodo;
					return lista;
				}
				pasear = pasear.Apuntador;
				ubicacion++;
			}

			//Si es al final de la lista
			pasear = lista;
			while (pasear.Apuntador != null) pasear = pasear.Apuntador;
			pasear.Apuntador = nodo;
			return lista;
		}

		//Imprime la lista
		static public void ImprimeLista(Nodo pasear) {
			while (pasear != null) {
				pasear.Imprime();
				pasear = pasear.Apuntador;
			}
		}
	}
}