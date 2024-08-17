namespace ListasDoblementeLigadasCriculares
{
    class Program
    {


        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.InsertarNodo();
            lista.InsertarNodo();
            lista.InsertarNodo();
            lista.InsertarNodo();
            lista.InsertarNodo();

            Console.WriteLine("LISTA NORMAL");
            lista.RecorrerListaPU();
            Console.WriteLine("INGRESA EL DATO DEL NODO QUE QUIERAS MODIFICAR:");
            lista.ModificarNodo();
            Console.WriteLine("LISTA NORMAL");
            lista.RecorrerListaPU();
            Console.WriteLine("INGRESA EL DATO DEL NODO QUE QUIERAS MODIFICAR:");
            lista.ModificarNodo();
            Console.WriteLine("LISTA NORMAL");
            lista.RecorrerListaPU();
            Console.WriteLine("INGRESA EL DATO DEL NODO QUE QUIERAS MODIFICAR:");
            lista.ModificarNodo();
            Console.WriteLine("LISTA NORMAL");
            lista.RecorrerListaPU();
            Console.WriteLine("INGRESA EL DATO DEL NODO QUE QUIERAS MODIFICAR:");
            lista.ModificarNodo();
            Console.WriteLine("LISTA NORMAL");
            lista.RecorrerListaPU();




        }
    }
}