using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    class AccessModifiers : IInterfaceClass
    {
        private string ForAccessModifiersOnly = "Private";
        public void Studyi()
        {
            ObjectPrinciples principles = new ObjectPrinciples("", "", "");//this was to create an instance so I can kidnap-err use the NotSafeVariable.
            Console.WriteLine("There are a lot of modifiers. In fact, abstract, override, and static are modifiers. But we only care about 3 modifiers:");
            bool run = true;
            while (run)
            {
                Console.WriteLine("1.) Public");//I should have done a foreach loop for this ugh.
                Console.WriteLine("2.) Protected");
                Console.WriteLine("3.) Private");
                Console.WriteLine("Which one would you like to learn about?");
                int userInput = int.Parse(Console.ReadLine());
                if (userInput==1)
                {
                    Console.WriteLine("Public means you can access it from EVERYWHERE. Watch this (line 26 on AccessModifiers.cs)");
                    Console.ReadLine();                    
                    Console.WriteLine((principles.NotSafeVariable));
                    
                    Console.WriteLine("I was able to grab the NotSafeVariable string from ObjectPrinciple.cs.");
                }
                else if (userInput ==2)
                {
                    Console.WriteLine("Protected means access is limited to within the class and any class that inherits (its children) the class.");
                    Console.WriteLine("Look on line 35 on AccessModifiers.cs. If you uncomment the line, an error will appear saying you can't access the CantTouchThis variable. That is because it is protected.");
                    //Console.WriteLine(principles.CantTouchThis);
                }
                else if (userInput == 3)
                {
                    Console.WriteLine(ForAccessModifiersOnly);
                    Console.WriteLine("Private means access is only limited to within the class. I can't be passed anywhere outside the class it was created.");
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
    }
}
