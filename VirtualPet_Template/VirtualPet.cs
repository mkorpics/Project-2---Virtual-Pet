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

        //TODO how can we set things with our construtor
        public VirtualPet(string name, int hunger, int sick, int boredom)
        {
            this.name = name;
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
            //TODO account for more fields
        }
    }
}
