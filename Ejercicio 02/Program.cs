using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hotel;
            int dias;
            int adicional;
            int pago;
            int pagototal;
            int pagodias;

            Console.WriteLine("¿Qué categoría elegira?");
            hotel = (Console.ReadLine());
            Console.WriteLine("¿Cuánto tiempo estará en el hotel?");
            dias = int.Parse(Console.ReadLine());

            switch (hotel)  
            {
                case "Tres estrellas":
                    if (dias >= 11)
                    {
                        adicional = 7;
                        pago = 70;
                        pagodias = pago * dias;
                        pagototal = pago + (adicional * dias);
                    }
                    if (dias > 5 && dias < 11)
                    {
                        adicional = 7;
                        pago = 85;
                        pagodias = pago * dias;
                        pagototal = pago + (adicional * dias);
                    }
                    else
                    {
                        adicional = 7;
                        pago = 100;
                        pagodias = pago * dias;
                        pagototal = pagodias + (adicional * dias);
                    }
                    Console.WriteLine("Su pago total a pagar es S/." + pagototal);
                    break;

                case "Cinco estrellas":
                    if (dias >= 11)
                    {
                        adicional = 7;
                        pago = 250;
                        pagodias = pago * dias;
                        pagototal = pagodias + (adicional * dias);
                    }
                    if (dias > 5 && dias < 11)
                    {
                        adicional = 7;
                        pago = 270;
                        pagodias = pago * dias;
                        pagototal = pagodias + (adicional * dias);
                    }
                    else
                    {
                        adicional = 7;
                        pago = 300;
                        pagodias = pago * dias;
                        pagototal = pagodias + (adicional * dias);
                    }
                    Console.WriteLine("Su pago total a pagar es S/." + pagototal);
                    break;
                    
            }
            Console.ReadLine();
        }
    }
}
