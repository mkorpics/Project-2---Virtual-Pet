using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
    {
        //Set fields to private here so only the VirtualPet class can modify them directly
        private string name;
        private int food;
        private int water;
        private int exercise;
        private int sleep;
        private int destruction;

        //create default constructor with set values
        public VirtualPet()
        {
            this.name = "Morgan";
            this.food = 15;
            this.water = 0;
            this.exercise = 5;
            this.sleep = 0;
            this.destruction = 10;
        }

        //This constructor requires input for name, but otherwise sets all of the stats (fields) for the pet.
        public VirtualPet(string name)
        {
            this.name = name;
            this.food = 15;
            this.water = 3;
            this.exercise = 5;
            this.sleep = 5;
            this.destruction = 10;
        }

        //This constructor allows values to be set individually for all of the stats (fields)
        public VirtualPet(string name, int food, int water, int exercise, int sleep, int destruction)
        {
            this.name = name;
            this.food = food;
            this.water = water;
            this.exercise = exercise;
            this.sleep = sleep;
            this.destruction = destruction;
        }

        //Methods regarding food - giving value, increasing, decreasing
        //this method can be called to read the current status of food
        public int ReadFood()
        {
            return food;
        }

        //this method can be called to increase the food
        public void FoodIncrease()
        {
            this.food = food + 2;
        }

        //this method can be called to decrease the food
        public void FoodDecrease()
        {
            this.food = food - 3;
        }


        //Methods regarding water - giving value, increasing, decreasing
        //this method can be called to read the current status of water
        public int ReadWater()
        {
            return water;
        }

        //this method can be called to increase the water.
        public void WaterIncrease()
        {
            this.water = water + 1;
        }

        //this method can be called to decrease the water.
        public void WaterDecrease()
        {
            this.water = water - 4;
        }

        //Methods regarding exercise - giving value, increasing, decreasing
        //this method can be called to read the current status of exercise
        public int ReadExercise()
        {
            return exercise;
        }

        //this method can be called to increase exercise
        public void ExerciseIncrease()
        {
            this.exercise = exercise + 5;
        }

        //this method can be called to decrease exercise
        public void ExerciseDecrease()
        {
            this.exercise = exercise - 3;
        }


        //Methods regarding sleep - giving value, increasing, decreasing
        //this method can be called to get the value of sleep
        public int ReadSleep()
        {
            return sleep;
        }

        //this method can be called to increase sleep
        public void SleepIncrease()
        {
            this.sleep = sleep + 2;
        }

        //this method can be called to decrease sleep
        public void SleepDecrease()
        {
            this.sleep = sleep - 5;
        }

        //Methods regarding destruction - giving value, increasing, decreasing
        //this method can be called to get the value of destruction
        public int ReadDesctruction()
        {
            return destruction;
        }

        //this method can be called to increase destruction
        public void DestructionIncrease()
        {
            this.destruction = destruction + 2;
        }

        //this method can be called to decrease destruction for general situations
        public void DestructionDecreaseGeneral()
        {
            this.destruction = destruction - 1;
        }

        //this method can be called to decrease for wilderness release
        public void DestructionDecreaseWilderness()
        {
            this.destruction = destruction - 8;
        }
           

        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine(); //space between name and stats
            Console.WriteLine("Food: \t\t" + food);
            Console.WriteLine("Water: \t\t" + water);
            Console.WriteLine("Exercise: \t" + exercise);
            Console.WriteLine("Sleep: \t\t" + sleep);
            Console.WriteLine("Destruction: \t" + destruction);
        }

        //This method can be called print centered text strings
        public void PrintCenter (string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }

        //This method can be called to run the scenari where the neighbor asks user to watch her dragon
        public void WatchNeighborDragon()
        {
            //set up scenario
            Console.WriteLine("This afternoon your neighbor called you.");
            Console.WriteLine("She's going out of town for a few days, and she wants to know if you will watch her dragon for her.");
            Console.WriteLine("What are you going to tell her?");

            //user menu options
            Console.WriteLine("\r\n\r\n1. Yes");
            Console.WriteLine("2. No");

            string userOption = Console.ReadLine();
            int selectedOption;

            //create space
            Console.WriteLine();
            Console.WriteLine();

            if(!int.TryParse(userOption, out selectedOption))
            {
                Console.WriteLine("Invalid input. You have automatically selected \"yes\".");
                selectedOption = 1;
            }
            else
            {
                int.TryParse(userOption, out selectedOption);
            }

            //Random number generator
            Random RandomGenerator = new Random();
            int randomNum;

            switch(selectedOption)
            {
                //user selected yes
                case 1:

                    randomNum = RandomGenerator.Next(1, 2);

                    if (randomNum==1)
                    {
                        Console.WriteLine("The two dragons get along... too well, as a matter of face.");
                        Console.WriteLine("They might be having fun, but keeping up with them makes you look like the walking dead!");

                        destruction = 3;
                        exercise = 2;
                        FoodIncrease();
                        WaterIncrease();
                        SleepIncrease();
                    }

                    else
                    {
                        Console.WriteLine("I can't say that they were the best of friends...");
                        Console.WriteLine("The fire department says the insurance company might be able to help out,");
                        Console.WriteLine("but considering the extent of the damage - to your community reputation if nothing else - it might be time to consider relocating. Perhaps to Timbuktu.");

                        destruction = 2;
                        exercise = 2;
                        FoodIncrease();
                        WaterIncrease();
                        SleepIncrease();
                    }

                    break;
            
                //user selected no
                case 2:

                    randomNum = RandomGenerator.Next(1, 2);

                    //values don't change for these, because the dragon doesn't do anything
                    if(randomNum==1)
                    {
                        Console.WriteLine("You feel a bit guilty for refusing, at least at first.");
                        Console.WriteLine("After watching what happened to the person who ended up taking the job, that feeling entirely vanished.");
                        Console.WriteLine("Your guilt began to dissipate after watching the Dragon Patrol rush by a few times.");
                        Console.WriteLine("A week of watching them entirely erased any lingering sense of neighborly obligation.");
                    }

                    else
                    {
                        Console.WriteLine("Looks like she found someone else.");
                        Console.WriteLine("Unfortunately for you, that someone else wasn't quite up to the task...");
                        Console.WriteLine("The destruction wreaked by your neighbor's out of control dragon was, well, remarkable.");
                        Console.WriteLine("In the end, though, you may have lost everything else,");
                        Console.WriteLine("but at least you still have your dragon!");
                    }
                    break;

                    default:
                    Console.WriteLine("Invalid info");
                    break;

            }
        }
        
        //This method can be called to run the "Pet runs away" scenario
        public void PetRunsAwayScenario()
        {
            Console.WriteLine("This morning you walked outside, eager to greet your beloved dragon. \r\nExcept when you got there, there was no dragon. \r\nYou called and searched around your property; he would have come if he heard you! \r\nWhat would you like to do?");
            Console.WriteLine("1. Call Dragon Patrol");
            Console.WriteLine("2. Search on your own");
            Console.WriteLine("3. Adopt a new dragon");

            int selectedOption = int.Parse(Console.ReadLine());

            Random RandomGenerator = new Random();
            int randomNum;

            switch (selectedOption)
            {
                case 1:
                    randomNum = RandomGenerator.Next(1, 5);
                    if (randomNum == 1)
                    {
                        Console.WriteLine("You're in luck! \r\nThey have already located your dragon.");
                        Console.WriteLine("It appears he randomly took fright at a particularly vicious chihuahua while out and about and was hiding in a tree.");
                        Console.WriteLine("It turned out well this time, but make sure to keep a closer eye on your dragon!");
                    }
                    else if (randomNum == 2)
                    {
                        Console.WriteLine("I've got to give it to you for persistence.");
                        Console.WriteLine("You and the dragon patrol searched valiantly for 5 months");
                        Console.WriteLine("You did all the search posters, social media posts, calls to shelters, the whole nine yards...");
                        Console.WriteLine("I really hate to tell you this after all the time and effort,");
                        Console.WriteLine("but it seems that your dragon is exceptionally clever, even among dragons");
                        Console.WriteLine("In other words, too smart for them to catch, despite an impressive array of attempts.");
                        Console.WriteLine("From all reports, your dragon appears to be thriving on his independent lifestyle.");
                        Console.WriteLine("Luck of the draw, I guess.");
                        Console.WriteLine("Well, it was lovely playing with you. Please come back again if you would like to try your hand with a new pet!");

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else if (randomNum == 3)
                    {
                        Console.WriteLine("Let it be said only that, well, shots were fired.");
                        Console.WriteLine("It seems as though they believed your dragon posed a threat to society.");
                        Console.WriteLine("It didn't end overly well this time, but if you'd like to try your hand with a second dragon please come again soon!");

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else if (randomNum ==4)
                    {
                        Console.WriteLine("Wow. You have an impressively lazy dragon.");
                        Console.WriteLine("I really think calling Dragon Patrol was overdoing it.");
                        Console.WriteLine("I mean, he barely got outside the town limits before he decided to nap.");
                        Console.WriteLine("In the middle of a farmer's field. In broad daylight.");
                        Console.WriteLine("Incredible.");
                    }
                    else
                    {
                        Console.WriteLine("Well, it was close.");
                        Console.WriteLine("They found him in the act of what seemed to be a vicious act.");
                        Console.WriteLine("Fortunately, a bystander who just so happens to study dragons was there to inform them that" + name+ "was merely trying to engage a dog in a game of fetch.");
                        Console.WriteLine("Next time you might not be so lucky, so take better care!");
                    }

                        //Values changed by excursion
                        FoodIncrease();
                        WaterIncrease();
                        SleepIncrease();
                        ExerciseDecrease();
                        ExerciseDecrease();
                    DestructionDecreaseGeneral();

                    Console.WriteLine();
                    Console.WriteLine("\r\nPress any key to continue");
                    Console.ReadKey();
                    Console.WriteLine();
                    break;
                   
                case 2:
                    randomNum = RandomGenerator.Next(1, 3);

                    if (randomNum == 1)
                    {
                        Console.WriteLine("Oh, you're back!");
                        Console.WriteLine("I was wondering what happened to you. I haven't seen you in a week.");
                        Console.WriteLine("You look terrible! Where have you been?");
                        Console.WriteLine("What? Bushwacking?");
                        Console.WriteLine("Lost in the wilderness and chased by wolves?");
                        Console.WriteLine("What on earth possessed you to do such a thing?");
                        Console.WriteLine("Oh, " + name + "?");
                        Console.WriteLine("But he's been here the whole time.");
                    }
                    else if (randomNum ==2)
                    {
                        Console.WriteLine("Good thing you chose to go out and search!");
                        Console.WriteLine("You found your dragon just when it was about to eat Mrs. McGillicutty's horse...with her on it!");
                        Console.WriteLine("Of course, he just didn't notice her in his excitement (he would never deliberately attack a human) \r\nbut that wouldn't have changed the outcome much.");
                        Console.WriteLine("Can you imagine the lawsuit?");
                    }
                    else
                    {
                        Console.WriteLine("Well...I'm not really sure what to say.");
                        Console.WriteLine("Congratulations?");
                        Console.WriteLine("...");
                        Console.WriteLine("You know how hard it is to tell a dragon's gender - virtually impossible.");
                        Console.WriteLine("But I guess we know now.");
                        Console.WriteLine("Who would have ever guessed that she would go off on her own to have babies?");
                        Console.WriteLine("All I can say is, you better find them homes before they get much bigger and need fire-control training!");

                    }
                    //Values changed by excursion
                    FoodIncrease();
                    WaterIncrease();
                    SleepIncrease();
                    ExerciseDecrease();
                    ExerciseDecrease();
                    DestructionDecreaseGeneral();

                    Console.Write("\r\nPress any key to continue");
                    Console.ReadKey();
                    Console.WriteLine();
                    break;

                case 3:
                    
                    Console.WriteLine("Really? You want to give up just like that?");
                    Console.WriteLine("I must say I'm rather surprised.");
                    Console.WriteLine("I guess sometimes it's just not meant to be.");
                    Console.WriteLine("Unfortunately, I don't have any available dragons at the moment, but come back soon, and I'll see if I have any available!");
                    Console.WriteLine("See you soon!");

                    Console.WriteLine("\r\nPress any key to continue");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }

        }

        //This method can be called to run the Sick pet scenario
        public void SickPetScenarioGeneral()
        {
            Console.WriteLine("It was a long, exhausting day. You have re-discovered how frustrating people can be.");
            Console.WriteLine("Unfortunately, your day is not over yet.");
            Console.WriteLine("When you went to check on your dragon this evening, something was most definitely not right.");
            Console.WriteLine(name + "is clearly not feeling well.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine();

            Console.WriteLine("\r\n1. Take your dragon to the vet");
            Console.WriteLine("2. Wait it out");
            Console.WriteLine();

            int selectedOption = int.Parse(Console.ReadLine());

            Random RandomGenerator = new Random();
            int randomNum;

            switch (selectedOption)
            {
                //took to vet
                case 1:

                    randomNum = RandomGenerator.Next(1,3);

                    if(randomNum ==1 )
                    {
                        Console.WriteLine("I hate to be the bearer of bad news.");
                        Console.WriteLine("It seems your dragon has a particularly deadly strain of Draco Ignis.");
                        Console.WriteLine("I hope you can treasure the memories of your time together.");
                        Console.WriteLine("Take your time, and when you feel ready, I hope you'll come back and adopt a new dragon friend!");

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else if (randomNum ==2)
                    {
                        Console.WriteLine("It involved dangerous expeditions to the heights of cold, forbidding mountains and to the depths of dark, unwholesome caverns");
                        Console.WriteLine("You have survived, however, despite the odds, and are now in possession of all of the ingredients for the potion");
                        Console.WriteLine("The vet did look a bit surprised when you returned with all of the items");
                        Console.WriteLine("but rest assured, your dragon should be just fine!");
                        
                        //values change
                        SleepIncrease();
                        SleepIncrease();
                        WaterIncrease();
                        ExerciseDecrease();
                        ExerciseDecrease();
                    }
                    else
                    {
                        Console.WriteLine("Luckily, it looks like the ganglius of a newt proved particularly effective in riddle your dragon of its malady.");
                        Console.WriteLine("You may happily continue on your way now!");

                        //values change
                        SleepIncrease();
                        SleepIncrease();
                        WaterIncrease();
                        ExerciseDecrease();
                        ExerciseDecrease();
                    }

                    Console.WriteLine();
                    Console.Write("\r\nPress any key to continue");
                    Console.ReadKey();
                    Console.WriteLine();

                    break;

                //waited it out
                case 2:
                    randomNum = RandomGenerator.Next(1,3);

                    if (randomNum ==1)
                    {
                        Console.WriteLine("You waited for a few days, but there was no improvement.");
                        Console.WriteLine("You took your dragon to the vet.");
                        Console.WriteLine("Sorry. You waited to long...");
                        Console.WriteLine("When you feel ready for a new dragon, please come again!");

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("You waited for two days, and he eventually coughed up a few wheelbarrow loads of suspicious content.");
                        Console.WriteLine("You probably don't want to know. I know I don't!");

                        //values change
                        SleepIncrease();
                        SleepIncrease();
                        WaterIncrease();
                        ExerciseDecrease();
                        ExerciseDecrease();
                    }

                    Console.WriteLine();
                    Console.Write("\r\nPress any key to continue");
                    Console.ReadKey();
                    Console.WriteLine();

                    break;
            }



        }

        public void SickPetOverfed()
        {
            Console.WriteLine("You have seriously overfed your dragon!");
            Console.WriteLine("It doesn't look like "+name+ " is doing well.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("\r\n1. Take your dragon to the vet");
            Console.WriteLine("2. Wait it out");
            Console.WriteLine();

            int selectedOption = int.Parse(Console.ReadLine());

            Random RandomGenerator = new Random();
            int randomNum;

            switch (selectedOption)
            {
                //took to vet
                case 1:

                    randomNum = RandomGenerator.Next(1, 3);

                    if (randomNum == 1 || randomNum == 2)
                    {
                        Console.WriteLine("The vet immediately pumped your dragon's stomach. It was a good thing you acted so quickly!");
                        Console.WriteLine("That being said, it took quite a lot of engineering to figure out how to get (and make!) equipment to pump a dragon's stomach.");
                        Console.WriteLine("You do not want to know the bill.");
                        Console.WriteLine("Make sure you never make this mistake again.");
                        Console.WriteLine("The bank won't let you!");

                        //values change
                        SleepIncrease();
                        SleepIncrease();
                        WaterIncrease();
                        ExerciseDecrease();
                        ExerciseDecrease();
                        food = 10;
                    }
                    else
                    {
                        Console.WriteLine("You do not want to know the details, but suffice it to say, it was too late.");
                        Console.WriteLine("Seriously, though, how much did you feed that thing?");
                        Console.WriteLine("I think you need to take some time to reflect on your actions.");
                        Console.WriteLine("Once you think you are more prepared for the responsibilities of dragon raising, please return!");

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                    Console.WriteLine();
                    Console.Write("\r\nPress any key to continue");
                    Console.ReadKey();
                    Console.WriteLine();

                    break;

                //waited it out
                case 2:
                    randomNum = RandomGenerator.Next(1, 2);

                    if (randomNum ==1 )
                    {
                        Console.WriteLine("Well, you didn't overdo it all that much this time.");
                        Console.WriteLine("It took a few days, but your dragon will be fine.");
                        Console.WriteLine("If you care for your dragon, though, please make sure not to make this same mistake again!");

                        //values change
                        SleepIncrease();
                        SleepIncrease();
                        WaterIncrease();
                        ExerciseDecrease();
                        ExerciseDecrease();
                        food = 10;
                    }
                    else
                    {
                        Console.WriteLine("I don't think I want to go into too many details.");
                        Console.WriteLine("Let's just say it was coming out both ends,");
                        Console.WriteLine("and you were the one on cleanup crew.");
                        Console.WriteLine("It is your dragon after all.");
                        Console.WriteLine("All I can say is, I hope you learned your lesson!");

                        //values change
                        SleepIncrease();
                        SleepIncrease();
                        WaterIncrease();
                        ExerciseDecrease();
                        ExerciseDecrease();
                        food = 10;
                    }

                    Console.WriteLine();
                    Console.Write("\r\nPress any key to continue");
                    Console.ReadKey();
                    Console.WriteLine();

                    break;
            }

        }

        //This method can be called to invoke a hibernation scenario for when the dragon needs sleep or gets too much sleep, exercise, or destruction
        public void HibernationScenario()
        {
            Random RandomGenerator = new Random();
            int randomNum;

            Console.WriteLine("Your dragon has collected all of the valuables in your house,");
            Console.WriteLine("hoarded them in a giant pile in your driveway,");
            Console.WriteLine("curled up on top of them");
            Console.WriteLine("and gone to sleep.");
            Console.WriteLine("\r\nNormal dragon hibernation lasts about 50 years...");
            Console.WriteLine("(Really a situation to avoid at all costs)");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine();

            Console.WriteLine("1. Try to wake your dragon up");
            Console.WriteLine("2. Let your dragon sleep");

            string userOption;
            int selectedOption;

            userOption = Console.ReadLine();

            //check to make sure that user input was a number
            if(!int.TryParse(userOption, out selectedOption))
            {
                Console.WriteLine("Invalid Entry. By default, you have chosen to let your dragon sleep.");
                selectedOption = 2;
            }
            else
            {
                int.TryParse(userOption, out selectedOption);
            }

            //filter results through possible outcomes
            switch (selectedOption)
            {
                //chose to try to wake it up
                case 1:

                    randomNum = RandomGenerator.Next(1, 3);

                    if(randomNum ==1)
                    {
                        Console.WriteLine("You should know never to try to wake a hibernating dragon!");
                        Console.WriteLine("Your dragon remains in hibernation.");
                        Console.WriteLine("Your life, however, burned bright and beautiful \r\nand is now, I am sad to say, over.");

                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                    else if (randomNum == 2)
                    {
                        Console.WriteLine("Don't you know how dangerous it is to try to wake a hibernating dragon?!");
                        Console.WriteLine("Fortunately for you, it just so happened that his nap was sufficient.");
                        Console.WriteLine("He is now awake, and you may resume your normal lives...after retrieving your valuables of course!");
                    }
                    else
                    {
                        Console.WriteLine("I don't know whether to be impressed at your daring or appalled at your stupidity for trying to wake a hibernating dragon.");
                        Console.WriteLine("Well, in any case, your efforts failed.");
                        Console.WriteLine("You may as well count your valuables and your driveway as lost.");
                        Console.WriteLine("No one else is stupid enough to touch a hibernating dragon!");
                        Console.WriteLine("I just hope you still have enough energy to take care of him in 50 years!");
                    }

                    sleep = 5;

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();

                    break;

                //chose to let it sleep
                case 2:

                    Console.WriteLine("You made a wise choice!");
                    Console.WriteLine("Bad things happen to those who try to interfere with sleeping dragons");
                    Console.WriteLine("It may be 50 years without a driveway");
                    Console.WriteLine("and you may have to replace or do without all of your valuables,");
                    Console.WriteLine("but at least you can reunite with your dragon in the end!");

                    sleep = 5;

                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    break;

                default:

                    Console.WriteLine("Invalid Information");

                    break;
            }

        }

        //This method can be called to check for stats going over or under the health limits and responding accordingly
        public void StatConsequences()
        {
            //food
            if (food < -3)
            {
                Console.ReadKey();
                Console.Clear();
                SickPetOverfed();
            }

            else if (food > 29)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your pet despeartely needs food! The consequence:");

                PetRunsAwayScenario();

                food = 10;
            }

            //water
            else if (water > 28)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your pet despeartely needs water! As a result:");

                PetRunsAwayScenario();

                water = 5;
            }

            else if (water < -5)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You have severely over-watered your dragon!");
                Console.WriteLine("As a result, your dragon has become waterlogged and is unable to fly.");
                Console.WriteLine("In other words, he'll need plenty of exercise once some of the water weight eases!");

                water = 0;
                ExerciseIncrease();
                ExerciseIncrease();
                DestructionIncrease();
                SleepDecrease();

                Console.WriteLine();
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.WriteLine();
            }

            //exercise
            else if (exercise > 29)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your pet has been greatly neglected; it desperately needs exercise. Thus:");

                PetRunsAwayScenario();

                exercise = 10;
            }

            else if (exercise < -5)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You have exercised your dragon unto exhaustion. " + name + " will now enter hibernation.");

                HibernationScenario();

                exercise = 8;
            }

            //sleep
            else if (sleep > 28)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your dragon has been sleep deprived and will now enter hibernation.");

                HibernationScenario();
            }

            else if (sleep <-5)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your dragon has received so much sleep that it triggered hibernation.");

                HibernationScenario();
            }

            //destruction
            else if (destruction > 28)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your dragon has been forced to suppress its destructive urges.");
                Console.WriteLine("I do not envy you the consequences: ");

                    Console.WriteLine("\r\nThis is a letter from your local fire department informing you of the consequences from your dragon's recent raid.");
                    Console.WriteLine("\r\nWe were so busy putting out the fire at our own firehouse");
                    Console.WriteLine("that the town hall burnt down as well as the grocery store");
                    Console.WriteLine("and our favorite ice cream store.");
                    Console.WriteLine("\r\nThis is your final warning.");
                    Console.WriteLine("If you don't control your dragon,");
                    Console.WriteLine("your dragon license will be suspended,");
                    Console.WriteLine("and Dragon Control will come to take your dragon into custody.");
                    Console.WriteLine("\r\nRegards,");
                    Console.WriteLine("Your local fire department");

                destruction = 10;

                    Console.WriteLine();
                    Console.WriteLine("Please press any key to continue");
                    Console.ReadKey();
                    Console.WriteLine();

                //I had tried to set up a counter to give subsequent responses if went over more than once, but since it was calling it anew each time, it wasn't working.
                //Is there a good way to fix this problem?
                //I thought of having it return the counter value, but that came with its own set of issues. Is that how I'd have to approach it or is there another way?
                //else if (ctr ==1)
                //{
                //    Console.WriteLine("\r\nThis is a letter from your local fire department regarding the consequences from your dragon's subsequent raid.");
                //    Console.WriteLine("\r\nWe find a recounting of all the damages to be redundant at this point.");
                //    Console.WriteLine("\r\nWe already informed you of the consequences.");
                //    Console.WriteLine("Your dragon license has been revoked.");
                //    Console.WriteLine("Dragon Control will take your dragon into custody not later than noon tomorrow.");
                //    Console.WriteLine("\r\nRegards,");
                //    Console.WriteLine("Your local fire department");

                //    Console.WriteLine();
                //    Console.WriteLine("Please press any key to continue");
                //    Console.ReadKey();
                //    Environment.Exit(0);
                //}
            }
            
            else if (destruction < -5)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Your dragon's energy has been so deeply depleted that it will now enter hibernation to recover.");

                HibernationScenario();

                destruction = 5;
            }
    }


            public void Tick(int selectedOption)
        {
            Random RandomGenerator = new Random();
            int randomNum = RandomGenerator.Next(1, 4);

            if (randomNum == 3 ) //pet won't obey
            {
                //preface text to pet's disobedience
                Console.WriteLine("One of the travails of being a pet owner:");
                Console.WriteLine("Uncooperative pets!");

                switch (selectedOption)
                {
                    //feed cattle
                    case 1:

                        Console.WriteLine(name+ " has decided not to eat.");
                        FoodIncrease();

                        break;

                    //lake
                    case 2:

                        Console.WriteLine(name +" doesn't feel like going down to the lake.");

                        WaterIncrease();

                        break;

                    //fly
                    case 3:

                        Console.WriteLine(name +" would rather take a nap.");

                        ExerciseIncrease();
                        SleepDecrease();

                        break;

                    //play
                    case 4:

                        Console.WriteLine(name + " is blatantly ignoring you.");

                        ExerciseIncrease();

                        break;

                    //wildlands
                    case 5:

                        Console.WriteLine(name + " doesn't want to go out right now.");

                        DestructionIncrease();

                        break;
                    
                    //sleep
                    case 6:

                        Console.WriteLine(name+ " wants to play! Who needs sleep?");

                        SleepIncrease();

                        break;
                    
                    //barbeque
                    case 7:

                        Console.WriteLine("Better go apologize to your friends! " + name+ " has disappeared.");

                        FoodIncrease();
                        ExerciseDecrease();

                        break;

                    //Exit program
                    case 10:

                        Console.WriteLine("What? Already?");
                        Console.WriteLine("Well, it was a pleasure; we hope you come back soon!");
                        Environment.Exit(0);
                        break;
                }
            }

           else if (randomNum == 2) // pet will do something random
                {
                Console.WriteLine();

                int randomAct = RandomGenerator.Next(1,6);

                    switch (randomAct)
                    {
                    //Food - eats
                    case 1:

                        Console.WriteLine("I guess your pet felt like having a nice big snack.");
                        Console.WriteLine("Were those sheep?");
                        Console.WriteLine("Well, whatever they were, hopefully no one's missing them too much!");

                        FoodDecrease();
                        WaterIncrease();

                        break;

                    //Water - drinks
                    case 2:

                        Console.WriteLine("Your dragon developed a sudden urge to visit the lake");
                        Console.WriteLine("There was splashing and rolling and wave-making (can you call it that when the tidal-like waves nearly emptied the lake of water?)");
                        Console.WriteLine("You have decided to look innocent when others discuss the near-empty lake and hope that it rains soon!");

                        WaterDecrease();
                        FoodIncrease();

                        break;

                    //Exercise - performs activity
                    case 3:

                        Console.WriteLine(name + " had a sudden urge to set out for a little stroll.");
                        Console.WriteLine("One thing led to another");
                        Console.WriteLine("You decided to worry when you saw Dragon Patrol go soaring past.");
                        Console.WriteLine("In the end, though, " + name + " returned, and you decided not to ask too many questions...");

                        ExerciseDecrease();
                        ExerciseDecrease();
                        WaterIncrease();
                        FoodIncrease();
                        SleepIncrease();

                        break;

                    //Sleep - sleeps
                    case 4:

                        Console.WriteLine("Looks like " +name+" decided it's nap time!");

                        SleepDecrease();
                        FoodIncrease();
                        WaterIncrease();
                        ExerciseIncrease();
                        DestructionIncrease();

                        break;

                    //Destruction - rampages
                    case 5:
                    case 6:

                        Console.WriteLine("One of the downsides of dragons: destructive urges.");
                        Console.WriteLine("There was some fire. A bit of trampling.");
                        Console.WriteLine("Some ripping and rending.");
                        Console.WriteLine("You aren't sure whether or not to be glad that most of it occurred on your own property...");
                        Console.WriteLine("Thank goodness for dragon insurance!");
                        Console.WriteLine("Even if the premiums are about to soar.");

                        ExerciseDecrease();
                        DestructionDecreaseWilderness();
                        FoodIncrease();
                        WaterIncrease();

                        break;
                    }

            }

           else //pet will evaluate stats and do the most necessary thing
            {
                Console.WriteLine("Your pet has decided to take care of its own needs.");
                int[] petStats = { food, water, exercise, sleep, destruction };
                int[] dummyStats = { food, water, exercise, sleep, destruction };
                Array.Sort(dummyStats);

                int index = Array.IndexOf(petStats, dummyStats[4]);

                switch (index)
                {
                    //Food highest
                    case 0:

                        Console.WriteLine("It has decided to find some fish to feast on. Better hope it catches its own instead of bothering the fishermen!");

                        FoodDecrease();
                        WaterIncrease();
                        ExerciseIncrease();
                        SleepIncrease();

                        break;

                    //Water highest
                    case 1:

                        Console.WriteLine("If you need to find " + name + " head on down to the lake.");

                        WaterDecrease();
                        DestructionIncrease();

                        break;

                    //Exercise highest
                    case 2:

                        Console.WriteLine(name+" is off on a dragon adventure.");
                        Console.WriteLine("In other words, " + name + " is off flying around, scaring sheep, trying to play with other dragons and generally creating good-natured mayhem.");

                        ExerciseDecrease();
                        DestructionDecreaseGeneral();
                        FoodIncrease();
                        SleepIncrease();
                        WaterIncrease();

                        break;

                    //Sleep highest
                    case 3:

                        Console.WriteLine("Looks like "+name+" is out cold. Better come back in a few hours. That nap looks like it's gonna be a long one!");

                        SleepDecrease();
                        FoodIncrease();
                        WaterIncrease();
                        ExerciseIncrease();

                        break;

                    //Destruction highest
                    case 4:

                        Console.WriteLine("You, love, have the best dragon that ever was.");
                        Console.WriteLine("Not many dragons would be so considerate as to find such a remote place to vent fire and chaos upon the land.");

                        ExerciseDecrease();
                        DestructionDecreaseWilderness();
                        FoodIncrease();
                        WaterIncrease();
                        SleepIncrease();

                        break;
                }
            }
        }





        }

            


        




}
   
