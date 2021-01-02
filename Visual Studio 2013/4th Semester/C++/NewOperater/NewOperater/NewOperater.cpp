// NewOperater.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
#include<ctype.h>
using namespace std;


int _tmain(int argc, _TCHAR* argv[])
{

	int *ptr=new int;
	*ptr = 12;
	cout << *ptr;
	int a = 10;
	ptr = &a;
	cout <<"After \n"<< *ptr;

	return 0;
}

