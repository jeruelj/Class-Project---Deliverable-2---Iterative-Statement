using System;

namespace Class_Project___Deliverable_2___Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is where the user will enter a value. 
            Console.WriteLine("Please choose a value between 1 - 100");

            try
            {

                //This is where the user will enter the integer
                string input = Console.ReadLine();

                //This is where the value will be read
                int input_value = int.Parse(input);

                //This is where the range of integeres are set
                if ((input_value >= 1) && (input_value <= 100))
                {
                    //Once the loop has commenced it will inform you that it is running
                    Console.WriteLine("Executing while loop");

                    // Here is the while loop!
                    int count = 1;
                    while (count <= input_value)
                    {
                        //Incorporates the number the user has entered and states the number of the iteration
                        Console.WriteLine("You have entered" + input_value + "This is the current integer in the loop" + " " + count);
                        count = count + 1;
                    }

                }
                else if (input_value < 1)
                {
                    Console.WriteLine("Please choose a value between 1 - 100");
                }
                else if (input_value > 100)
                {
                    Console.WriteLine("Please choose a value between 1 - 100");
                }
            }

            catch
            {
                //If the user enters a number out of range or a non integer value. 
                Console.WriteLine("You have entered a value that does not meet the requirement. Please try a value between 1 - 100.");
            }
        }
    }
}
