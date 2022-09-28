namespace ConceptosPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea()
        {

            Punto origen = new Punto();

            Punto destino = new Punto(120, 80);

            double distancia = origen.DistanciaHasta(destino);

        }
    }
}