using System;


namespace Librería
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = "";//variable para el nombre que ingresa el usuario
            int phone;//variable de # telefónico.
            int compra1, compra2, compra3, compra4, compra5, compra6, compra7, compra8, compra9, compra10;//variables que ayudan a guardar el total de libros ingresados.
            //variable que se utiliza para realizar la operación del descuento.
            double des1 = 0;
            double des2 = 0;
            double des3 = 0;
            double des4 = 0;
            double des5 = 0;
            double des6 = 0;
            double des7 = 0;
            double des8 = 0;
            double des9 = 0;
            double des10 = 0;
            double net1 = 0;//variable que nos ayuda a restarle al total el descuento
            double net2 = 0;//al total del net1 se le suma el impuesto.
            double plusdes;//almacena la suma de todos los descuentos.
            //variables qque nos ayudan a multipliar la cantidad por el precio de los libros.
            int answer1 = 0;
            int answer2 = 0;
            int answer3 = 0;
            int answer4 = 0;
            int answer5 = 0;
            int answer6 = 0;
            int answer7 = 0;
            int answer8 = 0;
            int answer9 = 0;
            int answer10 = 0;
            double impuesto = 0;//variable que almacena la opracion de impuesto.
            double total = 0;//nos almacena la suma de los precios de los libros comprados.
            //libros con su respectivo precio.
            int l1 = 10000;
            int l2 = 3400;
            int l3 = 4000;
            int l4 = 6000;
            int l5 = 2000;
            int l6 = 7000;
            int l7 = 1000;
            int l8 = 9000;
            int l9 = 7500;
            int l10 = 5000;
            int pago = 0;//variable que almacena la cantidad que se debe pagar
            double cambio = 0;//contiene la cantidad con que va a pagar el usuario.


            Console.WriteLine("¡Librería el Buen Lector!\n");//Escribe el nombre de la librería.
            Console.WriteLine("Digite su nombre por favor: ");//pide al usuario que digite el nombre
            name = Console.ReadLine();//lee el nombre
            Console.WriteLine("Digite su número teléfonico por favor:");//pide al usuario el # de telefono.
            phone = int.Parse(Console.ReadLine());//lee el telefono
            Console.WriteLine("Bienvenido:" + name + "\nDigite el numero de los libros que desea comprar\n" + "\nLibrería");//imprime la bienvenida al usuario
            //menú con el nombre de cada libro disponible, el usuario digita la cantidad que quiere por cada libro.
            Console.WriteLine("\n1)El Señor de los anillos, Las dos torres.");
            compra1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n2)Alicia en el país de la Maravillas.");
            compra2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n3)Cementerio de Mascotas.");
            compra3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n4)Quiero aprender.");
            compra4 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n5)El poder del pensamiento Positivo.");
            compra5 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n6)Mi primer libro de matemáticas.");
            compra6 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n7)Las aventuras de Tom Sawyer.");
            compra7 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n8)El mago de Oz.");
            compra8 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n9)La zona muerta.");
            compra9 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n10)Viaje al centro de la tierra");
            compra10 = int.Parse(Console.ReadLine());
            //si la compra es mayor o = a 1 procede hacer las siguiente operaciones, de lo contrario no realiza nada.
            if (compra1 >= 1)
            {
                answer1 = l1 * compra1;//multiplica el precio por la cantidad que digito el usuario
                des1 = answer1 * 0.15;//le aplica el descuento a al total de compra

            }
            if (compra2 >= 1)
            {
                answer2 = l2 * compra2;
                des2 = answer2 * 0.05;


            }
            if (compra3 >= 1)
            {
                answer3 = l3 * compra3;
                des3 = answer3 * 0.1;


            }
            if (compra4 >= 1)
            {
                answer4 = l4 * compra4;
                des4 = answer4 * 0.2;


            }
            if (compra5 >= 1)
            {
                answer5 = l5 * compra5;
                des5 = answer5 * 0.25;



            }
            if (compra6 >= 1)
            {
                answer6 = l6 * compra6;
                des6 = answer6 * 0.2;


            }
            if (compra7 >= 1)
            {
                answer7 = l7 * compra7;
                des7 = answer7 * 0.05;


            }
            if (compra8 >= 1)
            {
                answer8 = l8 * compra8;
                des8 = answer8 * 0.15;


            }
            if (compra9 >= 1)
            {
                answer9 = l2 * compra9;
                des9 = answer9 * 0.1;



            }
            if (compra10 >= 1)
            {
                answer10 = l10 * compra10;
                des10 = answer10 * 0.25;



            }
            //suma el total de el precio de todos los libros.
            total = answer1 + answer2 + answer3 + answer4 + answer5 + answer6 + answer7 + answer8 + answer9 + answer10;
            Console.WriteLine("El total a pagar es: ¢" + total);//imprime el total que va a pagar el usuario
            Console.WriteLine("Ingrese el monto con que cancela");//pide que ingrese el monto con el que cancela la compra
            pago = int.Parse(Console.ReadLine());//lee el monto ingresado del pago.
            impuesto = total * 0.13;//aplica impuesto al total
            plusdes = des1 + des2 + des3 + des4 + des5 + des6 + des7 + des8 + des9 + des10;//suma todos los descuentos de cada libro
            net1 = total - plusdes;//al total le quita el descuento
            net2 = net1 + impuesto;//al resultado de net1 le suma el impuesto total.
            cambio = pago - net2;//al pago que se ingresa se le resta el total de la compra con el impuesto incluido

            //imprime factura
            Console.WriteLine(" ");

            Console.WriteLine("======================================================================================\n" +

                                                     "                     " + "*-* Libreria El Buen Lector *_* \n" +
                                "=====================================================================================");
            Console.WriteLine(" ");
            Console.WriteLine("Factura Proforma                                            N° 0001");

            Console.WriteLine("Cliente:" + name + "\nTelefono:" + phone);
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Item                                           Ctd        Precio     SubTotal    ");
            Console.WriteLine("1)El Señor de los anillos, Las dos torres." + "       " + compra1 + "         ¢" + l1 + "      ¢" + answer1);
            Console.WriteLine("2)Alicia en el país de la Maravillas.     " + "       " + compra2 + "         ¢" + l2 + "       ¢" + answer2);
            Console.WriteLine("3)Cementerio de Mascotas.                 " + "       " + compra3 + "         ¢" + l3 + "       ¢" + answer3);
            Console.WriteLine("4)Quiero Aprender.                        " + "       " + compra4 + "         ¢" + l4 + "       ¢" + answer4);
            Console.WriteLine("5)El poder del pensamiento Positivo.      " + "       " + compra5 + "         ¢" + l5 + "       ¢" + answer5);
            Console.WriteLine("6)Mi primer libro de matemáticas.         " + "       " + compra6 + "         ¢" + l6 + "       ¢" + answer6);
            Console.WriteLine("7)Las aventuras de Tom Sawyer.            " + "       " + compra7 + "         ¢" + l7 + "       ¢" + answer7);
            Console.WriteLine("8)El mago de Oz.                          " + "       " + compra8 + "         ¢" + l8 + "       ¢" + answer8);
            Console.WriteLine("9)La zona muerta.                         " + "       " + compra9 + "         ¢" + l9 + "       ¢" + answer9);
            Console.WriteLine("10)Viaje al centro de la tierra           " + "       " + compra10 + "         ¢" + l10 + "       ¢" + answer10);
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Total Orden:    " + "     ¢" + total);
            Console.WriteLine("Descuento:      " + "     ¢" + plusdes );
            Console.WriteLine("Impuesto Venta: " + "      " + "13%");
            Console.WriteLine("Impuesto Total: " + "     ¢" + impuesto);
            Console.WriteLine("Precio Neto:    " + "     ¢" + net2);
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Monto Recibido: " + "¢" + pago);
            Console.WriteLine("Cambio:  " + "¢" + cambio);
            Console.WriteLine(" ");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine(" ");
            Console.WriteLine("GRACIAS POR SU COMPRA...");


            Console.ReadKey();
        }

    }
}
























