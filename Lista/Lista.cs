public class Lista
{

    //Atributos
    public No inicio; //cabeça
    public No fim; //cauda

    //Construtor
    public Lista()
    {
        this.inicio = null;
        this.fim = null;
    }

    //Métodos
    public void inserirInicio(int valor)
    {

        //CRIAR NOVO NO
        No novoNo = new(valor);

        if (this.estaVazia())
        { //LISTA VAZIA!
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            novoNo.prox = this.inicio; //Novo no aponta para o inicio da lista
            this.inicio = novoNo; //O inicio da lista passa a ser o novo no
        }
    }


    public Boolean estaVazia()
    {
        if (inicio == null && fim == null)
        {
            return (true);
        }
        return (false);
    }
    public void inserirFinal(int valor)
    {
        //IMPLEMENTAR A INSERÇÃO DE UM ELEMENTO NO INICIO
        No novoNo = new(valor);

        if (this.estaVazia())
        {
            this.inicio = novoNo;
            this.fim = novoNo;

        }
        else
        {
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }
    }

    public Boolean remover(int valor)
    {
        //IMPLEMENTAR A REMOÇÃO DE UM VALOR INDICADO PELO USUÁRIO

        No noAnterior, noAtual;
        noAnterior = noAtual = null;

        Boolean verif = this.consulta(valor, ref noAtual, ref noAnterior);


        if (verif == true)
        {//Remover inicio;
          else if ()
            {//Remover meio

            }
            else
            {//Remover Fim

            }
            return (true);//Retorna True se removeiu
        }
        return (false);//Retorna False se não removeu

    }

    public Boolean consulta(int valor, ref No noAtual, ref No noAnterior)
    {
        noAtual = this.inicio;
        noAnterior = null;

        while (noAtual != null)
        {//percorrer lista
            if (noAtual.valor == valor)
            {
                return (true);
            }
            noAnterior = noAtual;//Copia do Atual
            noAtual = noAtual.prox;//Passou pelo numero
        }

        return (false);

    }

    public void imprimir()
    {
        int cont = 0;
        No noAux = this.inicio;//copia do inicio

        Console.WriteLine("Elementos: ");

        while (noAux != null)
        {
            Console.Write(noAux.valor + " -> ");
            noAux = noAux.prox;
        }

    }
}