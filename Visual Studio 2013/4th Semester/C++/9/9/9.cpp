// 9.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	int const size=11;

	int a[size] = { 1, 2, 3, 4, 6, 9, 5, 5, 4, 67, 9 };
	// { 1, 2, 3, 4, 6, 9, 5, 5, 4, 67, 9 };
		//{ 1, 4, 1, 9, 9, 4,1 };
	//{ 1, 2, 3, 4, 6, 9 ,5,5,4,67,9};
 

	//this is algo
	 for (int i = 0; i <size; i++){

		if (a[i] == 4 && a[i+1]!=9)
		{
			for (int j = 0; j < size; j++)
			{
				if (a[j] == 9 && a[j-1] != 4)
				{
					int temp = a[i + 1];
					a[i + 1] = a[j];
					a[j] = temp;
				}
			}
		}
	}
	
	 //print the array to console
	for (int i = 0; i < size; i++){
		cout << a[i] << ",";
	}
	return 0;
}

