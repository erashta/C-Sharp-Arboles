namespace ArbolGrafoLista {
	class NodosNivel {
		public int Altura { get; set; }
		public Nodo nodo;

		public NodosNivel(int Altura, Nodo nodo) {
			this.Altura = Altura;
			this.nodo = nodo;
		}
	}
}
