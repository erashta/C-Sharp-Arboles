namespace ArbolGrafoLista {
	class Nodo {
		public int Numero { get; set; }
		public Nodo Izquierda;
		public Nodo Derecha;

		public Nodo(int Numero) {
			this.Numero = Numero;
			this.Izquierda = null;
			this.Derecha = null;
		}
	}
}
