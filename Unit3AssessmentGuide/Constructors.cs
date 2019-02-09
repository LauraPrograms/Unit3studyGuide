using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    class Constructors : AbstractParent
    {
        public override void Study()
        {
            Console.Clear();
            Console.WriteLine("Constructors are methods that are used to initialize the state of an object");
            Console.WriteLine("Remember, a constructor MUST USE the same capitalization as the name of the class.  See ObjectPrinciples.cs for a constructor.");
            Console.ReadLine();
            Console.WriteLine("Random fact: in absence of a constructor, C# will initialize all numeric types to 0, all boolean to false, and all objects to null.");
            Console.ReadLine();
            Console.WriteLine("Practice writing constructors and fields in Notepad - without the aid of an IDE. Then copy your cody into the Visual Studio and see where you made mistakes - or your glorious perfect code.");
            Console.WriteLine("Make a construct called BasketballTeams and fields/instance variables called hometown and another called team colors.");

        }
    }
}
