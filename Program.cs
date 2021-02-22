﻿using System;

namespace Piedra_papel_o_tijeras
{
    class Program
    {

        /// <summary>
        /// Solicita una opcion a jugar
        /// </summary>
        /// <returns> la opcion seleccionada: 1 - piedra, 2 - papel, 3 - tijera</returns>


        static int SelectOption()
        {
            
            Console.WriteLine("Elige tu mano");
            Console.WriteLine("1) Piedra");
            Console.WriteLine("2) Papel");
            Console.WriteLine("3) Tijera");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        static void Main(string[] args)
        {
            int option = SelectOption();
            Console.WriteLine("Opcion seleccionada :" + option);
            int aiOption = SelectRandom();
            Console.WriteLine("opcion seleccionada : " + aiOption);

            //Seleccionar opción a jugar (piedra, papel o tijera)
            //La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)
            //Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador
            //Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)
       
            
            
        }
        /// <summary>
        /// Solicita una opcion a jugar
        /// </summary>
        /// <returns> la opcion seleccionada aleatoriamente entre 1 - piedra, 2 - papel, 3 - tijera</returns>

         static int SelectRandom()
        {
            Random rnd = new Random();

            int option = rnd.Next(1,4);
            
            return option;
        }
    }
}
