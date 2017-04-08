using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
    {
        //We're setting our fields to private here so only the VirtualPet class can modify them directly
        private string name;
        private int hunger;
        private int thirst;
        private int energy;
        private int boredom;

        //TODO fill in more fields

        //this defaut constructor sets options without giving us any options
        public VirtualPet()
        {
            this.name = "Bob";
            this.hunger = 20;
            this.thirst = 20;
            this.energy = 20;
            this.boredom = 20;
            //TODO account for more fields
        }

        public VirtualPet(string name)
        {
            this.name = name;
        }

        //TODO how can we set things with our construtor
        public VirtualPet(string name, int hunger, int sick, int boredom)
        {
            this.name = name;
        }

        //this method can be called to read the current status of hunger
        public int ReadHunger()
        {
            return hunger;
        }

        //this method can be called to increase the hunger
        public void HungerIncrease()
        {
            //TODO modify these values to anything you see fit
            this.hunger = hunger + 3;
        }

        //this method can be called to decrease the hunger
        public void HungerDecrease()
        {
            //TODO modify these values to anything you see fit
            this.hunger = hunger - 5;
        }

        //this method can be called to read the current status of thirst
        public int ReadThirst()
        {
            return thirst;
        }

        //this method can be called to increase the thirst.
        public void ThirstIncrease()
        {
            this.thirst = thirst + 4;
        }

        //this method can be called to decrease the thirst.
        public void ThirstDecrease()
        {
            this.thirst = thirst - 6;
        }

        //this method can be called to read the current status of energy
        public int ReadEnergy()
        {
            return energy;
        }

        //this method can be called to increase energy
        public void EnergyIncrease()
        {
            this.energy = energy + 8;
        }

        //this method can be called to decrease energy
        public void EnergyDecrease()
        {
            this.energy = energy - 10;
        }


        //TODO we need to add more methods to modify the other fields


        //method for stats of virtual pet
        public void MyPetStatus()
        {
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Energy: " + energy);
        }
        //TODO account for more fields

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

            public int[] Tick(int selectedOption, int hunger, int thirst, int energy )
        {

            int[] updatedPetStats = new int[3];

            Random RandomGenerator = new Random();
            int randomNum = RandomGenerator.Next(1, 3);

            if (randomNum == 3 ) //pet won't obey
            {
                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Uh oh! Looks like your pet is refusing to eat. Better luck next time!");
                        HungerIncrease();
                        updatedPetStats[0] = hunger;
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
                            HungerIncrease();
                            updatedPetStats[0] = hunger;
                            break;
                        case 2:
                            HungerDecrease();
                            updatedPetStats[0] = hunger;
                            break;
                    }

            }

           else //pet will evaluate stats and do the most necessary thing
            {
                Console.WriteLine("Your pet has decided to take care of its own needs for once!");
                int[] petStats = { hunger, thirst, energy };
                int[] dummyStats = { hunger, thirst, energy };
                Array.Sort(dummyStats);

                int index = Array.LastIndexOf(petStats, dummyStats[0]);

                switch (index)
                {
                    case 0:
                        HungerDecrease();
                        updatedPetStats[0] = hunger;
                        break;
                }

                
            }

            return updatedPetStats;

        }



        }

            


        




}
   
