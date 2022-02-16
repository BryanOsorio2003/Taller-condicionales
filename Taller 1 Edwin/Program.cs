using System;

namespace Taller_1_Edwin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el ejercicio: ");
            int ejercicio = Convert.ToInt32(Console.ReadLine());
            if(ejercicio == 1)
            {
                Console.WriteLine("Ingrese la cantidad requerida: ");
                int cantidadRequerida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de la bodega: ");
                int cantidadBodega = Convert.ToInt32(Console.ReadLine());
                
                int unidadesRestantes = cantidadBodega - cantidadRequerida;
                int unidadesPedir = cantidadRequerida - cantidadBodega;

                if (cantidadRequerida>cantidadBodega)
                {
                    Console.WriteLine("Es necesario realizar el pedido al proveedor, unidades a pedir: " + unidadesPedir);
                }
                if (cantidadBodega>cantidadRequerida)
                {
                    Console.WriteLine("No es necesario realizar el pedido al proveedor, unidades restantes : " + unidadesRestantes);
                }
            }
            else if (ejercicio == 2)
            {
                Console.WriteLine("Ingrese la cantidad requerida: ");
                int cantidadRequerida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de la bodega: ");
                int cantidadBodega = Convert.ToInt32(Console.ReadLine());

                int unidadesRestantes = cantidadBodega - cantidadRequerida;
                int unidadesPedir = cantidadRequerida - cantidadBodega;

                if (cantidadRequerida > cantidadBodega)
                {
                    Console.WriteLine("Es necesario realizar el pedido al proveedor, unidades a pedir: " + unidadesPedir);
                }
                else
                {
                    Console.WriteLine("No es necesario realizar el pedido al proveedor, unidades restantes : " + unidadesRestantes);
                }
            }
            else if(ejercicio== 3)
            {
                Console.WriteLine("Ingrese la cantidad requerida: ");
                int cantidadRequerida = Convert.ToInt32(Console.ReadLine());
                    
                Console.WriteLine("Ingrese la cantidad de la bodega: ");
                int cantidadBodega = Convert.ToInt32(Console.ReadLine());


                int unidadesRestantes = cantidadBodega - cantidadRequerida;
                int unidadesPedir = cantidadRequerida - cantidadBodega;
                if (cantidadRequerida > cantidadBodega)
                {
                    Console.WriteLine("Es necesario realizar el pedido al proveedor, unidades a pedir: " + unidadesPedir);
                }
                else if(unidadesRestantes<10)
                {
                    Console.WriteLine("No es necesario realizar el pedido. ¡Alerta! las unidades restantes son menores de 10.");
                }
                else
                {
                    Console.WriteLine("No es necesario realizar el pedido al proveedor, unidades restantes : " + unidadesRestantes);
                }
            }
            else if (ejercicio == 4)
            {
                Console.WriteLine("Ingrese la cantidad requerida: ");
                int cantidadRequerida = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de la bodega: ");
                int cantidadBodega = Convert.ToInt32(Console.ReadLine());


                int unidadesRestantes = cantidadBodega - cantidadRequerida;
                int unidadesPedir = cantidadRequerida - cantidadBodega;
                if (cantidadRequerida > cantidadBodega)
                {
                    Console.WriteLine("Es necesario realizar el pedido al proveedor, unidades a pedir: " + unidadesPedir);

                    Console.WriteLine("Ingrese el dinero que tiene en caja: ");
                    int dineroCaja = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese la cantidad que desea comprar: ");
                    int cantidadComprar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor de la compra: ");
                    int valorUnidad = Convert.ToInt32(Console.ReadLine());

                    int valorTotal = valorUnidad * cantidadComprar;

                    if (dineroCaja>valorTotal)
                    {
                        Console.WriteLine("Si se puede realizar el pedido.");
                    }
                    else
                    {
                        Console.WriteLine("No se puede realizar el pedido, no hay suficiente dinero en caja.");
                    }
                }
                else if (unidadesRestantes < 10)
                {
                    Console.WriteLine("No es necesario realizar el pedido. ¡Alerta! las unidades restantes son menores de 10.");
                }
                else
                {
                    Console.WriteLine("No es necesario realizar el pedido al proveedor, unidades restantes : " + unidadesRestantes);
                }
            }
            else if(ejercicio == 5)
            {
                Console.WriteLine("Ingrese el dia de la semana");
                int diaSemana = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el valor a pagar");
                int valorPagar = Convert.ToInt32(Console.ReadLine());
                if (diaSemana == 1)
                {
                    double descuento = 0.5;
                    double valorTotalPagar = valorPagar - (valorPagar * descuento);
                    Console.WriteLine("El valor a pagar sin descuento es: " + valorPagar);
                    Console.WriteLine("El valor a pagar con descuento es: " + valorTotalPagar);

                }
                else if(diaSemana == 2)
                {
                    double descuento = 0.3;
                    double valorTotalPagar = valorPagar - (valorPagar * descuento);
                    Console.WriteLine("El valor a pagar sin descuento es: " + valorPagar);
                    Console.WriteLine("El valor a pagar con descuento es: " + valorTotalPagar);

                }
                else if (diaSemana == 3)
                {
                    double descuento = 0.10;
                    double valorTotalPagar = valorPagar - (valorPagar * descuento);
                    Console.WriteLine("El valor a pagar sin descuento es: " + valorPagar);
                    Console.WriteLine("El valor a pagar con descuento es: " + valorTotalPagar);

                }
                else if (diaSemana == 4)
                {
                    double descuento = 0.4;
                    double valorTotalPagar = valorPagar - (valorPagar * descuento);
                    Console.WriteLine("El valor a pagar sin descuento es: " + valorPagar);
                    Console.WriteLine("El valor a pagar con descuento es: " + valorTotalPagar);

                }
                else if (diaSemana == 5)
                {
                    double descuento = 0.6;
                    double valorTotalPagar = valorPagar - (valorPagar * descuento);
                    Console.WriteLine("El valor a pagar sin descuento es: " + valorPagar);
                    Console.WriteLine("El valor a pagar con descuento es: " + valorTotalPagar);

                }
                else if (diaSemana == 6)
                {
                    double descuento = 0.2;
                    double valorTotalPagar = valorPagar - (valorPagar * descuento);
                    Console.WriteLine("El valor a pagar sin descuento es: " + valorPagar);
                    Console.WriteLine("El valor a pagar con descuento es: " + valorTotalPagar);

                }
                else if (diaSemana == 7)
                {
                    double descuento = 0.1;
                    double valorTotalPagar = valorPagar - (valorPagar * descuento);
                    Console.WriteLine("El valor a pagar sin descuento es: " + valorPagar);
                    Console.WriteLine("El valor a pagar con descuento es: " + valorTotalPagar);

                }
                else
                {
                    Console.WriteLine("Introdujo un numero erroneo");
                }
            }
            else if(ejercicio == 6)
            {
                Console.WriteLine("Ingrese la cantidad de tipos de productos: ");
                int cantidadProductos = Convert.ToInt32(Console.ReadLine());
                int fact = 0;

                for (int i = 1; i<cantidadProductos + 1; i++)
                {
                    Console.WriteLine("Ingrese la cantidad del producto " + i + ":");
                    int cantidadProducto = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor por unidad del producto: ");
                    int valorUnidad = Convert.ToInt32(Console.ReadLine());
                    int factura = valorUnidad * cantidadProducto;
                    fact = fact+factura;

                }
                    Console.WriteLine("Total factura: " + fact);
            }
            else if(ejercicio == 7)
            {
                Console.WriteLine("Ingrese cuantos clientes serán atendidos: ");
                int numeroClientes = Convert.ToInt32(Console.ReadLine());

                static void empresa()
                {
                    for (int i = 1; i < numeroClientes + 1; i++)
                    {
                        Console.WriteLine("Ingrese la cantidad de tipos de productos: ");
                        int cantidadProductos = Convert.ToInt32(Console.ReadLine());
                        int fact = 0;

                        for (int j = 1; j < cantidadProductos + 1; j++)
                        {
                            Console.WriteLine("Ingrese la cantidad del producto " + j + ":");
                            int cantidadProducto = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor por unidad del producto: ");
                            int valorUnidad = Convert.ToInt32(Console.ReadLine());
                            int factura = valorUnidad * cantidadProducto;
                            fact = fact + factura;

                        }
                        Console.WriteLine("Total factura: " + fact);
                        int alerta = 100000;
                        double descuento = 0.10;
                        if (fact >= alerta)
                        {
                            double valorTotal = fact - (fact * descuento);
                            Console.WriteLine("Su compra es mayor a 100.000, la empresa le obsequio 10% de descuento");
                            Console.WriteLine("Ahora el valor total es: " + valorTotal);
                        }
                        Console.WriteLine("Ingrese 1 si desea finalizar el proceso, ingrese 2 si desea volverlo a hacer: ");
                        int repetir = Convert.ToInt32(Console.ReadLine());
                        if (repetir == 1)
                        {
                            break;
                        }
                        if (repetir == 2)
                        {
                            empresa();
                        }
                        else
                        {
                            Console.WriteLine("Introdujo una opcion erronea.");
                            break;
                        }
                    }
                }

                
            }
            else
            {
                Console.WriteLine("Introdujo una opcion erronea");
            }
        }
    }
}
