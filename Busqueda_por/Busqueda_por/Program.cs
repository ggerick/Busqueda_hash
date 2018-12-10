using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Program
    {
        public static int n = 100;//Un entero igualadao a 100 
        public static int p = (100 / 2);//50
        public static int[] lista = new int[n];//Creamos un arreglo de enteros de tamaño 100


        public static int Extraer_hach(string Num)
        {
            int contador = 0, a = 0, b = 0, suma = 0;//a y b significan las posiciones de los numeros que vamos a sumar, o sea los números significativos para nosotros
            foreach (char numero in Num)//Recorremos el numero, dígito por dígito
            {
                contador = contador + 1;//Va incrementando el contador
                if (contador == 3)//si el contador ya está en la posición 3, entra a la condicion
                {
                    a = Convert.ToInt32(numero.ToString()); // y ese dígito lo guardamos en a
                }
                if (contador == 7)// si el contador está en la posicion 7, entra a la condición
                {
                    b = Convert.ToInt32(numero.ToString()); //y almacenamos ese dígito en b
                }
            }
            suma = a + b;//Al final sumanos nuestros dos números significativos
            return suma;//Y regresamos la suma
        }
        public static void Insertar()
        {

            string Num = "", opc = "si";//variable donde guardaremos el numero, y variable opc que declara con "si" para iniciar con la condicion
            int refer = 0, d = p, k = 0;

            do
            {

                if (opc == "si")//El ciclo inicia porque la variable opcion se declara al principio con SI
                {
                    Console.WriteLine("Dame el numero: ");//Entrada del numero
                    Num = Console.ReadLine();
                    refer = Extraer_hach(Num);//Refer sera la suma de nuestros dos numeros significativos   


                    if (lista[refer] == -1)//Si el valor en la posicion de nuestra suma de numeros significativos es igual a "-1", es porque no hay ningun valor ahi
                    {
                        lista[refer] = Convert.ToInt32(Num);//Entonces el numero ingresado anteriormente, lo guardamos en la posicion de nuestra suma, y deja de ser "-1"
                        Console.WriteLine("El elemento fue guardado exitosamente...");//e imprimimos que fue guardado en el arreglo
                        Console.ReadKey();
                    }
                    else
                    {
                      
                        do
                        {
                            if (d < lista.Length)//Si d(50) es menor al tamaño de la lista (100)
                            {
                                if (lista[d] == -1)//Si en la posicion d no hay nada(que es igual a -1)
                                {
                                    lista[d] = Convert.ToInt32(Num);//En esa posición se va a guardar el número
                                    Console.WriteLine("El elemento fue guardado exitosamente desb...");//El numero fue guardado con éxito
                                    Console.ReadKey();
                                  
                                    k = 1;
                                }
                                if (d >= 20)
                                {
                                    Console.WriteLine("El elemento No se pudo guardar");
                                    k = 1;
                                }
                            }
                            d = d + 1;

                        } while (k != 1);
                    }
                }
                Console.Clear();
                Console.WriteLine("Quieres ingresar otro dato si/no: ");
                opc = Console.ReadLine();
            } while (opc != "no");
        }
        public static void Buscar()
        {
            string buscar = " ", opc = "si";
            int refer = 0, b = 0, d = p, k = 0;
            do
            {

                if (opc == "si")
                {
                    Console.WriteLine("Ingrese el numero de control que decee buscar");
                    buscar = Console.ReadLine();
                    refer = Extraer_hach(buscar);
                    if (lista[refer] == Convert.ToInt32(buscar))
                    {
                        Console.WriteLine("El elemento existe en esta lista");
                        b = 1;
                    }
                    else
                    {
                        do
                        {
                            if (d < n)
                            {
                                if (lista[d] == Convert.ToInt32(buscar.ToString()))
                                {
                                    Console.WriteLine("El elemento existe en esta lista, pero en reflujo");
                                    b = 1;
                                    k = 1;
                                }
                            }
                            if (d >= n)
                            {

                                k = 1;
                            }
                            d = d + 1;

                        } while (k != 1);
                    }
                    if (b != 1)
                    {
                        Console.WriteLine("El elemento no fue encontrado");
                    }
                }
                Console.WriteLine("\n\tQuieres otro buscar un numero si/no: ");
                opc = Console.ReadLine();
            } while (opc != "no");
        }

        public static void Menu()
        {
            int opc = 10; 
            for (int i = 0; i < lista.Length; i++)//Un ciclo para  asignarle -1 a todos los valores de la lista
            {
                lista[i] = -1;
            }
            do
            {
                Console.Clear();//Limpia la pantalla 
                Console.WriteLine("\t1-.Insertar valores\n\t2-.Buscar Valor\n\t0-.Salir");//Opciones para elegir si quiere insertar valores o buscar el valor
                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1:
                        Insertar();//Llama el metodo para insertar un valor
                        break;
                    case 2:
                        Buscar();//Llama el metodo para buscar el metodo deseado
                        break;
                    case 0://Terminar el programa
                        Console.WriteLine("Gracias por usar el programa...");
                        break;
                    default://Opcion invalida, se vuelve a intentar
                        Console.WriteLine("La opccion que intudujo no es valida vuelva a intentarlo");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opc != 0);
        }

        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}