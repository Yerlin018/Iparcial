using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Iparcial
{
    internal class Clsreciclaje
    {

        //atributos
        private int codigo;
        private string tipo;
        private float cantidad;
        private float sumTIVer=0;
        private float sumTIAma = 0;
        private float sumTIAzul = 0;
        private float sumMMVer = 0;
        private float sumMMama = 0;
        private float sumMMazul = 0;
        private float sumADver = 0;
        private float sumADama = 0;
        private float sumADazul = 0;
        private float bonifTIver = 0;
        private float bonifTIama = 0;
        private float bonifTIazul = 0;
        private float bonifMMver= 0;
        private float bonifMMama = 0;
        private float bonifMMazul = 0;
        private float bonifADver = 0;
        private float bonifADama = 0;
        private float bonifADazul = 0;
        private float sumver = 0;
        private float sumama = 0;
        private float sumazul = 0;
        private float promedio= 0;

        List<Clsreciclaje> productos = new List<Clsreciclaje>(); ///genero una lista que se llama: productos

        // constructor 

        public Clsreciclaje(int Codigo, string Tipo, float Cantidad)
        {
            codigo = Codigo;
            tipo = Tipo;
            cantidad = Cantidad;
        }
        public Clsreciclaje() // Este es un costructor vacio
        {

        }

        // metodos


        public void SolicitarReciclaje()
        {
            Console.WriteLine("Estimado funcionario(a) su código es:");
            Console.WriteLine("1. Si pertenece al departamente de TI. ");
            Console.WriteLine("2. Si pertenece al departamente de Modelado matemático. ");
            Console.WriteLine("3. Si pertenece al departamente de Adeministración. ");
            Console.WriteLine("Digite su código: ");
            int.TryParse(Console.ReadLine(), out codigo);
            Console.WriteLine("La descripción del material reciclado es: ");
            Console.WriteLine("Verde, para envases de vidrio. ");
            Console.WriteLine("Amarillo, para envases metálicos: ");
            Console.WriteLine("Azul, para papel o cartón: ");
            Console.WriteLine("Digite la descripción: Verde, Amarillo o Azul: ");
            tipo = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de envases o los kilos de papel reciclados: ");
            float.TryParse(Console.ReadLine(), out cantidad);
        }
        public void guardardatos()
        {

            Console.Clear();
            Clsreciclaje nuevodeposito = new Clsreciclaje(codigo, tipo, cantidad);  // instancia copia de la clase reciclaje
            productos.Add(nuevodeposito);
            Console.WriteLine("La informacion del reciclaje ha sido ingresada exitosamente");
            Console.WriteLine("Puede ingresar su recliclaje a los recipientes");
            Console.WriteLine("Agradecemos su esfuerzo");
            Console.Read();
        }

        public void Reporte()
        {
            Console.Clear();
            Console.WriteLine("*********** Reporte de Reciclaje ***********");
           Console.WriteLine("_______________________________________________");
            foreach (var recic in productos)
            {
                if (recic.codigo == 1)
                {

                    Console.WriteLine($"Departamento: TI  Descripcion: {recic.tipo} Cantidad: {recic.cantidad}");
                }
                else 
                {
                    if (recic.codigo == 2)
                    {

                        Console.WriteLine($"Departamento: Modelado Matematico  Descripcion: {recic.tipo} Precio: {recic.cantidad}");
                    }
                    else
                    {
                        if (recic.codigo == 3)
                        {

                            Console.WriteLine($"Departamento: Administracion  Descripcion: {recic.tipo} Precio: {recic.cantidad}");
                        }
                    }
                    
                }


            }
            Console.WriteLine("___________________________ FIN DEL REPORTE  ___________________________");
            Console.Read();
        }

        public void Bonificacion()
        {
            Console.Clear();
            Console.WriteLine("*********** Bonificacion de Reciclaje ***********");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("                                                 ");
            foreach (var recic in productos)
            {
                if (recic.codigo == 1 )
                {
                    if (recic.tipo == "Verde")
                    {
                        sumTIVer = sumTIVer + recic.cantidad;
                    }
                    if (recic.tipo == "Amarillo")
                    {
                        sumTIAma = sumTIAma + recic.cantidad;
                    }
                    if (recic.tipo == "Azul")
                    {
                        sumTIAzul = sumTIAzul + recic.cantidad;
                    }

                }
                else
                {
                    if (recic.codigo == 2)
                    {
                        if (recic.tipo == "Verde")
                        {
                            sumMMVer = sumMMVer + recic.cantidad;
                        }
                        if (recic.tipo == "Amarillo")
                        {
                            sumMMama = sumMMama + recic.cantidad;
                        }
                        if (recic.tipo == "Azul")
                        {
                            sumMMazul = sumMMazul + recic.cantidad;
                        }
                    }
                    else
                    {
                        if (recic.codigo == 3)
                        {
                            if (recic.tipo == "Verde")
                            {
                                sumADver = sumADver + recic.cantidad;
                            }
                            if (recic.tipo == "Amarillo")
                            {
                                sumADama = sumADama + recic.cantidad;
                            }
                            if (recic.tipo == "Azul")
                            {
                                sumADazul = sumADazul + recic.cantidad;
                            }


                        }
                    }

                }


            }
            //Caluclar las Bonidicaciones
            //Calcular para TI
            bonifTIver = sumTIVer + sumTIVer * 0.5f;
            bonifTIama = sumTIAma + sumTIAma * 0.40f;
            bonifTIazul = sumTIAzul + sumTIAzul* 0.35f;

            Console.WriteLine("                                                                 ");
            Console.WriteLine("Bonificacion del departamento de Tecnologia Informarmacion:");
            Console.WriteLine("                                                                 ");
            Console.WriteLine($"Envaces de vidirio: {sumTIVer}, Bonificacion {bonifTIver}");
            Console.WriteLine($"envaces de plastico o metal: {sumTIAma}, Bonificacion {bonifTIama}");
            Console.WriteLine($"Kilos de Papel o carton: {sumTIAzul}, Bonificacion {bonifTIazul}");
            //Calcular para Modelado Matematixo
            bonifMMver = sumMMVer + sumMMVer * 0.5f;
            bonifMMama = sumMMama + sumMMama * 0.4f;
            bonifMMazul = sumMMazul + sumMMazul * 0.35f;
            Console.WriteLine("                                                                 ");
            Console.WriteLine("Bonificacion del departamento de Modelado Matematico:");
            Console.WriteLine("                                                                 ");
            Console.WriteLine($"Envaces de vidirio: {sumMMVer}, Bonificacion {bonifMMver}");
            Console.WriteLine($"envaces de plastico o metal: {sumMMama} , Bonificacion  {bonifMMama}");
            Console.WriteLine($"Kilos de Papel o carton: {sumMMazul}, Bonificacion {bonifMMazul}");

            //Calcular para AD
            bonifADver = sumADver + sumADver * 0.5f;
            bonifADama = sumADama + sumADama * 0.40f;
            bonifADazul = sumADazul + sumADazul * 0.35f;
            Console.WriteLine("                                                                 ");
            Console.WriteLine("Bonificacion del departamento de Administracion:");
            Console.WriteLine("                                                                 ");
            Console.WriteLine($"Envaces de vidirio: {sumADver}, Bonificacion {bonifADver}");
            Console.WriteLine($"envaces de plastico o metal: {sumADama} , Bonificacion  {bonifADama}");
            Console.WriteLine($"Kilos de Papel o carton: {sumADazul}, Bonificacion {bonifADazul}");
            Console.WriteLine("                                                                 ");
            Console.Read();
        }

        public void estadistica()
        {
            sumver = sumTIVer + sumADver + sumMMVer;
            sumama = sumTIAma+ sumADama+ sumMMama;
            sumazul = sumTIAzul+ sumADazul+ sumMMazul;
            promedio=(sumver+sumama+sumazul)/productos.Count;
              
            Console.WriteLine("___________________________ RECICLAJE DE LA EMPRESA___________________________");
            Console.WriteLine("                                                             ");
            Console.WriteLine($"Total de envaces de vidrio: {sumver}");
            Console.WriteLine($"Total de envaces plasticos o metal: {sumama}");
            Console.WriteLine($"Total de kilos de papel o carton: {sumazul}");
            Console.WriteLine($"El aporte promedio de reciclaje es de: {promedio} ");
            Console.Read();
            Console.WriteLine("___________________________ FIN DEL REPORTE  ___________________________");

        }
    }
}
