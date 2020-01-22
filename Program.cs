using System;

namespace escolhaplataforma
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Escolha uma das opções: \n1 - Abrir Netflix \n2 - Abrir Amazon Prime \n3 - Abrir HBO GO \n4 - Sair");
           int menu=0;
           Console.WriteLine("\nSua escolha");
           menu = Convert.ToInt32(Console.ReadLine());

           switch (menu)           
           {
               case 1:
               Console.WriteLine("OK!! Abrir Netflix!!");
               break;

               case 2:
               Console.WriteLine("OK!! Abrir Amazon Prime!!");
               break;

               case 3:
               Console.WriteLine("OK!! Abrir  HBO GO!!");
               break;

               case 4:
               Console.WriteLine("OK!! Saindo do menu..");
               break;

               default:
               Console.WriteLine("Você deve escolher as opções 1, 2, 3 ou 4");
               break;
           }  
        }
    }
}
