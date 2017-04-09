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
            this.name = "";
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
            this.water = 0;
            this.exercise = 5;
            this.sleep = 0;
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
            this.exercise = exercise + 4;
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
                        Console.WriteLine("Would you like to adopt a new dragon? Maybe it would go better this time...");

                        //set to go back to beginning or exit
                    }
                    else if (randomNum == 3)
                    {
                        Console.WriteLine("Let it be said only that, well, shots were fired.");
                        Console.WriteLine("It seems as though they believed your dragon posed a threat to society.");
                        Console.WriteLine("I don't want to be presumptuous, but would you like a new pet?");
                        //figure out how to reset program from here! Or close out.
                    }
                    else if (randomNum ==4)
                    {
                        Console.WriteLine("Wow. You have an impressively lazy dragon.");
                        Console.WriteLine("I really think calling Dragon Patrol was overdoing it.");
                        Console.WriteLine("I mean, he barely got outside the town limits before he decided to nap.");
                        Console.WriteLine("In the middle of a farmer's field. In broad daylight.");
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

                        Console.WriteLine("\r\nPress any key to continue");
                        Console.ReadKey();
                    break;
                   
                case 2:
                    randomNum = RandomGenerator.Next(1, 3);

                    if (randomNum == 1)
                    {
                        Console.WriteLine("Oh, you're back!");
                        Console.WriteLine("I was wondering where you've been. I haven't seen you in a week.");
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
                        Console.WriteLine("Of course, he just didn't notice her standing next to it, but that wouldn't have changed the outcome much.");
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

                    Console.WriteLine("\r\nPress any key to continue");
                    Console.ReadKey();
                    break;

                case 3:
                    
                    Console.WriteLine("Really? You want to give up just like that?");
                    Console.WriteLine("I must say I'm rather surprised.");
                    Console.WriteLine("I guess sometimes it's just not meant to be.");
                    Console.WriteLine("I suppose I should offer you a chance to try again.");
                    Console.WriteLine("Would you like to see if you bond more with a new pet?");

                    //give option to quit or get new pet

                    Console.WriteLine("\r\nPress any key to continue");
                    Console.ReadKey();
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

            Console.WriteLine("\r\n1. Take your dragon to the vet");
            Console.WriteLine("2. Wait it out");

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
                        Console.WriteLine("Is it too early for me to ask? Well, I'll get to the point.");
                        Console.WriteLine("Would you like a new dragon?");

                        //option to restart
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
                    break;

                //waited it out
                case 2:
                    randomNum = RandomGenerator.Next(1,2);

                    if (randomNum ==1)
                    {
                        Console.WriteLine("You waited for a few days, but there was no improvement.");
                        Console.WriteLine("You took your dragon to the vet.");
                        Console.WriteLine("Sorry. You waited to long...");
                        Console.WriteLine("New dragon?");
                    //Give option to restart program
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

            int selectedOption = int.Parse(Console.ReadLine());

            Random RandomGenerator = new Random();
            int randomNum;

            switch (selectedOption)
            {
                //took to vet
                case 1:

                    randomNum = RandomGenerator.Next(1, 2);

                    if (randomNum == 1)
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
                    }
                    else
                    {
                        Console.WriteLine("You do not want to know the details, but suffice it to say, it was too late.");
                        Console.WriteLine("Seriously, though, how much did you feed that thing?");
                        Console.WriteLine("I'm not sure I should offer after this, but do you want a new dragon?");

                        //option to re-run
                    }

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
                    }
                    break;
            }

        }

            public void Tick(int selectedOption)
        {
            Random RandomGenerator = new Random();
            int randomNum = RandomGenerator.Next(1, 3);

            if (randomNum == 3 ) //pet won't obey
            {
                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("");
                        FoodIncrease();
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine();
                        break;
                    case 10:
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                }
            }

           else if (randomNum == 2) // pet will do something random
                {
                    int randomAct = RandomGenerator.Next(1,10);

                    switch (randomAct)
                    {
                    case 1:
                        FoodIncrease();
                        break;
                    case 2:
                        FoodDecrease();
                        break;
                    case 3:
                        WaterIncrease();
                        break;
                    case 4:
                        WaterDecrease();
                        break;
                    case 5:
                        ExerciseIncrease();
                        break;
                    case 6:
                        ExerciseDecrease();
                        break;
                    case 7:
                        SleepIncrease();
                        break;
                    case 8:
                        SleepDecrease();
                        break;
                    case 9:
                        DestructionIncrease();
                        break;
                    case 10:
                        DestructionDecreaseGeneral();
                        break;
                    }

            }

           else //pet will evaluate stats and do the most necessary thing
            {
                Console.WriteLine("Your pet has decided to take care of its own needs for once!");
                int[] petStats = { food, water, exercise };
                int[] dummyStats = { food, water, exercise };
                Array.Sort(dummyStats);

                int index = Array.LastIndexOf(petStats, dummyStats[0]);

                switch (index)
                {
                    case 0:
                        FoodDecrease();
                        break;
                }
            }
        }





        }

            


        




}
   
