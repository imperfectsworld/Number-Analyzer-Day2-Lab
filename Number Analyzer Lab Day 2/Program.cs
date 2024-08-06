using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

bool startApp = true;
Console.WriteLine("Please enter your name");
string name = Console.ReadLine();
Console.WriteLine($"Welcome to the Descision Maker App {name}");


while (startApp == true)
{


    Console.WriteLine("Please enter an integer between 1 and 100");
    int myNum = int.Parse(Console.ReadLine());


    if (myNum >= 0 && myNum <= 100)
    {
        if (myNum < 60 && myNum % 2 != 0)
        {

            Console.WriteLine($"{myNum} is odd and less than 60");

            //try again?

            Console.WriteLine("Try again? y/n?");

            string answer = Console.ReadLine();

            if(answer == "n" || answer == "N")
            {
                Console.WriteLine($"{name}, thanks for playing!");
                startApp = false;
                break;
            }

            else
            {
                continue;
            }

           


        }
        else if (myNum >= 2 && myNum <= 24 && myNum % 2 == 0)
        {
            Console.WriteLine($"{myNum} is even and less than 25");

            Console.WriteLine("Try again? y/n?");

            string answer = Console.ReadLine();

            if (answer == "n" || answer == "N")
            {
                Console.WriteLine($"{name}, thanks for playing!");
                startApp = false;
                break;
            }

            else
            {
                continue;
            }



        }

        else if (myNum >= 26 && myNum <= 60 && myNum % 2 == 0)
        {
            Console.WriteLine($"{myNum} is even and between 26 and 60");


            Console.WriteLine("Try again? y/n?");

            string answer = Console.ReadLine();

            if (answer == "n" || answer == "N")
            {
                Console.WriteLine($"{name}, thanks for playing!");
                startApp = false;
                break;
            }

            else
            {
                continue;
            }


        }

        else if (myNum > 60 && myNum % 2 == 0)
        {
            Console.WriteLine($"{myNum} is even and greater than 60");
            
         


            Console.WriteLine("Try again? y/n?");

            string answer = Console.ReadLine();

            if (answer == "n" || answer == "N")
            {
                Console.WriteLine($"{name}, thanks for playing!");
                startApp = false;
                break;
            }

            else
            {
                continue;
            }
          
        }

        else if (myNum > 60 && myNum % 2 != 0)
        {
            Console.WriteLine($"{myNum} is odd and greater than 60");
         
            Console.WriteLine("Try again? y/n?");

            string answer = Console.ReadLine();

            if (answer == "n" || answer == "N")
            {
                Console.WriteLine($"{name}, thanks for playing!");
                startApp = false;
                
                break;
            }

            else
            {
                continue;
            }

            
        }

        else
        {
            Console.WriteLine("Incorrect number try again.");  //validation
            continue;
        }

    }
}