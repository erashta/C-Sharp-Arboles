
namespace ArbolGrafoLista {
	class Nodo {
		public char Letra { get; set; }
		public Nodo Izquierda;
		public Nodo Derecha;

		public Nodo(char Letra) {
			this.Letra = Letra;
			this.Izquierda = null;
			this.Derecha = null;
		}
	}
}
