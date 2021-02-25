using System;

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
            //Seleccionar
            //piedra > tijera > papel > piedra
            int option = SelectOption();
            Console.WriteLine("Opcion seleccionada :" + option);
            int aiOption = SelectRandom();
            Console.WriteLine("opcion seleccionada : " + aiOption);

            //Seleccionar opción a jugar (piedra, papel o tijera)
            //La computadora genera su opción a jugar de manera aleatoria (piedra, papel o tijera)
            //Determinar quién ganó de acuerdo a las opciones seleccionadas, y mostrar al ganador
            // [Canceled] Jugar 3 partidas, y mencionar quién ganó al final (jugador o computadora)
            CheckWinner(option, aiOption);
            
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="option"> elección del jugador</param>
        /// <param name="aiOption"> elección de la A.I</param>

        static void CheckWinner(int option, int aiOption){

           // string x = "tijera";
           // string y = "papel";
           // string z = "piedra";
            
            if (option == 1 & aiOption == 2 ) // Piedra vs Tijera 
            {
            Console.WriteLine("jugador : piedra");
            Console.WriteLine("A.I : papel");

            Console.WriteLine("player has won");

        }else if(option == 2 & aiOption == 3) // Tijera vs papel
        {
            Console.WriteLine("jugador : papel");
            Console.WriteLine("A.I : tijera");

            Console.WriteLine("player has won");

        }else if(option == 3 & aiOption == 1) // Papel vs Piedra
        
        {
            Console.WriteLine("jugador : papel");
            Console.WriteLine("A.I : piedra");

            Console.WriteLine("player has won");
        }else if(option == aiOption) // empate
        
        {
            //if(option=x  aiOption = x)

            Console.WriteLine("Tie");


        }else //La consola gana
        {
            Console.WriteLine("The A.I has won");
        }
        }
        
    }
}
