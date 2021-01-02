// Swap.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
#include<ctype.h>
using namespace std;


int _tmain(int argc, _TCHAR* argv[])
{
	cout << "Enter 3 dogit number\n";

	
	int a;
	/*string as;
	cin >> as;
	int len = as.length();*/
	cin >> a;
	a=a * 5;
	cout << a % 10;
	a = a / 10;
	cout << a % 10;
	cout<<a/10;
	cout << "\n";


	int age[5];
	for (int i = 0; i < 5; i++)
	{
		cout << "Enter age";
		cin >> age[i];
	}

	for (int i = 0; i < 5; i++)
	{
		cout << "your age" << age[i]<<"\n";
	}

	return 0;
}

