public class No{

    //Atributos - Características
    public int valor;
    public No prox;

    //Construtor
    public No(int Valor){
        this.valor = Valor;
        this.prox = null;
    }

    //Métodos
    public void imprimir(){
        Console.WriteLine("Valor: " + this.valor);
    }
}