using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is how we instantiate a new instance of our pet
            VirtualPet myPet = new VirtualPet(); //using default constructor here

            Console.Write("What would you like to name your pet?");
            string petName = Console.ReadLine();


            //TODO add a greeting for the user. you can also let the user name the pet if you like

            int selectedOption;
            int ctr = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine();

               

                //initialize alternate user interface for specific scenario
                //if (ctr == 3)
                //{
                //    myPet.MyPetStatus();
                //    myPet.PetRunsAwayScenario();
                //}

                myPet.MyPetStatus();

                //TODO fill this out with more options to interact with the pet
                Console.WriteLine();
                Console.WriteLine("Please select an option");
                Console.WriteLine("1. Feed the pet");
                Console.WriteLine("2. Water the pet");
                Console.WriteLine("3. pet sleeps...");
                Console.WriteLine("4. Play with the pet");
                Console.WriteLine("5. Give the pet a toy");
                Console.WriteLine("10. Quit");


               selectedOption = int.Parse(Console.ReadLine());

               Random RandomGenerator = new Random();

               if (ctr ==2) //(RandomGenerator.Next(0,5)==2)
                {
                    myPet.Tick(selectedOption, myPet.ReadHunger(), myPet.ReadThirst(), myPet.ReadEnergy());
                }

               else
                {
                    switch (selectedOption)
                    {
                        //when the user selects option one we feed the pet
                        case 1:

                            myPet.HungerDecrease();
                            Console.WriteLine("Thank you for feeding the pet");
                            break;

                        case 2:

                            myPet.ThirstDecrease();
                            Console.WriteLine("Your pet has been watered!");
                            break;

                        case 3:

                            myPet.EnergyDecrease();
                            Console.WriteLine("Your pet has enjoyed a lovely nap!");
                            break;

                        case 4:


                        //TODO we need to add more cases for the other ways to interact with our pet

                        case 10:

                            Console.WriteLine("Thank you for playing.");
                            break;

                        default:

                            Console.WriteLine("Invalid option selected.");
                            break;
                    }
                }

                //TODO We can put method calls here so the pet can have some values change automatically
                //Feel free to add, remove, or modify which methods are called here
                myPet.HungerIncrease();

                ctr++; // keep track of how many times the loop has cyled through.

            } while (selectedOption != 10);

        }
    }
}
