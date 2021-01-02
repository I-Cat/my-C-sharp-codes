// RecursiveFuntion.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int func()
{

	static int a = 5,d=0;
	a--;
	cout<< a<<"\ti Am recursive Funtion"<<endl;
	if (a >=1 )
	{
		d = d + 6;
		func();
	}
	return d;
}

int _tmain(int argc, _TCHAR* argv[])
{
	cout<<func()<<endl;
	return 0;
}

