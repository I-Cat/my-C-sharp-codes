// FactorialByRecursive.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

double fact(int number){
	if (number <= 1)
		return 1;
	else
		return number*fact(number-1);
}

int _tmain(int argc, _TCHAR* argv[])
{
	cout << fact(5)<<endl;
	return 0;
}

