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
            Console.WriteLine("Food: \t\t" + food);
            Console.WriteLine("Water: \t\t" + water);
            Console.WriteLine("Exercise: \t" + exercise);
            Console.WriteLine("Sleep: \t\t" + sleep);
            Console.WriteLine("Destruction: \t" + destruction);
        }

        //This method can be called to run the "Pet runs away" scenario
        public void PetRunsAwayScenario()
        {
            Console.WriteLine("Oh no! Your pet has run away! \r\nWhat would you like to do?");
            Console.WriteLine("1. Call the pound");
            Console.WriteLine("2. Set up search posters");
            Console.WriteLine("3. Go out and search");

            int selectedOption = int.Parse(Console.ReadLine());

            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine("chose 1");
                    break;
                case 2:
                    Console.WriteLine("chose 2");
                    break;
                case 3:
                    Console.WriteLine("chose 3");
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
                        Console.WriteLine("Uh oh! Looks like your pet is refusing to eat. Better luck next time!");
                        FoodIncrease();
                        break;
                    case 2:
                        break;
                }
            }

           else if (randomNum == 2) // pet will do something random
                {
                    int randomAct = RandomGenerator.Next(0,10);
                    switch (randomAct)
                    {
                        case 1:
                            FoodIncrease();
                            break;
                        case 2:
                            FoodDecrease();
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
   
