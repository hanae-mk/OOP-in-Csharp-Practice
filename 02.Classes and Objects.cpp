
#include <iostream>

using namespace std;

//class = classification (tassnif) 
//A class is a datatype like int, string, bool...
//It's a user defined datatype like structure 
//Everything inside class is by DEFAULT private
//class called also blue bridge
class clsPerson  
{
private:

	short Age = 0; //Everything before public is private even if you don't write 
	               //private the compiler understand that it's private

public:

	string FirstName = ""; //Data member it's holds data     Variable = Member
	string LastName = ""; //Data member it's holds data
	
	//Every Function or Procedure inside a class called Method Member or Function Member .
	string FullName()  //Function = Method
	{
		return FirstName + " " + LastName ;
	}

};

int main()
{
//    class     O B J E C T S
	clsPerson Person1, Person2; //Variable min naw3 class huwa object so P1 and P2 are objects

	//P1 and P2 are objects type class "clsPerson"

	Person1.FirstName = "Hanae";
	Person1.LastName = "Messari";
	cout << Person1.FullName() << endl;

	Person2.FirstName = "Mohammed";
	Person2.LastName = "Abu-Hadhoud";
	cout << Person2.FullName() << endl;

	string S1; //S1 huwa object type class "string"
	//string is a class that contains methods :-)
	

	system("pause>0");
	return 0;

}