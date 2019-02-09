using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    abstract class AbstractParent  //first notice how it is named class, not inheritance. Second, do not forget to write abstract in front of class (I did)
    {
        protected bool TestThis = true;
        protected string RandomVariable;
       
        
        public abstract void Study(); //I could have made it a public or protected method. I could have done public virtual void Study() too, and then passed in code within the method printing out "Hello"
        public void ConcreteVirtual()
        {
            Console.WriteLine("This is an example of a concrete/virtual method. It does not have the word abstract. I did not have to override it in the children classes ObjectPrincple, and I could call it here without creating an object of AbstractParent.");
        }
    }
}
