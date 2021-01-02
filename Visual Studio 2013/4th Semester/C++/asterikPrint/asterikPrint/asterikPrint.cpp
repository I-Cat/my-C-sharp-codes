// asterikPrint.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;


int _tmain(int argc, _TCHAR* argv[])
{

	int num[10];
	int snum;
	for (int i = 0; i < 10; i++)
	{
		cout << "enter nubers";
		cin >> num[i];
	}
	cout << "Index" << "\t" << "value\t"<<"Asterik\n";

	for (int i = 0; i < 10; i++)
	{ 
		cout << i << "\t" << num[i] << "\t" ;
		for (int j = 0; j < num[i]; j++)
		{
			cout << "*";
		}
		cout << "\n";
	}
	

	return 0;
}

