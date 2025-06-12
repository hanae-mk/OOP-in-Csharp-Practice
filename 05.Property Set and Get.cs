using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Property_Set_and_Get
{
    class clsEmployee
    {
        private int _ID = -1;
        private string _Name = string.Empty; //it's like _Name = ""

        //ID Property Declaration 
        public int ID //we set ID as public so we can access to it in main function
        {
            //In c++ we write the name of function in set and it's parameter for ex 
            //void setID(int ID)
            //{
            //    _ID = ID
            //}
            //in get we write :
            //int ID()
            //{
            //   return _ID
            //}
            //while here in c# the syntax for set and get is easy comparing to c++
            
            set
            {
                _ID = value;
            }

            get
            {
               return _ID;
            }
        }

        //Name Property Declaration
        public string Name //we set Name as public so we can access to it in main function
        {
            set
            {
                _Name = value;
            }

            get
            {
                return _Name;
            }
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //The difference between c++ and c# in set and get properties that :
            //In c++ we treat set and get as methods(functions)
            //while here in c# we treat set and get like members/variables.
            
            clsEmployee Employee1 = new clsEmployee();

            Employee1.ID = 7;         //We are setting the ID
            Employee1.Name = "Hanae"; //We are setting the Name

            Console.WriteLine("Employee ID = {0}", Employee1.ID);       //We are getting the ID
            Console.WriteLine("Employee Name is : {0}", Employee1.Name);//We are getting the Name

            Console.ReadLine();

            //QUESTION : What is the benefit of using properties set and get?
            //Answer : Properties set and get have hight scalability for example
            //in ID set property I can make a function that save in database the date
            //of modification of the ID and save the old value of the ID
            //Same for the Name if the user modify the Name of client we can make
            //a function in set property that saves the date of modification and the old
            //name of client
            //So we can call functions only by assignement (=)

        }
    }
}
