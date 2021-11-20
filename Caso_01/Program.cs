using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();

            // Creando los seis (06) pacientes predeterminados
            Paciente p1 = new Paciente(5, "Camilo", "Mendoza");
            Paciente p2 = new Paciente(2, "Mike", "Llosa");
            Paciente p3 = new Paciente(10, "Alexandra", "López");
            Paciente p4 = new Paciente(100, "Laura", "Martinez");
            Paciente p5 = new Paciente(1, "Matías", "Benavides");
            Paciente p6 = new Paciente(3, "Erica", "Cisneros");

            // Insertando los seis (06) pacientes iniciales
            arbol.InsertarNodo(p1);
            arbol.InsertarNodo(p2);
            arbol.InsertarNodo(p3);
            arbol.InsertarNodo(p4);
            arbol.InsertarNodo(p5);
            arbol.InsertarNodo(p6);

            Console.WriteLine("================================================");
            Console.WriteLine("|| Maku Consulting: Sistema de Fichas Médicas ||");
            Console.WriteLine("================================================\n");

            // Imprimiendo en pantalla los ordenamientos iniciales
            Console.WriteLine("::::::::: ORDENAMIENTO PREORDER :::::::::");
            arbol.PreOrder(arbol.GetRaiz());
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::\n");

            Console.WriteLine("::::::::: ORDENAMIENTO INORDER :::::::::");
            arbol.InOrder(arbol.GetRaiz());
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::\n");

            Console.WriteLine("::::::::: ORDENAMIENTO POSTORDER :::::::::");
            arbol.PostOrder(arbol.GetRaiz());
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::\n");

            // Eliminando pacientes con ID: 100 e ID: 1
            Console.WriteLine("ELIMINANDO ELEMENTOS ID: " + p4.id + " , ID: " + p5.id + "\n");
            arbol.Eliminar(arbol.GetRaiz(), p4.id); // p4.id = 100
            arbol.Eliminar(arbol.GetRaiz(), p5.id); // p5.id = 1

            // Imprimiendo en pantalla los ordenamientos finales
            Console.WriteLine("::::::::: ORDENAMIENTO PREORDER :::::::::");
            arbol.PreOrder(arbol.GetRaiz());
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::\n");

            Console.WriteLine("::::::::: ORDENAMIENTO INORDER :::::::::");
            arbol.InOrder(arbol.GetRaiz());
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::\n");

            Console.WriteLine("::::::::: ORDENAMIENTO POSTORDER :::::::::");
            arbol.PostOrder(arbol.GetRaiz());
            Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::\n");

            Console.ReadKey();
        }
    }
}
