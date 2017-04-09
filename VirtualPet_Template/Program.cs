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
            string userOption; //stores which menu option user chooses
                int selectedOption; //stores which menu option the user chooses as an int after TryParse
                int ctr = 0; //will count how many times the loop has run

                do
                {

                    //list the alternate scenarios the user will encounter based on the number of times they have cycled through the loop
                    if (ctr == 8 || ctr == 28)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        myPet.PetRunsAwayScenario();
                    }
                    else if (ctr == 18||ctr==38)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        myPet.SickPetScenarioGeneral();
                    }
                    else
                    {
                        //even if there's not any other possible condition, should I have an else statement, even if it's blank?
                    }

                    if (myPet.ReadFood() < -3)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        myPet.SickPetOverfed();
                    }
                    else if (myPet.ReadFood() > 29)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Your pet despeartely needs food! The consequence:");

                        myPet.PetRunsAwayScenario();

                        myPet.FoodDecrease();
                        myPet.FoodDecrease();
                        myPet.FoodDecrease();
                    }
                    else if (myPet.ReadWater() > 29)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Your pet despeartely needs water! As a result:");

                        myPet.PetRunsAwayScenario();

                        myPet.WaterDecrease();
                        myPet.WaterDecrease();
                    }
                    else if (myPet.ReadExercise() > 28 || myPet.ReadDesctruction() > 29)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Your pet has been greatly neglected; it desperately needs exercise. Thus:");

                        myPet.PetRunsAwayScenario();

                        myPet.ExerciseDecrease();
                    }

                    //creates space between iteration and also between asking for pet name and stat display
                    Console.WriteLine();

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

                    //record user choice
                    userOption = Console.ReadLine();

                //Create space between menu and user options
                Console.WriteLine();

                    //create a random number generator that will randomly call Tick()
                    Random RandomGenerator = new Random();
                    int randomNum = RandomGenerator.Next(0, 3);

                    if (!int.TryParse(userOption, out selectedOption))
                    {
                        Console.WriteLine("Invalid entry!");

                        myPet.Tick(1);

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                    else if (randomNum == 2)
                    {
                        Console.WriteLine();
                        myPet.Tick(selectedOption);

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }

                    else if (int.TryParse(userOption, out selectedOption))
                    {
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
                                myPet.ExerciseIncrease();

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

                                Console.WriteLine("It was lovely to meet you. " + petName + " will greatly miss you. We hope you will return soon!");
                                break;

                            default:

                                Console.WriteLine("Invalid option selected.");
                                break;
                        }

                    //pauses screen after response to user, and they have to push a key to keep going
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                } // is the ending of the else if statement that the program runs if tick isn't called.
                
               else { } // need an empty else statement to end the conditionals if don't have anything to put in it?

                    ctr++; // keep track of how many times the loop has cyled through.

                    //create space between each iteration for readability
                    Console.WriteLine();

                } while (selectedOption != 10);


        }
    }
}
