using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members
{
    
    class clsA
    {
        public int x1 = 50; //variable = member = property = field 

        //static = shared
        //static means that x2 member is shared to ALL objects because it's on the CLASS
        //LEVEL not object level, we acces to it throught :
        //ONLY the class itself
        public static int x2 = 20;

        //we can access to method1() ONLY by object because it's a non static method
        //non static methods can always access static members (x2) and static methods
        //because it's a shared member / method BUT....
        public int Method1()
        {
            return x1 + x2 + Method2(); 
        }

        //BUT static methods CANNOT access to non-static members and methods
        //because there are not shared to all objects
        //static methods can access ONLY to static members/methods
        public static int Method2() 
        {
            //CORRECT!
            return x2 + 24;

            //FALSE!
            //An object reference is required for Method(1) because it's a non static method
            //return x2 + 24 + Method1();

            //ERROR : YOU SHOULD HAVE AN OBJECT REFERENCE FOR NON-STATIC MEMBERS
            //return clsA.x1 + x2;

            //OR YOU CAN DO IT IN THIS WAY IF YOU WANT TO HAVE A NON STATIC MEMBER IN 
            //A STATIC METHOD 
            //clsA A3 = new clsA();
            //A3.x1 = 30;
            //return A3.x1 + x2; 

        }

        //In C# we have restriction about accessing static members
        //we can call the static members (methods + variables)
        //ONLY by the class itself NOT by the object
        //(not like c++ you can call static members by class & object)
        //the similiar thing between c++ and c# is you can access non-static members
        //only by objects
       
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            clsA A1 = new clsA();
            clsA A2 = new clsA();
            
            A1.x1 = 5;
            A2.x1 = 10;                
            
            Console.WriteLine("Object A1, x1 = {0}", A1.x1); //5
            Console.WriteLine("Object A2, x1 = {0}", A2.x1); //10
            Console.WriteLine("Object A1, Method1() = {0}", A1.Method1()); //25
            Console.WriteLine("Object A2, Method1() = {0}", A2.Method1()); //30

            //ERROR 
            //A1.x2 = 4;
            //A2.x2 = 4;

            //x2 is a static (shared) member for all objects we can access to it
            //only by class name
            clsA.x2 = 15;
            Console.WriteLine("class clsA, x2 = {0}", clsA.x2);//15
            Console.WriteLine("class clsA, Method2() = {0}", clsA.Method2()); //39

            //we can modify the static member ONLY by the class itself       
            clsA.x2 = 1000;     
            Console.WriteLine("class clsA, x2 = {0}", clsA.x2);//1000
            Console.WriteLine("class clsA, Method2() = {0}", clsA.Method2()); //1024

            //NOTE : if you modify a static member ALL OBJECTS will be modified so
            //BE CAREFULL when you modify a static member because it's a SHARED member :-)
            //NOTE : always define a static member when this member is a general member, EX:
            //if you have a bank project and you have +100k clients and you put AccountBalance
            //as static member and you modify it for a client for (AccountBalnce = 5000),
            //all users will have 5000$ as Account Balance so we should set static to member
            //that his value should be similiar to all clients           

            Console.ReadKey();

        }
    }
}
