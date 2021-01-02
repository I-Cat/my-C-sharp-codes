// PointerAs_Array.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;



int _tmain(int argc, _TCHAR* argv[])
{
	int numbers[3] = { 1, 2, 3 };
	
	int *ptr;

	ptr = numbers;
	for (int i = 0; i < 3; i++)
	{
		
		cout << *ptr<<","<<endl;
		ptr++;

		//cout<<ptr[i]<<"\t";
	}

}

