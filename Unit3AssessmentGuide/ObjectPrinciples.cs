using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    class ObjectPrinciples
    {
        string name { get; set; }//these are fields!
        string definition { get; set; }
        string example { get; set; }
        public string NotSafeVariable = "HELP!";
        protected string CantTouchThis = "Mwahaha";
        public int InstanceVariable=111;
        public static int StaticVar = 112;

        public ObjectPrinciples(string name, string definition, string example)//I am creating a constructor here that on the Program.cs calls the object by doing: ObjectPrinciples op = new ObjectPrinciples()
        {
            this.name = name;
            this.definition = definition;
            this.example = example;
        }
        List<ObjectPrinciples> Concepts = new List<ObjectPrinciples>();

        public void Study()
        {
            Console.Clear();
            Concepts.Add(new ObjectPrinciples("Abstraction", "Shows the funtionality, but does not show the details", "You know how to program on a computer, but you don't know the components of a pc."));//we need to create a new OBJECT of ObjectPrinciples to create a different one to be added into our list
            Concepts.Add(new ObjectPrinciples("Encapsulation", "Wrapping related functionality and data together as one unit", "Using a classes to define an animal"));
            Concepts.Add(new ObjectPrinciples("Inheritancee", "A class acquiring properities and behaviors of a parent/super class", "GetArea and GetPerimeter method names were passed into the shape Circle and Rectangle classes"));
            Concepts.Add(new ObjectPrinciples("Polymorphism", "The ability of an object to take on many forms", "Shape is a parent class, its children Rectangle and Circle, are MANY different shapes - polymorphed shapes"));
            bool run = true;
            while (run)
            {
                int index = 0;
                Console.WriteLine("Which one would you like to learn about?");
                foreach (ObjectPrinciples concept in Concepts)
                {
                    Console.WriteLine(index + ".) " + concept.name);
                    
                    index++;
                }
                int userInput = int.Parse(Console.ReadLine());
                if (userInput ==0)
                {
                    Console.WriteLine(" {0} is {1}. Hit enter to see an example", Concepts[0].name, Concepts[0].definition );
                    Console.ReadLine();
                    Console.WriteLine(Concepts[0].example);
                }
                else if (userInput ==1)
                {
                    Console.WriteLine(" {0} is {1}. Hit enter to see an example", Concepts[1].name, Concepts[1].definition);
                    Console.ReadLine();
                    Console.WriteLine(Concepts[1].example);
                }
                else if (userInput ==2)
                {
                    Console.WriteLine(" {0} is {1}. Hit enter to see an example", Concepts[2].name, Concepts[2].definition);
                    Console.ReadLine();
                    Console.WriteLine(Concepts[2].example);
                }
                else if (userInput==3)
                {
                    Console.WriteLine(" {0} is {1}. Hit enter to see an example", Concepts[3].name, Concepts[3].definition);
                    Console.ReadLine();
                    Console.WriteLine(Concepts[3].example);
                }
                Console.WriteLine("Do you want to run it again? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer =="n")
                {
                    run = false; //you guys hit any other letter, you are stuck in this loop because I'm too stubborn to write validation
                }
            }
            

        }

        
    }
}
