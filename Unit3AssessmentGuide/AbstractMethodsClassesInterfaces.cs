using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    class AbstractMethodsClassesInterfaces : AbstractParent
    {//no field or instant variable required for the RandomVariable. I did not even have to use get; set; properties. Thank you Abstract classes!
     //private bool TestThis = false; //if you uncomment this field, you get an error saying I can't use this keyword because the Parent class has defined it. I would have to add the word "new" in between bool and TestThis. Then rerun the code.

        public AbstractMethodsClassesInterfaces()
        {
            this.RandomVariable = "How are you doing? This is RandomVariable from AbstractParent";//the child class can define it how ever it wants.
            //I was able to define this protected variable from the parent class too.
        }
        public override void Study() //example of a method passed down from the AbstractParent. It was an abstract method, with no return type (hence the void), we over wrote the abstract into an override.
        {
            Console.WriteLine("Take a look at the AbstractMethodsClassesInterfaces.cs (silly name, I know). It is a child/subclass of AbstractParent. With a method passed in.");
            Console.ReadLine();
            Console.WriteLine(RandomVariable);
            Console.WriteLine("^ that was RandomVariable that I called in from the AbstractParent class. I did it without an instance variable or a field on on this class. I was able to because the Parent class had the variable declared.");
            Console.WriteLine("Abstract classes can have variables. INTERFACES CAN'T HAVE VARIABLES PASSED TO THE CHILDREN.");
            Console.ReadLine();
            Console.WriteLine(TestThis); //the value TestThis was passed down from the abstract parent, I did not need to define it on this class page because of that.  Now if you uncomment line 11, it will override it after you add the word "new"
            Console.WriteLine("That true statment that printed was a protected string passed from AbstractParent into this class. Modifiers in an abstract class can only be public or protected. Private does not allow the field to be inherited.");
            Console.WriteLine("Practice writing an abstract class in Notepad and then pass it into Visual Studio. Abstract Parents can pass a method 2 ways:");
            bool run = true;
            while (run)
            {
                Console.WriteLine("1.) Virtual");
                Console.WriteLine("2.) Abstract");
                Console.WriteLine("Which one would you like to learn about?");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("Virtual methods are implied methods and provide the derived classes with the option of overriding it.");
                    Console.WriteLine("Virtual methods can have code within their methods that are passed on. They are useful if you have a repeating code 80% of the time in the children class.");
                    Console.ReadLine();
                    Console.WriteLine("random fact, virtual methods are also called concrete methods. Look at the AbstractParent for an example. The method was not forced into ClassesObjects.cs, but I was able to pull it up on this class page (on line 43).");
                    ConcreteVirtual();
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Abstract methods use the keyword \"abstract.\" (yes I defined them using their own word). But the big difference between abstract and virtual modifiers is an abstract method HAS TO BE OVERRIDDEN BY THE INHERITED CLASS.");
                    Console.WriteLine("Abstract methods inside the super/parent class have no code inside of them - hence the override.");
                }
                Console.WriteLine("Would you like to Continue? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    run = true;
                }
                else if (answer == "n")
                {
                    run = false;
                }


            }
        }
        public void Interfaces()
        {
            Console.Clear();
            Console.WriteLine("I created an interface class called IInterfaceClass - always start their name with an I.");
            Console.ReadLine();
            Console.WriteLine("It is the parent class to Properties.cs. Notice how I still passed in the method Studyi from interface to there?");
            Console.WriteLine("Interfaces can only pass in methods, they can't be overridden, but the parent class can't have code in those methods (unlike abstract classes).");
            Console.ReadLine();
            Console.WriteLine("class Box: IParent1, IParent2");
            Console.WriteLine("^ that is a snippet of code showing how Box.cs was able to inherit from 2 interfaces - it is 100% okay to do that. Don't do it for abstract classes.");
            Console.WriteLine("Practice in notepad creating an Abstract class called States with a protected field for stateBird. Write an Interface class with a method for Region - remember interfaces can't have fields.");
        }
    }

}

