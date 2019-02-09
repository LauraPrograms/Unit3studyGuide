using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Unit3 = new List<string>();
            Unit3.Add("The Four Object Oriented Principles");
            Unit3.Add("Classes and Objects");
            Unit3.Add("Constructors");
            Unit3.Add("Properties");
            Unit3.Add("Abstract Methods, Abstract Classes, and Interfaces");
            Unit3.Add("Access modifiers");
            Unit3.Add("Static Methods and Variables vs. Instance Methods and Variables");
            Unit3.Add("Base Keyword");
            Unit3.Add("This Keyword");
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("Please select a number you would like to review.");
                int index = 0;
                foreach (string subject in Unit3)
                {
                    Console.WriteLine(index + ".) " + subject);
                    index++;
                }

                int userInput = int.Parse(Console.ReadLine());
                if (userInput == 0)
                {
                    Console.Clear();
                    ObjectPrinciples op = new ObjectPrinciples("", "", "");  //this is creating the object called ObjectPrinciples stored in the variable op. Notice I have 3 empty strings? Why did I need 3 strings?
                    op.Study();  //this is the public methods on the object, we called it using the variable op.
                }
                else if (userInput == 1)
                {
                    Console.Clear();
                    ClassesObjects co = new ClassesObjects();
                    co.Study(); //I could have made my life easier by making an abstract class or interface so I don't have to write Study() method on every class... 5 minutes later... I wrote AbstractParent to give inheritance to children.
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    Constructors con = new Constructors();
                    con.Study();
                }
                else if (userInput == 3)
                {
                    Console.Clear();
                    Properties pro = new Properties(); //the class Properties.cs was made a child of an Interface class called IIinterfaceClass.s
                    pro.Studyi();
                    pro.GetNumber = 5; //I purposely left this error here to show off Get set, if you mouse over the error, it will tell you GetNumber is a read only from the Properties.cs class.
                    pro.GetSetNumber = 12;
                    
                    Console.WriteLine("GetNumber: " +pro.GetNumber+ "\t"+ "Get SetNumber " +pro.GetSetNumber);
                }
                else if (userInput == 4)
                {
                    Console.Clear();
                    AbstractMethodsClassesInterfaces amci = new AbstractMethodsClassesInterfaces();
                    amci.Study();
                    amci.Interfaces();
                    
                    Console.Clear();
                    Console.WriteLine("Surprise! I am able to call ConcreteVirtual on the Program.cs because its public and not protected modifier. (change it on the AbstractParent class to protected and see what happens on Program.cs Line 67)");
                    amci.ConcreteVirtual();
                }
                else if (userInput==5)
                {
                    Console.Clear();
                    AccessModifiers am = new AccessModifiers();
                    am.Studyi();
                    
                }
                else if (userInput == 6)
                {
                    Console.Clear();
                    StaticVsInstance svi = new StaticVsInstance();
                    svi.Study();                    
                }
                else if (userInput == 7)
                {
                    Console.Clear();
                    This bs = new This();
                    bs.Study();
                }
                else if (userInput == 8)
                {
                    Console.Clear();
                    This bs = new This();//its easy to compare them this way.
                    bs.Study();
                }
                run = Continue();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to review other topics? (y/n)");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }
    }
}
