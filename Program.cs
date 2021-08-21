using System;

namespace HerramientasProgramacionI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clases
            // Clase_11_08_2021();
            // Clase_13_08_2021();
            // Clase_18_08_2021();
            Clase_20_08_2021();

            // Extra
            Console.ReadLine();
        }

        static void Clase_11_08_2021()
        {
            Console.Write("Estoy en Clase_Uno");
            Console.Write("Otro ejemplo" + "De salida por consola");
            Console.Write("Esta es una nueva línea");

            Console.WriteLine("Estoy en Clase_Uno");
            Console.WriteLine("Otro ejemplo" + "De salida por consola");
            Console.WriteLine("Esta es una nueva línea");

            Console.Write("\n\n\n\n\n\n Estoy en Clase_Uno");
            Console.Write("\n\n\n\n Otro ejemplo" + "De salida por consola");
            Console.Write("\n\n\n\n Esta es una nueva línea");

            Console.WriteLine("Estoy en Clase " + 1);
            Console.WriteLine("1" + "1");
            Console.WriteLine("La suma de 4 mas 2 es " + (4 + 2));
            Console.WriteLine("El cociente de " + "4 " + "y 2" + " es " + 4 / 2);
            Console.WriteLine("La suma de 2 + 4 es " + (2 + 4));

            int edad;
            edad = 45;
            int mayor = 54;

            String Edad_Dos = "Edad";

            Console.WriteLine("La edad de Juan es de " + edad + " años");
            Console.WriteLine("El mayor tiene " + mayor + " años de edad");
            Console.WriteLine("La " + Edad_Dos + " de Juan es de " + edad + " años");

            int diferencia = mayor - edad;
            Console.WriteLine("La diferencia de edades es " + diferencia);
            Console.WriteLine("-----------------------\n");

            int radio = 5;
            int h = 15;
            int lado = 4;

            double aCirculo = 2 * Math.PI * Math.Pow(radio, 2);
            int aCuadrado = lado * lado;
            double vEsfera = 4 / 3 * Math.PI * Math.Pow(radio, 3);
            double vCilindro = Math.PI * Math.Pow(radio, 2) * h;

            Console.WriteLine("El área del círculo de radio " + radio + ", es de: " + aCirculo);
            Console.WriteLine("El área del cuadrado de lado " + lado + ", es de: " + aCuadrado);
            Console.WriteLine("El volúmen de la esfera de radio " + radio + ", es de: " + vEsfera);
            Console.WriteLine("El volúmen del cilindro de radio " + radio + " y altura " + h + ", es de: " + vCilindro);
        }

        static void Clase_13_08_2021()
        {
            Clase_13_08_2021_img1();
            Clase_13_08_2021_img2();
            Clase_13_08_2021_img3();
            Clase_13_08_2021_img4();
        }

        static void Clase_13_08_2021_img1()
        {
            Console.WriteLine("=== Clase 13/08/2021 - Imagen 1 ===");

            int edad_Juan = 52;
            int edad_Pedro = 45;

            Console.WriteLine("{0} {1} {2} {3}", "La edad de Juan es:", edad_Juan, "y la de Pedro es:", edad_Pedro);
            Console.WriteLine("La edad de Juan es: " + edad_Juan + " y la de Pedro es: " + edad_Pedro);

            double mayor = 52.0;
            int menor = 23;
            double cociente = mayor / menor;

            Console.WriteLine("{0} {1}", "El cociente entre el mayor y el menor es:", cociente);
            Console.WriteLine("{0} {1}", "La diferencia entre el mayor y el menor es:", mayor - menor);
        }

        static void Clase_13_08_2021_img2()
        {
            Console.WriteLine("=== Clase 13/08/2021 - Imagen 2 ===");

            int radio = 5;
            byte siglos = 20;
            ushort anios = 65535;
            uint dias = 4294867295;
            ulong horas = 17531520;

            Console.WriteLine("Un entero de tipo byte tiene como máximo valor: " + Byte.MaxValue);
            Console.WriteLine("Un entero de tipo ushort tiene como máximo valor: " + ushort.MaxValue);
            Console.WriteLine("Un entero de tipo uint tiene como máximo valor: " + uint.MaxValue);
            Console.WriteLine("Un entero de tipo ulong tiene como máximo valor: " + ulong.MaxValue);

            Console.WriteLine("Un entero de tipo sbyte tiene como máximo valor: " + SByte.MaxValue);
            Console.WriteLine("Un entero de tipo int16 tiene como máximo valor: " + Int16.MaxValue);
            Console.WriteLine("Un entero de tipo int tiene como máximo valor: " + Int32.MaxValue);
            Console.WriteLine("Un entero de tipo long tiene como máximo valor: " + Int64.MaxValue);
            Console.WriteLine("Un entero de tipo ushort tiene como máximo valor: " + UInt16.MaxValue);
            Console.WriteLine("Un entero de tipo uint tiene como máximo valor: " + UInt32.MaxValue);
            Console.WriteLine("Un entero de tipo UInt64 tiene como máximo valor: " + UInt64.MaxValue);
            Console.WriteLine("Un entero de tipo float tiene como máximo valor: " + float.MaxValue);
            Console.WriteLine("Un entero de tipo double tiene como máximo valor: " + double.MaxValue);
            Console.WriteLine("Un entero de tipo decimal tiene como máximo valor: " + decimal.MaxValue);

            Console.WriteLine("El valor de PI es: " + Math.PI);
            Console.WriteLine("El valor de la base neperiana es: " + Math.Exp(1));
        }

        static void Clase_13_08_2021_img3()
        {
            Console.WriteLine("=== Clase 13/08/2021 - Imagen 3 ===");

            int a = 1;
            int b = 2;

            bool mayor_que = (a > b);
            bool igual_a = (a == b);
            bool diferente = (a != b);
            bool menor_que = (a < b);
            bool mayor_igual = (a >= b);
            bool menor_igual = (a <= b);

            Console.WriteLine(mayor_que || !igual_a);
            Console.WriteLine(!igual_a);
            Console.WriteLine(diferente);
            Console.WriteLine(menor_que);
            Console.WriteLine(mayor_igual);
            Console.WriteLine(menor_igual);
        }

        static void Clase_13_08_2021_img4()
        {
            Console.WriteLine("=== Clase 13/08/2021 - Imagen 4 ===");

            int lado_uno = 5;
            int lado_dos = 3;
            int radio = 4;

            double area_rect = lado_uno * lado_dos;
            double area_circ = Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("El área del rectángulo es mayor que la del círculo: " + (area_rect > area_circ));
            Console.WriteLine("{0} {1}", "El área del rectángulo es mayor que la del círculo:", (area_rect > area_circ));

            object contain1 = 5;
            object contain2 = "Five";
            object contain3 = 5234923489123748971;

            Console.WriteLine("\nEl unicode de {0} es {1}", "a", (int)('a'));
            Console.WriteLine("\nEl valor del contenedor uno es {0} y del " + "contenedor 2 es {1}", contain1, contain2);
            Console.WriteLine("\nEl valor del contenedor tres es " + contain3);
        }

        static void Clase_18_08_2021()
        {
            Clase_18_08_2021_img1();
            Clase_18_08_2021_img2();
            Clase_18_08_2021_img3();
            Clase_18_08_2021_img4();
            Clase_18_08_2021_img5();
        }

        static void Clase_18_08_2021_img1()
        {
            Console.WriteLine("Me encanta");
            Console.Write("programar en ");
            Console.Write("\nC#!");

            string edad = "veintiseis";
            string text = "Él tiene " + edad + " años de edad.";
            char Letra = '6';
            int num = 1;

            Console.WriteLine(text);
            Console.WriteLine("Esta es una variable tipo char '" + Letra + "'");
            Console.WriteLine("Este es el número uno: " + num);

            double num1 = (5.0 + 3.0 / 4) / (17 / 3 + 4 / 3);
            Console.WriteLine("El número uno es: " + num1);
        }

        static void Clase_18_08_2021_img2()
        {
            int edad = 26;
            Console.WriteLine("Él tiene " + edad + " años de edad.");

            string s = "Veintidos: " + 2 + 2;
            Console.WriteLine(s);

            string s1 = "Cuatro: " + (2 + 2);
            Console.WriteLine(s1);

            Console.WriteLine("{1} tiene {0} años de edad y es de {3}", 18, "John", 0, "Medellín");

            Console.WriteLine("{0,6}", 123);
            Console.WriteLine("{0,6}", 1234);
            Console.WriteLine("{0,6}", 12);
            Console.Write("{0,-6}", 123);
            Console.WriteLine("--end");
            Console.WriteLine("{0,8}", "*   *");
            Console.WriteLine("{0,9}", "* * * *");
            Console.WriteLine("{0,10}", "*   *   *");
        }

        static void Clase_18_08_2021_img3()
        {
            Console.WriteLine("{0:C2}", 123.456m);
            Console.WriteLine("{0:D6}", -1234);
            Console.WriteLine("{0:E2}", 123);
            Console.WriteLine("{0:F2}", -123.456);
            Console.WriteLine("{0:N2}", 1234567.8);
            Console.WriteLine("{0:P}", 0.456);
            Console.WriteLine("{0:X}", 254);

            int radio = 2;
            double pi = Math.PI;
            double area = pi * Math.Pow(radio, 2);
            double funcion = 3 * (1.5 * 1.5) + 2 * 1.5 + 2;

            Console.WriteLine("El área del círculo es: {0:C4} y la función es: {1:F2}", area, funcion);
            Console.WriteLine("La función es mayor que el área: " + (funcion > area));
        }

        static void Clase_18_08_2021_img4()
        {
            Console.WriteLine("{0:0.00}", 1);
            Console.WriteLine("{0:#.##}", 0.234);
            Console.WriteLine("{0:#####}", 12345.67);
            Console.WriteLine("{0:(0#) ### ## ##}", 29342525);
            Console.WriteLine("{0:%##}", 0.234);

            DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
            Console.WriteLine("{0:dd.MM.yyyy HH:mm:ss}", d);

            Console.WriteLine("{0:G}", DayOfWeek.Friday);
            Console.WriteLine("{0:D}", DayOfWeek.Friday);
            Console.WriteLine("{0:X}", DayOfWeek.Friday);
        }

        static void Clase_18_08_2021_img5()
        {
            double resultadoArriba = 3.8 + ((1 + 23.6 / 45.8) / (25.3 + 65.9 / 74.3));
            double resultadoAbajo = 5.2 + ((56.9 + 69.3 / (45.3 + 56.3 / 5)) / (96.3/563.3));
            Console.WriteLine(resultadoArriba / resultadoAbajo);

            Console.WriteLine(
                (3.8 + ((1 + 23.6/45.8) / (25.3 + 65.9/74.3))) / (5.2 + ((56.9 + 69.3 / (45.3 + 56.3/5)) / (96.3/563.3)))
                );


            double arriba1 = 1 + 23.6 / 45.8;
            double abajo1 = 25.3 + 65.9 / 74.3;

            double arriba = 3.8 + arriba1 / abajo1;

            double arriba3 = 45.3 + 56.3 / 5;
            double arriba2 = 56.9 + 69.3 / arriba3;
            double abajo2 = 96.3 / 563.3;

            double abajo = 5.2 + arriba2 / abajo2;

            double final = arriba / abajo;
            Console.WriteLine(final);

            Console.WriteLine((3.8 + (1 + 23.6 / 45.8) / (25.3 + 65.9 / 74.3)) / (5.2 + (56.9 + 69.3 / (45.3 + 56.3 / 5)) / (96.3 / 563.3)));
        }

        static void Clase_20_08_2021()
        {

            Clase_20_08_2021_ejercicio1();
            Clase_20_08_2021_condicionales();
        }

        static void Clase_20_08_2021_ejercicio1()
        {
            double x = 2.7;
            double resultado = 3 * Math.Pow(x, 3) + 2 * Math.Pow(x, 2) - 4 * x + 8;

            Console.WriteLine("El resultado de f(2.7) = 3x^3 + 2x^2 - 4x + 8 es {0:#.##}", resultado);
            Console.WriteLine("El resultado de f(2.7) = 3x^3 + 2x^2 - 4x + 8 es {0:#.###}", resultado);
            Console.WriteLine("El resultado de f(2.7) = 3x^3 + 2x^2 - 4x + 8 es {0:N4}", resultado);
        }

        static void Clase_20_08_2021_condicionales()
        {
            Console.WriteLine("=== Condicionales ===");

            // 1 condición
            double mayor = 56.2;
            double menor = 47.6;

            if (mayor < menor)
            {
                Console.WriteLine("El mayor es: " + menor);
            }
            else
            {
                Console.WriteLine("El mayor es: " + mayor);
            }

            // Condicionales multidimensionales
            double num_uno = 23.65;
            double num_dos = 58.32;
            double num_tres = 65.9;

            if (num_uno > num_dos)
            {
                if (num_dos > num_tres)
                {
                    Console.WriteLine("El mayor es: " + num_uno);
                }
                else
                {
                    if (num_tres > num_uno)
                    {
                        Console.WriteLine("El mayor es: " + num_tres);
                    }
                }
            }
            else
            {
                if (num_tres > num_uno)
                {
                    Console.WriteLine("El mayor es: " + num_tres);
                }
            }
        }
    }
}
