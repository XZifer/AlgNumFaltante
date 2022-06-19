Console.WriteLine("¿Cual es el numero faltante en la matriz?");

Algoritmo AlgNumFaltante = new Algoritmo();
int[] A = {2,3,1,5};
int Faltante;
Faltante = AlgNumFaltante.EncuentraFaltante(A);
Console.WriteLine(A);
Console.WriteLine("Falta {0} en la matriz",Faltante);
