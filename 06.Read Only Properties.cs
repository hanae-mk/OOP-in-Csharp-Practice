using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Only_Properties
{
    class clsEmployee
    {
        private int _ID = 7; 
        private string _FirstName = string.Empty;
        private string _LastName = string.Empty;
        private byte _Age;
        //Always use byte with Age because nobody's age is over 255 :-)
        //In general ALWAYS be carefull in choosing the RIGHT datatype because it's affect 
        //the speed of program 

        //ID Property Declaration as Read ONLY!!
        public int ID
        {
            get 
            {
                return _ID;
            }
        }

        public string FirstName
        {
            set
            {
                _FirstName = value;
            }

            get
            {
                return _FirstName;
            }
        }

        public string LastName
        {
            set
            {
                _LastName = value;
            }

            get
            {
                return _LastName;
            }
        }

        public byte Age
        {
            set
            {
                _Age = value;
            }

            get
            {
                return _Age;
            }
        }
    }
      
    internal class Program
    {
        static void Main(string[] args)
        {
            clsEmployee ITEmployee = new clsEmployee();

            //ERROR : THE USER CANNOT MODIFY ITEMPLOYEE ID, THIS IS ONE OF MANY
            //BENEFITS OF OBJECT ORIENTED PROGRAMMING(MORE SECURITY) NOT LIKE FUNCTIONAL
            //PROGRAMMING EVERYONE CAN MODIFY MEMBERS AND WITHOUT OOP WE CANNOT HAVE SET AND
            //GET METHODS THAT WHY IT'S VERY IMPORTANT TO MASTER THE BASICS OF OOP
            //ITEmployee.ID = 10;

            ITEmployee.FirstName = "Hanae";
            ITEmployee.LastName = "Messari-Khali";
            ITEmployee.Age = 24;
           

            Console.WriteLine("IT Employee ID is : {0}", ITEmployee.ID); //7
            Console.WriteLine("IT Employee F.Name is : {0}", ITEmployee.FirstName);
            Console.WriteLine("IT Employee L.Name is : {0}", ITEmployee.LastName);
            Console.WriteLine("IT Employee Age is : {0}", ITEmployee.Age);

            Console.ReadKey();

            //QUESTION : WHY WE USE READ ONLY PROPERTIES ?
            //ANSWER : BECAUSE THERE ARE SENSITIVE DATA MEMBERS LIKE ID, SALARY, ACCOUNT BALANCE...
            //AND WE WON'T NOBODY MODIFY THE VALUE OF THESE MEMBERS


        }
    }
}
