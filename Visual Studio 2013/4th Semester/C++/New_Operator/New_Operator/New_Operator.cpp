// New_Operator.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
using namespace std;



struct Node
{
	int data;
	Node *ptr;
};

class List
{
public:
	List();
	
	Node *first;
	Node *last;
	void Display()
	{
		cout << last->data<<endl;
		cout << first;
	}
	void Create_Node(int number)
	{
		Node *temp = new Node;
		temp->data = number;
		if (first == NULL)
		{
			first = temp;
			last = temp;
			temp->ptr = NULL;
		}
		else
		{
			last->ptr = NULL;
		}
	}
};

List::List()
{
	first = NULL;
	last = NULL;
}



int _tmain(int argc, _TCHAR* argv[])
{
	List li; int num;
	for (int i = 0; i < 2; i++){
		cout << "Enter a Number";
		cin >> num;

		li.Create_Node(num);
		li.Display();
	}
}

