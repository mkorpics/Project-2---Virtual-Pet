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
            //create a pet to use as an object for calling PrintCenter() 
            //Is there a better way to do this?
            VirtualPet aPet = new VirtualPet();

            //Welcome text introducing user to the page.
            string welcome = "Welcome to dragon training!";
            string welcome1 = "Oh, wait, sorry. This isn't Berk.";
            string welcome2 = "What I meant to say was:";
            string welcome3 = "WELCOME TO THE DRAGON HATCHERY";

            //print centered welcome text
            aPet.PrintCenter(welcome);
            aPet.PrintCenter(welcome1);
            aPet.PrintCenter(welcome2);
            aPet.PrintCenter(welcome3);

            //create space
            Console.WriteLine();
            Console.WriteLine();

            //Introduction text - introduces dragons and some of the guidelines
            string intro = "So you want to adopt a dragon.";
            string intro1 = "Before you decide to go through with the adoption";
            string intro2= "there are a few things you should know.";
            string intro3 = "As with other animals, dragons need food, water, exercise and sleep.";
            string intro4 = "In addition, however, dragons have an innate need to...vent.";
            string intro5 = "Basically, they must be allowed to wreak devestation.";
            string intro6 = "Fire and teeth and claws and all that.";
            string intro7 = "Make sure you have a proper wilderness on loan where you can";
            string intro8 = "bring your dragon for this purpose!";
            string intro9 = "It's truly a dreadful thing when our customers try";
            string intro10 = "to keep their dragons pent up.";
            string intro11 = "Truly dreadful. You can't imagine the ... well, enough of that.";

            //print centered intro text
            aPet.PrintCenter(intro);
            aPet.PrintCenter(intro1);
            aPet.PrintCenter(intro2);
            Console.WriteLine();
            aPet.PrintCenter(intro3);
            aPet.PrintCenter(intro4);
            aPet.PrintCenter(intro5);
            aPet.PrintCenter(intro6);
            aPet.PrintCenter(intro7);
            aPet.PrintCenter(intro8);
            Console.WriteLine();
            aPet.PrintCenter(intro9);
            aPet.PrintCenter(intro10);
            aPet.PrintCenter(intro11);

            Console.WriteLine("\r\n\r\n\r\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();

            //guideline text
            string guide = "Just some general things to keep an eye out for:";
            string guide1 = "Your dragon will let you know what he needs.";
            string guide2 = "When he needs something, his levels will rise.";
            string guide3 = "Just make sure you don't let them rise above 25!";
            string guide4 = "You might not like the consequences...";
            string guide5 = "When his needs are met, his levels will sit around 0.";
            string guide6 = "Another word of warning, don't try to push him past what he needs.";
            string guide7 = "If they enter the negatives, beware!";

            //print centered guideline text
            Console.WriteLine();
            aPet.PrintCenter(guide);
            Console.WriteLine();
            aPet.PrintCenter(guide1);
            Console.WriteLine();
            aPet.PrintCenter(guide2);
            aPet.PrintCenter(guide3);
            aPet.PrintCenter(guide4);
            Console.WriteLine();
            aPet.PrintCenter(guide5);
            aPet.PrintCenter(guide6);
            aPet.PrintCenter(guide7);

            Console.WriteLine("\r\n\r\n\r\n\r\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();

            //outro text leading to game
            string last = "Okay, do you want to continue with the adoption?";
            string last1 = "Oh, good. We weren't going to let you escape, anyways!";
            string last2 = "There are so few willing to adopt dragons these days...";
            string last3 = "Well, on to the final question before we send you on your way!";
            string last4 = "What would you like to name your dragon?";

            //print centered outro text
            aPet.PrintCenter(last);
            Console.ReadLine(); //give user chance to "enter" answer, even though it doesn't matter
            Console.WriteLine();
            aPet.PrintCenter(last1);
            aPet.PrintCenter(last2);
            aPet.PrintCenter(last3);
            Console.WriteLine();

            //Get user to name the pet
            aPet.PrintCenter(last4);
            string petName = Console.ReadLine();

            //Wish user and dragon luck
            string sendOff = "Best of luck to you and " + petName + ".";
            string sendOff2 = "We hope the two of you enjoy a long and happy relationship!";

            //print centered send-off text
            Console.WriteLine();
            Console.WriteLine();
            aPet.PrintCenter(sendOff);
            aPet.PrintCenter(sendOff2);

            //instantiate a new instance of the pet
            VirtualPet myPet = new VirtualPet(petName);

            //declare variables that will be used in the do/while loop
            string userOption; //stores which menu option user chooses
            int selectedOption; //stores which menu option the user chooses as an int after TryParse
            int ctr = 0; //will count how many times the loop has run

            //clear screen and enter game
            Console.WriteLine("\r\n\r\n\r\n\r\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();

            do
            {

                //list the alternate scenarios the user will encounter based on the number of times they have cycled through the loop
                if (ctr == 8 || ctr == 34)
                {
                    Console.ReadKey();
                    Console.Clear();
                    myPet.WatchNeighborDragon();

                    Console.WriteLine();
                    Console.WriteLine("\r\nPress any key to continue");
                    Console.ReadKey();
                    Console.WriteLine();
                }

                else if (ctr == 16 || ctr == 44)
                {
                    Console.ReadKey();
                    Console.Clear();
                    myPet.PetRunsAwayScenario();
                }

                else if (ctr == 24|| ctr== 54)
                {
                    Console.ReadKey();
                    Console.Clear();
                    myPet.SickPetScenarioGeneral();
                }

                else
                {
                    //even if there's not any other possible condition, should I have an else statement, even if it's blank?
                }

                //call method that checks to see if stats are too high or two low and respond accordingly
                myPet.StatConsequences();

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

                //Send user to Tick() if their input is invalid
                if (!int.TryParse(userOption, out selectedOption))
                {
                    Console.WriteLine("Invalid entry!");

                    myPet.Tick(1);

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }

                //randomly send user to Tick().
                else if (randomNum == 2)
                {
                    Console.WriteLine();
                    myPet.Tick(selectedOption);

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }

                //Filter user input to appropriate menu option
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
                            Console.WriteLine("Nothing beats a good steak.");
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
                            myPet.ExerciseDecrease();

                            //other values decrease
                            myPet.DestructionDecreaseGeneral();

                            //other values increase
                            myPet.FoodIncrease();
                            myPet.WaterIncrease();
                            myPet.SleepIncrease();

                            //response to user action
                            Console.WriteLine("There's nothing like the feeling of soaring through the sky.");
                            break;

                        //user chooses 4 = play treasure game
                        case 4:

                            myPet.ExerciseDecrease();

                            //other values increase
                            myPet.FoodIncrease();
                            myPet.WaterIncrease();
                            myPet.SleepIncrease();
                            myPet.DestructionIncrease();

                            //response to user action
                            Console.WriteLine("Use that dragon instinct for teasure! \r\n Of course, make sure you stay ahead of him and hide it well. \r\nDragons are remarkably intelligent!");
                            break;

                        //user chooses 5 = wilderness trip
                        case 5:

                            myPet.DestructionDecreaseWilderness();
                            myPet.ExerciseDecrease();
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
                            Console.WriteLine("If you don't have a healthy respect for dragons, you do now!");
                            break;

                        //user chooses 6 = sleep
                        case 6:

                            myPet.SleepDecrease();

                            //other values increase
                            myPet.FoodIncrease();
                            myPet.WaterIncrease();
                            myPet.ExerciseIncrease();
                            myPet.DestructionIncrease();
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
                            Console.WriteLine("Remember the days when barbeques used to be a lot of work? \r\n Gone forever! \r\n\r\nLife is good.");
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
