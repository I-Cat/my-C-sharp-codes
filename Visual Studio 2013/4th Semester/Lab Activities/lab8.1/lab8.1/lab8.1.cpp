// lab8.1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;


class lab
{
public:

	void calculteFactorial(int number)
	{
		int tempNumber = number;
		while (tempNumber != 1)
		{
			number = number*(tempNumber - 1);
			tempNumber--;
		}
		cout << "Factorial of input number is: " << number << endl;
	}


	//lab8 Ex 2
	int FactorialRecursion(int number)
	{
		if (number <= 1)
		{
			return 1;

		}
		else
			return number*FactorialRecursion(number - 1);
	}

	//EX 3
	void CalculatePower(int number, int power)
	{
		int temp = number;
		for (int i = 1; i <power;i++)
		{
			number =number*temp;
		}
		cout << "Power of Number by Loop Method : "<<number << endl;
	}


	//**************************************ex 4

	float CalculatePowerByRecursion(int number, int power)
	{

		
		if ( power!=1)
			return (number*CalculatePowerByRecursion(number, power-1));

		else
			return 1;
	}
	};

	int _tmain(int argc, _TCHAR* argv[])
	{
		lab lb;
		lb.calculteFactorial(5);

		cout <<"Factorial by Recursion : "<< lb.FactorialRecursion(5)<<endl;

		lb.CalculatePower(2,3);
		cout<<"power By Recursion "<<lb.CalculatePowerByRecursion(3,4)<<endl;
		
	}

