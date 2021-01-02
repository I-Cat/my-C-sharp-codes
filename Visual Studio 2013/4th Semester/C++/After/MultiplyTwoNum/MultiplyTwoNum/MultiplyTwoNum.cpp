// MultiplyTwoNum.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{

	int array[8] = { 1, 2, 8, 4, 5, 6, 7 };
	int a, b;
	for (int i = 0; i < 8; i++)
	{
		if (array[i] == 5)
			a = array[i];
		if (array[i] == 8)
			b = array[i];
	}
	cout << "\twhy Are you Sleepng...???" << endl;
	cout << a*b<<endl;
	bool found = false;
	cout << "@nd......................" << endl;
	for (int i = 0; i < 8; i++)
	{
		for (int j = 0; j < 8; j++)
		{
			if (array[i] * array[j] ==16 ){
				cout << "Found..." <<array[i]<<" and "<<array[j]<< endl;
				found = true;
			}
			
		}
		if (found)
			break;
	}
	
	return 0;
}

