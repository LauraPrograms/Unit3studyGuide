using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    class This : AbstractParent
    {
        bool TestThis;
        public This()
        {
            this.TestThis = false;
        }
        public override void Study()
        {
            Console.WriteLine("The best way to understand Base keyword is to see it against This keyword (and vice versa). Go to the Base.cs" );
            Console.WriteLine("This is using \"this\" keyword = "+ TestThis);
                       
            
            Console.WriteLine("This is using the \"base\" keyword (going back to the AbstractParent) = " + base.TestThis);
            Console.ReadLine();
            Console.WriteLine("The base keyword can even call methods! Like the one below that prints out a message.");
            base.ConcreteVirtual();
        }
    }
}
