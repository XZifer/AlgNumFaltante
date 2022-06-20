namespace NumeroFaltanteBiblioteca
{
    public class Algoritmo
    {
        public int EncuentraFaltante(int[] A)
        {
            //Declarar variables a utilizar y la matriz
            int siguiente;
            int Faltante = 0;
            //ordenamos la matriz
            Array.Sort(A);
            //recorre cada uno de los valores de B y ve que valor falta
            for (int i = 0; i < A.Length -1; i++)
            {
                siguiente = i + 1;
                if ((A[siguiente] - A[i]) > 1)
                {
                    Faltante = A[i] + 1;
                }
            }
            
            return Faltante;
        }
    }
}