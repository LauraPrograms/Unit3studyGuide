using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    class Properties : IInterfaceClass  //what is the difference between this inheritance vs the ClassObjects that inherited from the AbstractParent?
    {
        public int GetNumber { get; }
        public int GetSetNumber { get; set; }
        public Properties()
        {
            this.GetNumber = 3;
        }

        public void Studyi()
        {
            
            Console.WriteLine("Properties are the \"get\" and \"set\" for a field/instance.");
            Console.WriteLine("An example of of using a property is modeling a jar, and it is made from clay. The Material property returns \"clay\".");
            Console.WriteLine("What the **** does that mean? select 1 and 2 to break it down.");

            Console.WriteLine("1.) Get");
            Console.WriteLine("2.) Set");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.WriteLine("A get is an accessor method. It is a statement that returns a value, look at the Properties.cs comments and see how get will return the value of seconds in the first two examples.");
                Console.WriteLine("Get by itself is creating a read-only variable/property.");
            }
            else if (userInput == 2)
            {
                Console.WriteLine("A set is an accessor method. Its return type unless it has a value, then the property will take on the data type of the value.");
                Console.WriteLine("A set by itself (no get) is creating a write-only variable/property.");
                Console.WriteLine("Take a look at Properties.cs Example 2 in the comments");
            }
            Console.ReadLine();
            Console.WriteLine("Practice writing properties with a get and set in Notepad. Practice writing a field (see examle 2 for the difference).  Need ideas of names, create a class called Player.cs with a public field called position. Create a property called Name.");
            Console.WriteLine("There are two ways to write get set properties. One is the the way I set GetNumber and GetSetNumber, the other way is in the comment section on Properties.cs. The second example completely write out the get method and then the set method.");

            //get and setters REVIEW
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/get
            //https://www.dotnetperls.com/property
            //EXAMPLE 1
            // class TimePeriod
            //{
            //    private double _seconds;

            //    public double Seconds
            //    {
            //        get { return _seconds; }
            //        set { _seconds = value; }
            //    }
            //}

            //class TimePeriod
            //{
            //    private double _seconds;

            //    public double Seconds
            //    {
            //        get => _seconds;
            //        set => _seconds = value;
            //    }
            //}

            //EXAMPLE 2
            //    class Person
            //{
            //    private string name;  // the name field
            //    public string Name    // the Name property
            //    {
            //        get
            //        {
            //            return name;
            //        }
            //        set
            //        {
            //            name = value;
            //        }
            //    }


            //    public class SaleItem
            //    {
            //        public string Name
            //        { get; set; }

            //        public decimal Price
            //        { get; set; }
            //    }

            //    class Program
            //    {
            //        static void Main(string[] args)
            //        {
            //            var item = new SaleItem { Name = "Shoes", Price = 19.95m };
            //            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");
            //        }
            //    }
            //}
        }
    }
}
