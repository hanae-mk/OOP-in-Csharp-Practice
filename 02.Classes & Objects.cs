using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    //class is a datatype and if it's a datatype so it's a Data Structure bcs we 
    //order inside it data 
    //if we want to use a class for ex : clsEmployee we should have an object
    //for ex : clsEmployee ITEmployee, SalesEmployee... those are objects type class 
    //A class is called also BLUE BRIDGE (مخطط)
    //class is a classification of members and methods 
    class clsPerson
    {
        //Property = Field = Member

        private short _Age = 0;  

       public string FirstName = "";
       public string LastName = "";
       public string FullName() //Method = Function
       {
           return FirstName + " " + LastName;
       }


    }


    internal class Program 
    {            
        static void Main(string[] args)
        {
            //create object Person1 type class in memory
            //assign Person1 in memory
            clsPerson Person1 = new clsPerson(); 

            Person1.FirstName = "Hanae";
            Person1.LastName = "Messari-Khali";

            Console.WriteLine("My name is : " + Person1.FullName());
     

            //create object Person2 type class clsPerson in memory
            clsPerson Person2 = new clsPerson();

            Person2.FirstName = "Mona";
            Person2.LastName = "Zaki";

            Console.WriteLine("Her Name is : " + Person2.FullName());
            Console.ReadLine();


        }
    }
}
