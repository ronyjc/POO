using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Moto
    {
        //Atributos
        string marca;
        string modelo;
        int cilindrada;
        double potencia;

        public Moto(string marca, string modelo, int cilindrada, double potencia) { 
            
            this.marca = marca;
            this.modelo = modelo; 
            this.cilindrada = cilindrada;
            this.potencia = potencia;
            
        
        }


        public string Marca { get => marca; set => marca = value;}
        public string Modelo { get => modelo; set => modelo = value;}
        public int Cilindrada { get => cilindrada; set => cilindrada = value;}
        public double Potencia { get => potencia; set => potencia = value;}
        
    }
}
