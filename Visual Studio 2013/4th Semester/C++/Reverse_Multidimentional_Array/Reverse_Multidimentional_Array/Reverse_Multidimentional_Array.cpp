// Reverse_Multidimentional_Array.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <ctype.h>
using namespace std;


int mArray[3][3] = { { 1, 2, 4 },
                   { 2, 5, 7 }, 
				   { 1, 4, 5 }
                                };

int _tmain(int argc, _TCHAR* argv[])
{
	cout << "Before" << endl;
	for (int i = 0; i < 3; i++){
		for (int j = 0; j < 3; j++)
		{
			cout << mArray[i][j] << " ";
		}
		cout << endl;
	}

	
	cout << endl << "After" << endl;

	for (int i = 2; i >= 0; i--){
		for (int j = 0; j <3 ; j++)
		{
			cout << mArray[i][j]<<" ";
		}
		cout << endl;
	}
	return 0;
}

