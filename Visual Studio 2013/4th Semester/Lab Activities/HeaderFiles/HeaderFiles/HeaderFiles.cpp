// HeaderFiles.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int AddTwoNumbers(int number1, int number2)
{
	int result=number1 + number2;
	
	return result;
}
int _tmain(int argc, _TCHAR* argv[])
{
	
	cout<<AddTwoNumbers(12, 4);

}

