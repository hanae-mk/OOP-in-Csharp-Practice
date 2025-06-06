using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    //In c++ there are 3 types of access specifiers/modifiers : private/protected/public
    //but in c# there are 4 types of access specifiers/modifiers :       + Internal

    class clsA
    {

        private byte x1 = 10; //for internal use
        protected byte x2 = 20; //also for internal use & for classes that inherits this class
        public byte x3 = 30;

        private byte Fun1()
        {
            return 70;
        }

        protected byte Fun2()
        {
            return 40;
        }

        public byte Fun3()
        {
            return 50;
        }

    }

    class clsB : clsA //clsB inherits clsA
    {
        //x2,fun2 is protected and x3,fun3 is public in the base class so we can access to them
        public byte Fun4() 
        {
            return (byte)(x2 + x3 + Fun2() + Fun3()); 
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //create object from class
            clsA A1 = new clsA();

            Console.WriteLine("Public members/methods are : ");
            Console.WriteLine("x3 = {0}", A1.x3);
            Console.WriteLine("Function 3 = {0}", A1.Fun3());

            //we cannot access to x2 and fun2() due to their protection level
            Console.WriteLine("x2 = {0}, Function 2 = {1}", A1.x2, A1.Fun2());

            //we cannot access to x1 and fun1() due to their protection level
            Console.WriteLine("x1 = {0}, Function 1 = {1}", A1.x1, A1.Fun1());

            clsB B1 = new clsB();

            Console.WriteLine("Public members/methods are : ");
            Console.WriteLine("Function 4 = {0}", B1.Fun4());  

            //we cannot access to x2 and fun2() due to their protection level
            Console.WriteLine("x2 = {0}, Function 2 = {1}", B1.x2, B1.Fun2());

            //we cannot access to x1 and fun1() due to their protection level
            Console.WriteLine("x1 = {0}, Function 1 = {1}", B1.x1, B1.Fun1());

            Console.ReadKey();


        }
    }
}
