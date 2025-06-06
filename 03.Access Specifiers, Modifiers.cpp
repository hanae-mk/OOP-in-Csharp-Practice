
//There Are 3 Access Specifiers(Modifiers):

// 01/ Private   : Accessible Inside the Class Only EVEN if you inherits the class you 
//                 can NOT access to the members/methods inside it.
// 02/ Protected : Accessible Inside the Class And all classes inherits this class 
//                 NOT accessible outside the class.
// 03/ Public    : Accessible to everyone inside/outside the class and classes 
//                 that inherits this class.

#include <iostream>
using namespace std;

class clsPerson
{
private: //Access Modifier or Access Specifier

	int Variable1 = 5;

	int Function1()
	{
		return 40;
	}

protected:

	int Variable2 = 10;

	int Function2()
	{
		return 50;
	}

public:

	string FirstName = ""; 
	string LastName = ""; 

	string FullName() 
	{
		return FirstName + " " + LastName;
	}

	float Function3()
	{
		return Function1() * Variable1 * Variable2;
	}
};

int main()
{
	clsPerson Person1;

	Person1.FirstName = "Hanae";
	Person1.LastName = "Messari";

	cout << Person1.FullName() << endl;
	cout << Person1.Function3() << endl;

	string S1;
	//when you tap S1. you see only public methods in string class 
	//if you open the source code of string you will see also private and protected methods


}
