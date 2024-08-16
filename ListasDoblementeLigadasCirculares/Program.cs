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

            Console.WriteLine("lista normal");
            lista.RecorrerListaPU();
            Console.WriteLine("lista inversa");
            lista.RecorrerListaUP();
            lista.BuscarNodo();
            lista.ModificarNodo();
            Console.WriteLine("lista normal");
            lista.RecorrerListaPU();
            Console.WriteLine("lista inversa");
            lista.RecorrerListaUP();
            lista.EliminarNodo();
            Console.WriteLine("lista normal");
            lista.RecorrerListaPU();
            Console.WriteLine("lista inversa");
            lista.RecorrerListaUP();


        }
    }
}