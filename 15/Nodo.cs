//Nodo de un árbol binario
namespace ArbolGrafoLista {
	class Nodo {
		public int Numero { get; set; }
		public Nodo Izquierda; //Apuntador
		public Nodo Derecha; //Apuntador

		//Constructor
		public Nodo(int Numero) {
			this.Numero = Numero;
		}
	}
}
