//Unidad básica en el grafo cuadrado. Apuntará Arriba, Abajo, Derecha e Izquierda
namespace ArbolGrafoLista {
	class Nodo {
		public string Cadena { get; set; }

		//Apuntadores en las 4 direcciones
		public Nodo Arriba;
		public Nodo Abajo;
		public Nodo Derecha;
		public Nodo Izquierda;

		//Constructor
		public Nodo(string Cadena) {
			this.Cadena = Cadena;
		}
	}
}