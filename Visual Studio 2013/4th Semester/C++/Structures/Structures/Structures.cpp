// Structures.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <conio.h>
#include <string>
using namespace std;


struct  student
{
	string id[5];
	string name[5];
	string address[5];

};

int _tmain(int argc, _TCHAR* argv[])
{
	int *p;
	int a = 20;
	p = &a;
	cout <<"p Address "<<p<<endl;

	//by using new keyword u can place a value in pointer
	int *q = new int;
	*q = 44;
	cout << "q vlue" << *q<<endl;

	// delete q;  //will delete the reserved location of the pointer

		*q = 46;
		cout << *q<<endl;

		//pointer to pointer
		
		int *ptr = &a;

		cout << "Ptr Address "<<ptr<<endl;
		int **ptr1 = &ptr;

		//double ** will give value And single * will give Address in this case

		cout << "ptr1 Address " << *ptr1<<endl;
		
		//Structures
		student stu;
		//string n, ad, id;
		

		for (int i = 1; i <= 2; i++)
		{
			cout << "Enter name For Student" << i << endl;
		    cin>>(stu.name[i]);
			cout << "Enter ID For Student" << i << endl;
			cin >> stu.id[i];
			cout << "Enter Address For Student" << i << endl;
			cin >> stu.address[i];
		}

		for (int i = 1; i <= 2; i++)
		{
			cout << "Student : " << i<<endl;
			cout << stu.name[i];
			cout << stu.id[i] << endl;
			cout << stu.address[i] << endl;

			cout << "\n" << endl;

		}
		

	return 0;
}

