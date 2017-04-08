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
            //Add welcome text leading the user into the program, introducing pet and rules, etc.
            
            //Get user to name the pet
            Console.Write("What would you like to name your pet? \t");
            string petName = Console.ReadLine();

            //instantiate a new instance of the pet
            VirtualPet myPet = new VirtualPet(petName);

            //Insert commentary welcoming user to their new pet?

            //declare variables that will be used in the do/while loop
            int selectedOption; //will store which menu option the user chooses
            int ctr = 0; //will count how many times the loop has run

            do
            {
  
                //list the alternate scenarios the user will encounter based on the number of times they have cycled through the loop
                //if (ctr == 3)
                //{
                //    myPet.MyPetStatus();
                //    myPet.PetRunsAwayScenario();
                //}

                //display updated pet status above the menu
                myPet.MyPetStatus();

                //Menu of options for user actions
                Console.WriteLine();
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Feed your dragon 5 head of cattle");
                Console.WriteLine("2. Go to the lake");
                Console.WriteLine("3. Practice flying maneuvers");
                Console.WriteLine("4. Play \"hide the treasure\" (fake treasure of course!)");
                Console.WriteLine("5. Fly to wildlands (here your dragon can vent!)");
                Console.WriteLine("6. Sleep under the stars");
                Console.WriteLine("7. Host a barbeque, courtesy of dragon fire!");
                Console.WriteLine("10. Quit");


               selectedOption = int.Parse(Console.ReadLine());

                //create space between menu and response to user
                Console.WriteLine();

               //create a random number generator that will randomly call Tick()
               //Random RandomGenerator = new Random();
               //int randomNum = RandomGenerator.Next(0, 4);

               //if (randomNum==2)
               // {
               //     myPet.Tick(selectedOption);
               // }

               //else
               // {
                    switch (selectedOption)
                    {
                        //user selects 1 = feed the pet
                        case 1:

                            myPet.FoodDecrease();
                            myPet.FoodDecrease();

                            //other values increase
                            myPet.WaterIncrease();
                            myPet.ExerciseIncrease();
                            myPet.DestructionIncrease();

                            //response to user action
                            Console.WriteLine("\r\nNothing better than a good steak.");
                            break;

                        //user selects 2 = water the pet
                        case 2:

                            myPet.WaterDecrease();

                            //other values increase
                            myPet.DestructionIncrease();

                            //response to user action
                            Console.WriteLine("Your dragon has thoroughly enjoyed your excursion and has replentlished its store of water");
                            break;

                        //user selects 3 = fly pet
                        case 3:

                            myPet.ExerciseDecrease();
                            
                            //other values decrease
                            myPet.DestructionDecreaseGeneral();

                            //other values increase
                            myPet.FoodIncrease();
                            myPet.WaterIncrease();
                            myPet.SleepIncrease();

                            //response to user action
                            Console.WriteLine("Stunning. There's nothing like the feeling of soaring through the sky.");
                            break;

                        //user chooses 4 = play treasure game
                        case 4:

                            myPet.ExerciseDecrease();
                            myPet.DestructionDecreaseGeneral();

                            //other values increase
                            myPet.FoodIncrease();
                            myPet.WaterIncrease();
                            myPet.SleepIncrease();

                            //response to user action
                            Console.WriteLine("You've gotta do what you've gotta do. \r\nUse that dragon instinct for teasure against him! \r\n Of course, make sure you stay ahead of him and hide it well. \r\nDragons are remarkably intelligent!");
                            break;

                        //user chooses 5 = wilderness trip
                        case 5:

                            myPet.DestructionDecreaseWilderness();
                            myPet.ExerciseDecrease();
                            myPet.ExerciseDecrease();

                            //other values increase
                            myPet.FoodIncrease();
                            myPet.FoodIncrease();
                            myPet.WaterIncrease();
                            myPet.WaterIncrease();
                            myPet.SleepIncrease();
                            myPet.SleepIncrease();

                            //response to user action
                            Console.WriteLine("It never gets old. Power of that magnitude would blow anyone away. \r\nLuckily, so far not literally! \r\nStay careful!");
                            break;

                        //user chooses 6 = sleep
                        case 6:

                            myPet.SleepDecrease();

                            //other values increase
                            myPet.FoodIncrease();
                            myPet.WaterIncrease();
                            myPet.ExerciseIncrease();
                            myPet.DestructionIncrease();

                            //response to user action
                            Console.WriteLine("Hopefully where you live the skies are clear. \r\nNothing like a summer evening streaked with shooting stars");
                            break;
                        
                        //user chooses 7 = barbeque
                        case 7:

                            myPet.DestructionDecreaseGeneral();
                            myPet.FoodDecrease();

                            //other values increase
                            myPet.WaterIncrease();
                            myPet.WaterIncrease();
                            myPet.SleepIncrease();

                            //response to user actions
                            Console.WriteLine("Remember the days when barbeques used to be a lot of work? \r\n Gone forever! \r\n\r\nEver struggle with finding friends or entertaining your friends? \r\nThose days are also gone for good. \r\nMeat roasted to perfection under blue skies and balmy breezes. Life is good.");
                            break;

                        //user chooses 10 = quit
                        case 10:

                            Console.WriteLine("It was lovely to meet you. "+petName+" will greatly miss you. We hope you will return soon!");
                            break;

                        default:

                            Console.WriteLine("Invalid option selected.");
                            break;
                    }
                //}

                //TODO We can put method calls here so the pet can have some values change automatically
                //myPet.HungerIncrease();

                //ctr++; // keep track of how many times the loop has cyled through.

                //create space between each iteration for readability
                Console.WriteLine();
                Console.WriteLine();

            } while (selectedOption != 10);

        }
    }
}
