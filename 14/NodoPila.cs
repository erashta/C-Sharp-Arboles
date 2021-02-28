//Nodo de una pila para recorrer iterativamente un árbol binario
namespace ArbolGrafoLista {
	class NodoPila {
		public NodoPila Flecha;
		public Nodo Raiz;
		public NodoPila(Nodo Raiz, NodoPila Flecha) {
			this.Raiz = Raiz;
			this.Flecha = Flecha;
		}
	}
}
