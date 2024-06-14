Lista lista = new();

lista.inserirInicio(10);
lista.inserirInicio(7);
lista.inserirInicio(12);
lista.inserirInicio(-5);


No noAnterior,noAtual;

noAtual = null;
noAnterior = null;

int valor = 7;


Boolean verif  = lista.consulta(valor, ref noAtual, ref noAnterior);

if(verif == true) Console.WriteLine("A busca encontrou");

else Console.WriteLine("A busca não achou");


lista.imprimir();