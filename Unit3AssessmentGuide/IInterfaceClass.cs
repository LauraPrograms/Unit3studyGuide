using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    interface IInterfaceClass //yes two I's, because you have to start with an I, and I really really want to drive in the point.
    {
        void Studyi(); //notice how we don't have public or abstract in front of this method?  That's because any child that will inherit its traits from this class HAS NO CHOICE IN THE MATTER.
        //void TestMethod()
        //{ interface methods can't have blocks of code.
        //}
    }
}
