namespace ListasDoblementeLigadasCriculares
{
    internal class Lista
    {        
        Nodo nodoInicial = new Nodo();
        Nodo nodoFinal = new Nodo();
        //CONSTRUCTOR INICIALMENTE AMBOS NODOS VALEN "NULL"
        public Lista()
        { 
            nodoInicial = null;
            nodoFinal = null;
        }
        //METODO PARA INSERTAR NODO
        public void InsertarNodo()
        {
            Nodo nuevoNodo = new Nodo();
            Console.Write("ingrese el dato del nuevo Nodo: ");
            nuevoNodo.dato = int.Parse(Console.ReadLine());
            if (nodoInicial == null)
            {
                nodoInicial = nuevoNodo;
                nodoFinal = nuevoNodo;
                nodoInicial.siguiente = nodoInicial;
                nodoInicial.anterior = nodoFinal;

            }
            else
            {
                nodoFinal.siguiente = nuevoNodo;
                nuevoNodo.anterior = nodoFinal;
                nuevoNodo.siguiente = nodoInicial;
                nodoFinal = nuevoNodo;
                nodoInicial.anterior = nodoFinal;
            }
            Console.WriteLine( "***** NUEVO NODO AGREGADO CON EXITO *****");

        }

        //METODO PARA BUSCAR NODO
        public void BuscarNodo()
        {
            Nodo actual = new Nodo();
            actual = nodoInicial;
            bool encontrado = false;
            Console.WriteLine("ingrese el dato del nodo a buscar: ");
            int nodobuscado = int.Parse(Console.ReadLine());
            if (actual != null)
            {
                do
                {
                    if (actual.dato == nodobuscado)
                    {
                        Console.WriteLine("Nodo con el dato " + actual.dato + " Encontrado");
                        encontrado = true;
                    }
                    actual = actual.siguiente;
                } while (actual != nodoInicial && encontrado != true);

                if (!encontrado)
                {
                    Console.WriteLine("nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }
        //METODO PARA MODIFICAR NODO
        public void ModificarNodo()
        {
            Nodo actual = new Nodo();
            actual = nodoInicial;
            bool encontrado = false;
            
            int nodobuscado = int.Parse(Console.ReadLine());
            if (actual != null)
            {
                do
                {
                    if (actual.dato == nodobuscado)
                    {
                        Console.WriteLine("***** NODO CON EL DATO " + actual.dato + " ENCONTRADO *****");
                        Console.WriteLine("Ingrese el nuevo dato para este nodo: ");
                        actual.dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("***** NUEVO NODO MODIFICADO CON EXITO *****");
                        encontrado = true;
                    }
                    actual = actual.siguiente;
                } while (actual != nodoInicial && encontrado != true);

                if (!encontrado)
                {
                    Console.WriteLine("nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }
        //METODO PARA ELIMINAR NODO
        public void EliminarNodo()
        {
            Nodo actual = new Nodo();
            actual = nodoInicial;
            Nodo anterior = new Nodo();
            anterior = null;
            bool encontrado = false;
            Console.WriteLine("ingrese el dato del nodo a eliminar: ");
            int nodobuscado = int.Parse(Console.ReadLine());
            if (actual != null)
            {
                do
                {
                    if (actual.dato == nodobuscado)
                    {

                        if (actual == nodoInicial)
                        {
                            nodoInicial = nodoInicial.siguiente;
                            nodoInicial.anterior = nodoFinal;
                            nodoFinal.siguiente = nodoInicial;
                        }
                        else if (actual == nodoFinal)
                        {
                            nodoFinal = anterior;
                            nodoFinal.siguiente = nodoFinal.siguiente;
                            nodoInicial.anterior = nodoFinal;
                        }
                        else
                        {
                            anterior.siguiente = actual.siguiente;
                            actual.siguiente.anterior = anterior;
                        }
                        Console.WriteLine("nodo eliminado con exito");
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.siguiente;
                } while (actual != nodoInicial && encontrado != true);

                if (!encontrado)
                {
                    Console.WriteLine("nodo no encontrado");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }
        //METODO PARA RECOORER LISTA DEL PRIMERO AL ULTIMO
        public void RecorrerListaPU()
        {
            Nodo actual = new Nodo();
            actual = nodoInicial;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.siguiente;
                } while (actual != nodoInicial);
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }
        //METODO PARA RECORRER LISTA DEL ULTIMO AL PRIMERO
        public void RecorrerListaUP()
        {
            Nodo actual = new Nodo();
            actual = nodoFinal;

            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.dato);
                    actual = actual.anterior;
                } while (actual != nodoFinal);

            }
            else
            {
                Console.WriteLine("la lista esta vacia");
            }
        }


    }

}