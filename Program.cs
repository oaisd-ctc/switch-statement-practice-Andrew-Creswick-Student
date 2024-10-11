using System;
namespace switch_statement_Andrew_Creswick {
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Enter the number:");
            int number = int.Parse(Console.ReadLine());
            if (number==0){
                Console.WriteLine("Your number is Zero.");
            }
            else if (number==1){
                Console.WriteLine("Your number is One.");
            }
            else if (number==2){
                Console.WriteLine("Your number is Two.");
            }
            else if (number==3){
                Console.WriteLine("Your number is Three.");
            }
            else if (number==4){
                Console.WriteLine("Your number is Four.");
            }
            else if (number==5){
                Console.WriteLine("Your number is Five.");
            }
            else if (number==6){
                Console.WriteLine("Your number is Six.");
            }
            else if (number==7){
                Console.WriteLine("Your number is Seven.");
            }
            else if (number==8){
                Console.WriteLine("Your number is Eight.");
            }
            else if (number==9){
                Console.WriteLine("Your number is Nine.");
            }
            else if (number==10){
                Console.WriteLine("Your number is Ten.");
            }
            else {
                Console.WriteLine("That number is not in range.");
            }
        }
    }
}