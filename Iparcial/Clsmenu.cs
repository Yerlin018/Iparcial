using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Iparcial
{
    internal class Clsmenu
    {
        int opcion = 0;

        Clsreciclaje articulos = new Clsreciclaje(0, "", 0); // aqui hago la copia para poder llamar las metodos, ya que no son estaticos
        public Clsmenu()
        {
        }
        public void menuprincipal()
        {
            do
            {
                // Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1-Ingresar datos sobre el material reciclado");
                Console.WriteLine("2-Información sobre los datos recliclaje");
                Console.WriteLine("3- Bonificación por departamentos y estadistica de la empresa");
                Console.WriteLine("4-salir");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese una opcion");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: articulos.SolicitarReciclaje();
                        articulos.guardardatos();
                        break;
                    case 2: articulos.Reporte();
                        break;
                    case 3: articulos.Bonificacion(); 
                            articulos.estadistica();
                        break;
                    case 4: break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
             } while (!opcion.Equals(4)) ;
        }
    }
}
