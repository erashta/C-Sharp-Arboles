//Unidad básica en el grafo cuadrado. Apuntará Arriba, Abajo, Derecha e Izquierda
namespace ArbolGrafoLista {
	class Nodo {
		public int Numero { get; set; }

		//Apuntadores en las 4 direcciones
		public Nodo Arriba;
		public Nodo Abajo;
		public Nodo Derecha;
		public Nodo Izquierda;

		//Constructor
		public Nodo(int Numero) {
			this.Numero = Numero;
		}
	}
}