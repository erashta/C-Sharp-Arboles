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

			//Borra un nodo en una determinada posición
			lista = BorraNodo(lista, 3);
			ImprimeLista(lista);

			Console.ReadKey();
		}

		//Borra nodo de una determinada posición
		static public Nodo BorraNodo(Nodo lista, int posicion) {
			//Si es al inicio de la lista
			if (posicion == 0) {
				lista = lista.Apuntador;
				return lista;
			}

			//Si es en una ubicación intermedia
			int ubicacion = 0;
			Nodo pasear = lista;
			while (pasear != null) {
				if (ubicacion + 1 == posicion) {
					pasear.Apuntador = pasear.Apuntador.Apuntador;
					return lista;
				}
				pasear = pasear.Apuntador;
				ubicacion++;
			}

			//Si es al final de la lista
			pasear = lista;
			while (pasear.Apuntador.Apuntador != null) pasear = pasear.Apuntador;
			pasear.Apuntador = null;
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