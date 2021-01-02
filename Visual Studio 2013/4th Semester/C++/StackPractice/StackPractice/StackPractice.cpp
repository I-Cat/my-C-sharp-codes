// StackPractice.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

const int arraySize = 4;

class Stack{
private:
	int stackArray[arraySize];
	int top;
public:
	Stack()
	{
		top = 0;
	}
	bool IsEmpty()
	{
		if (top == 0)
			return true;
		else
			return false;
	}

	void CalulateBinary()
	{
		Stack b;
		int number,remainder;
		char response;
		cout << "Enter a number\n";
		cin >> number;
		while (number != 0){
			remainder = number % 2;
			b.Push(remainder);
			number /= 2;     // number=number/2;
		}
		while (!(b.IsEmpty()))
		cout << b.Pop();
		cout << endl;
	}
	bool IsFull()
	{
		if (top == arraySize)
			return true;
		else
			return false;
	}
	int Size()
	{
		return top;
	}
	void Push(int num)
	{
		if (IsFull() == true)
		{
			cout << "Stack is full" << endl;
		}
		else

		stackArray[top++] = num;
	}
	int Pop()
	{
		if (IsEmpty()){
			cout << "Can't Delete Stack is Empty " << endl;
			//Display();
			return 0;
		}
		else
		{
			top--;
			//Display();
			return stackArray[top];
		}
	}
	void Display()
	{
		if (IsEmpty()){
			cout << "there is no element..." << endl;
		}
		else
		{
			for (int i = Size()-1; i >= 0; i--)
			{
				cout << stackArray[i] << endl;
			}
		}
	}

};


int _tmain(int argc, _TCHAR* argv[])
{
	Stack st; int choice, element;
	cout << "\t1 for Add (Push)\n";
	cout << "\t2 for Remove (Pop)\n";
	cout << "\t3 for Display\n";
	cout << "\t4 for Binary\n\n";

	do
	{
		cout << "Enter choice : ";
		cin >> choice;
		
	

	switch (choice)
	{
	case 1:
		cout << "Enter Element: ";
		cin >> element;
		st.Push(element);
		break;
	case 2:
		st.Pop();
		break;
	case 3:
		
		st.Display();
		break;
	case 4:

		st.CalulateBinary();
		break;
	default :
		if (choice!=0)
		cout << "Wrong Choice\n\n";
	}
	} 
	while (choice != 0);
	return 0;
}

