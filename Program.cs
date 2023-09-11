using System;

 

namespace Ejercicio4

{

    class Program

    {

        static void Main(string[] args)

        {
                    //EJERCICIO 3.3

        // 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

        // Si el importe es menor a ARS 1000, no hay descuento.

        // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.

        // Si el importe es ARS 5000 o más, aplica un descuento del 18%.

        //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla

        //el importe final con el descuento que corresponda.

            // float importe, importeF = 0;

 

            // Console.WriteLine("Ingrese un importe:");

            // importe = float.Parse(Console.ReadLine());

           

 

            // if(importe >= 1000 && importe < 5000){

            //     importeF = importe * 0.90F;

            // }else if(importe >= 5000){

            //     importeF = importe * 0.82F;

            // }else{

            //     //si no hay ningun tipo de dto, guardo el importe en importeF

 

            //     importeF = importe;

            // }

            // Console.WriteLine("El importe final es: " + importeF);

 

           

             //EJERCICIO 3.4

    //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

 

        // int a, b , c, d, minimo;

 

        // Console.WriteLine("Ingrese un numero:");

        // a = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese un numero:");

        // b = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese un numero:");

        // c = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese un numero:");

        // d = int.Parse(Console.ReadLine());

 

        // if(a<b){

        //     minimo = a;

        // }else{

        //     minimo = b;

        // }

        // if(c<minimo){

        //     minimo = c;

        // }

        // if(d<minimo){

        //     minimo = d;

        // }

 

        // Console.WriteLine("El menor numero es: " + minimo);

               

        //EJERCICIO 4.1

 

        //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

 

        // La resta si el primero es mayor que el segundo.

        // La suma si son iguales.

        // El producto si el primero es menor.

 

        // int a, b, rdo;

 

        // Console.WriteLine("Ingrese un numero:");

        // a = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese un numero:");

        // b = int.Parse(Console.ReadLine());




        // // //if(edad > 20 || inicial == 'H' && inicial == 'J')

        // if(a == b){

        //     rdo = a + b;

        // }else if(a > b){

        //     rdo = a - b;

        // }else{

        //     rdo = a * b;

        // }

 

        // Console.WriteLine("El resultado es: " + rdo);

 

        //EJERCICIO 4.2

 

        //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

 

        // Si vende menos de 100 litros, no hay descuento.

        // Si vende entre 101 y 300 litros, el descuento es del 10%.

        // Si vende entre 301 y 500 litros, el descuento es del 15%.

        // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

 

        // Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos

        // y calcule y emita el importe con el descuento aplicado

 

    //     float importe, lt;

 

    //     Console.WriteLine("Ingrese el importe total de venta:");

    //     importe = float.Parse(Console.ReadLine());

    //     Console.WriteLine("Ingrese la cantidad de lt vendidos:");

    //     lt = float.Parse(Console.ReadLine());

       

 

    //     if(lt > 500){

    //         importe *= 0.75F; //25 %

    //     }else if(lt >= 301 && lt <= 500){

    //         importe *= 0.85F; //15 %

    //     }else if(lt >= 101 && lt <= 300){

    //         importe *= 0.90F; //10 %

    //     }else{

    //         importe = importe; // 0 %

    //     }

    //     //si no hay dto

    //    // importeF = importe;

       

 

    //     Console.WriteLine("El importe total es: " + importe + " y compro: "+ lt + " lt");






        //EJERCICIO 4.3

 

        // 3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar.

        //  Para ello existe la siguiente escala de precios:

        //                          i5 (1)      i7 (2)      i9 (3)

        //             8 RAM (1)    USD 800     USD 900     USD 1200

        //             16 RAM (2)   USD 900     USD 1000    USD 1400

        //             32 RAM (3)   USD 1000    USD 1400    USD 2000

        // Además, el equipo viene con un disco que permite almacenar 500 GB de información y

        // que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300.

       

        //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM,

        //y si extiende el disco o no (ingresa 1 para extender o 0 para no extender) y

        //calcule y emita por pantalla el monto de la máquina seleccionada.

 

        // int opcion;

        int procesador, mem, disco; //las var q va a cargar la persona

        float precio; //p guardar el precio

        precio = 0;                        

        Console.WriteLine("Ingrese una opcion p/ procesador: ");//pedir los val p/cargar estas var

        procesador = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese una opcion p /memoria: ");//pedir los val p/cargar estas var

        mem = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese una opcion p/ disco: ");//pedir los val p/cargar estas var

        disco = int.Parse(Console.ReadLine());

 

    // //si el procesador es 1, evaluo la memoria

    //     if(procesador == 1){

    //         if(mem == 1){

    //             precio = 800;

    //         }else if(mem == 2){

    //             precio = 900;

    //         }else{

    //             precio = 1000;

    //         }

    //     }

   

 

    // //si el procesador es 1:

    // if(procesador == 1){

    //     switch(mem){

 

    //         case 1: precio = 800;

    //         break;

    //         case 2: precio = 900;

    //         break;

    //         //case 3 o default

    //         default: precio = 1000;

    //         break;

    //     }

    // }

 

    //si el procesador es 1:

 

    switch(procesador){

            case 1:

                    switch(mem){

                        case 1: precio = 800;

                        break;

                        case 2: precio = 900;

                        break;

                       // case 3 o default

                        default: precio = 1000;

                        break;

                    }

            break;        

            case 2:

                    switch(mem){

                        case 1: precio = 900;

                        break;

                        case 2: precio = 1000;

                        break;

                       // case 3 o default

                        default: precio = 1400;

                        break;

                    }

            break;        

            case 3:

                    switch(mem){

                        case 1: precio = 1200;

                        break;

                        case 2: precio = 1400;

                        break;

                       // case 3 o default

                        default: precio = 2000;

                        break;

                    }

            break;          

    }

                //ahora al precio del procesador + mem, le agrego la preg del disco

        if(disco == 1){

            precio = precio + 300;

        }

       Console.WriteLine("El precio final de la compu es: $"+ precio);            





        // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio

        //  si la suma de los dos primeros es mayor al producto del segundo con el tercero.

 

        // int a, b, c, Rsuma, Rmulti;

 

        // Console.WriteLine("Ingrese 1er numero:");

        // a = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese 2do numero:");

        // b = int.Parse(Console.ReadLine());

        // Console.WriteLine("Ingrese 3er numero:");

        // c = int.Parse(Console.ReadLine());

 

        // Rsuma = a + b;

        // Rmulti = b * c;

 

        // if(Rsuma > Rmulti){ //o (a+b) > (b*c)

        //     Console.WriteLine("La suma es mayor al producto");

        // }

 

        // Console.WriteLine("La suma es: " + Rsuma);

        // Console.WriteLine("La multiplicacion es: " + Rmulti);

 

        // 5. Hacer un programa para ingresar 4 números.

        // Luego analizar e informar por pantalla si los mismos se encuentran ordenados

        // de forma decreciente

 

    //     int a, b, c, d;

 

    //    Console.WriteLine("Ingrese 1er numero:");

    //     a = int.Parse(Console.ReadLine());

    //     Console.WriteLine("Ingrese 2do numero:");

    //     b = int.Parse(Console.ReadLine());

    //     Console.WriteLine("Ingrese 3er numero:");

    //     c = int.Parse(Console.ReadLine());

    //     Console.WriteLine("Ingrese 4to numero:");

    //     d = int.Parse(Console.ReadLine());

 

    //     if(a > b && b > c && c > d){

    //         Console.WriteLine("Estan ordenados de forma decreciente");

    //     }else{

    //         Console.WriteLine("No estan ordenados");

    //     }




        }

    }

}

 