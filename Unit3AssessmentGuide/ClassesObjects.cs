using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    class ClassesObjects : AbstractParent
    {
        public override void Study()  //this method HAD to be here because ClassesObjects is the child of AbstractParent. This method also had to be override to use it (you can't have an abstract method inside a child class - it has to be overridden)
        {
            Console.Clear();
            Console.WriteLine("A class is a template or blue print that describes the supported behavior and state of all objects of its type");
            Console.ReadLine();
            Console.WriteLine("An object is an instance of a class");
            Console.ReadLine();
            Console.WriteLine("Take a look at the comments on the Program.cs in the first if statement to see examples of it.");
        }
    }
}
