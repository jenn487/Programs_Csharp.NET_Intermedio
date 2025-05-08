using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_ISP.Interfaces;

namespace Practica_ISP.Clases
{
    internal class Pinguino : IAveTerrestre, IAve, IAveAcuatica
    {
        public void Cantar() => Console.WriteLine("Puedo Cantar.");
        public void PonerHuevo() => Console.WriteLine("Puedo Poner Huevos.");
        public void Cazar() => Console.WriteLine("Puedo Cazar.");
        public void Caminar() => Console.WriteLine("Puedo Caminar."); 
        public void Trepar() => Console.WriteLine("Puedo Trepar.");
        public void Nadar() => Console.WriteLine("Puedo Nadar.");
        public void Flotar() => Console.WriteLine("Puedo Flotar.");

    }
}
