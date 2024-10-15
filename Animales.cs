using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOEjemplo
{
    public class Animales
    {
        string especie;
        int edad;
        string clasificacion;

        public Animales(string esp, int ed, string cla) 
        {
            especie = esp;
            edad = ed;
            clasificacion = cla;
        
        }

        public string getEspecie() { 
            
            return especie;
        
        }

        public int getEdad() { 
        
            return edad;
        }

        public string getClasificacion() { 
        
            return clasificacion;
        }
    }
}
