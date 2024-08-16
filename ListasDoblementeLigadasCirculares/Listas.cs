namespace ListasDoblementeLigadasCriculares
{
    internal class Lista
    {
        Nodo nodoInicial = new Nodo();
        Nodo nodoFinal = new Nodo();

        public Lista()
        {
            nodoInicial = null;
            nodoFinal = null;
        }

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
            Console.WriteLine("Nuevo nodo agregdo con exito");

        }


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
                        Console.WriteLine("nodo con el dato " + actual.dato + " Encontrado");
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
        public void ModificarNodo()
        {
            Nodo actual = new Nodo();
            actual = nodoInicial;
            bool encontrado = false;
            Console.WriteLine("ingrese del nodo a modificar: ");
            int nodobuscado = int.Parse(Console.ReadLine());
            if (actual != null)
            {
                do
                {
                    if (actual.dato == nodobuscado)
                    {
                        Console.WriteLine("nodo con el dato " + actual.dato + " Encontrado");
                        Console.WriteLine("Ingrese el nuevo dato para este nodo: ");
                        actual.dato = int.Parse(Console.ReadLine());
                        Console.WriteLine("nodo modificado con exito");
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

        public void EliminarNodo()
        {
            Nodo actual = new Nodo();
            actual = nodoInicial;
            Nodo anterior = new Nodo();
            anterior = null;
            bool encontrado = false;
            Console.WriteLine("ingrese del nodo a eliminar: ");
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