using System;
using System.Collections.Generic;

class GrafoNoDirigido
{
    private Dictionary<int, List<int>> listaAdyacencia;

    public GrafoNoDirigido()
    {
        listaAdyacencia = new Dictionary<int, List<int>>();
    }

    public void AgregarVertice(int vertice)
    {
        if (!listaAdyacencia.ContainsKey(vertice))
        {
            listaAdyacencia[vertice] = new List<int>();
        }
    }

    public void AgregarArista(int vertice1, int vertice2)
    {
        if (!listaAdyacencia.ContainsKey(vertice1) || !listaAdyacencia.ContainsKey(vertice2))
        {
            Console.WriteLine("Los vértices deben existir en el grafo.");
            return;
        }

        if (!listaAdyacencia[vertice1].Contains(vertice2))
        {
            listaAdyacencia[vertice1].Add(vertice2);
        }

        if (!listaAdyacencia[vertice2].Contains(vertice1))
        {
            listaAdyacencia[vertice2].Add(vertice1);
        }
    }

    public void ImprimirGrafo()
    {
        foreach (var par in listaAdyacencia)
        {
            Console.Write($"{par.Key}: ");
            foreach (var vecino in par.Value)
            {
                Console.Write($"{vecino} ");
            }
            Console.WriteLine();
        }
    }
}

class GrafoDirigido
{
    private Dictionary<int, List<int>> listaAdyacencia;

    public GrafoDirigido()
    {
        listaAdyacencia = new Dictionary<int, List<int>>();
    }

    public void AgregarVertice(int vertice)
    {
        if (!listaAdyacencia.ContainsKey(vertice))
        {
            listaAdyacencia[vertice] = new List<int>();
        }
    }

    public void AgregarArista(int verticeOrigen, int verticeDestino)
    {
        if (!listaAdyacencia.ContainsKey(verticeOrigen) || !listaAdyacencia.ContainsKey(verticeDestino))
        {
            Console.WriteLine("Los vértices deben existir en el grafo.");
            return;
        }

        if (!listaAdyacencia[verticeOrigen].Contains(verticeDestino))
        {
            listaAdyacencia[verticeOrigen].Add(verticeDestino);
        }
    }

    public void ImprimirGrafo()
    {
        foreach (var par in listaAdyacencia)
        {
            Console.Write($"{par.Key}: ");
            foreach (var vecino in par.Value)
            {
                Console.Write($"{vecino} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        // Grafo No Dirigido
        GrafoNoDirigido grafoNoDirigido = new GrafoNoDirigido();
        grafoNoDirigido.AgregarVertice(1);
        grafoNoDirigido.AgregarVertice(2);
        grafoNoDirigido.AgregarVertice(3);
        grafoNoDirigido.AgregarArista(1, 2);
        grafoNoDirigido.AgregarArista(2, 3);
        grafoNoDirigido.ImprimirGrafo();

        Console.WriteLine("\n------------------------------------\n");

        // Grafo Dirigido
        GrafoDirigido grafoDirigido = new GrafoDirigido();
        grafoDirigido.AgregarVertice(1);
        grafoDirigido.AgregarVertice(2);
        grafoDirigido.AgregarVertice(3);
        grafoDirigido.AgregarArista(1, 2);
        grafoDirigido.AgregarArista(2, 3);
        grafoDirigido.ImprimirGrafo();
    }
}