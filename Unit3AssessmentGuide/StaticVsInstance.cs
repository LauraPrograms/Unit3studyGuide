using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit3AssessmentGuide
{
    class StaticVsInstance
    {
        private static int StaticVariable = 25;
        public void Study()
        {
            // great link for reviewing and writing these variables https://www.geeksforgeeks.org/c-sharp-types-of-variables/
            Console.WriteLine("Non-, also called Instance variables, are declared in the class block, outside of the method or constructor.");
            Console.WriteLine("They exist when the object is created, and destroyed when a new object create it. Look at StaticVsInstance line 16.");
            ObjectPrinciples op1 = new ObjectPrinciples("", "", "");
            ObjectPrinciples op2 = new ObjectPrinciples("", "", "");
            op1.InstanceVariable = 15;
            Console.WriteLine("The original value of InstanceVariable was 111, it is now: " + op1.InstanceVariable);
            Console.ReadLine();
            op1.InstanceVariable = 6;
            Console.WriteLine("The Instance Variable has been redfined, it is now: " + op1.InstanceVariable);
            Console.WriteLine(ObjectPrinciples.StaticVar);
            ObjectPrinciples.StaticVar = 5;
            Console.WriteLine("This is the StaticVar from ObjectPrinciples redefined " + ObjectPrinciples.StaticVar);
            StaticVariable = 88;
            Console.WriteLine(StaticVariable + " This was the last instance of the static variable that was printed. The next line shows us calling the staticVar from ObjectPrinciples and redefining it in the next");
            Console.ReadLine();
            Console.WriteLine("Practice writing and calling static variables and instances in Notepad (call one bird and the other one food if needed).");
            Console.ReadLine();
            Console.Clear();//this is why you have methods, to make the code look neater than this ugly line calling going on.
            Console.WriteLine("Static means the method can be called without an instance of the object. Example the Continue() on Program.cs or any Math.Round (math being the class).");
            Console.ReadLine();
            Console.WriteLine("Where as everytime I wanted to call the Study() from my other classes, I had to make an instance of the class on the Program.cs page.");
            Console.ReadLine();
            Console.WriteLine("Practice writing the following in Notepad: static fields, instance fields. Then try calling those fields in a static method and again in a instance method (remember methods you created are by default instance ones).");

        }

        private void TestMethod()//I can use this method here because it is not static
        {

        }
        //private static StaticTest()  //this method uncomment won't work. You can't have a static method within a constructor (you can only have static methods in a static class - which StaticVsInstance is not a static class by default
        //{
        //Console.WriteLine("Failed static method");
        //}
    }

}
