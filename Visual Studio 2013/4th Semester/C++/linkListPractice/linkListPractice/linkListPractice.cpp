// linkListPractice.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class Node
{
public:
	int data;
	Node *Next;
//public:
//	void setdata(int n)
//	{
//		data = n;
//	}
};
class LinkList
{
private:
	Node *currentLocation;
public:
	LinkList()
	{
		currentLocation = NULL;
	}
	void Add(int number)
	{
		Node *newNode = new Node();
		newNode->data = number;
		newNode->Next = NULL;

		Node *temp = currentLocation;
		if (temp!=NULL)
		{
			while (temp->Next != NULL)
			{
				temp = temp->Next;
			}
			temp->Next = newNode;
		}

		else
		{
			currentLocation = newNode;
		}
	}

	void Display()
	{
		Node *temp=currentLocation;
		if (temp == NULL){

			cout << "list is empty"<<endl;
		}
		/*else if (temp->Next == NULL)
		{
			cout << temp->data;
		}*/
		else
		{
			do
			{
				cout << temp->data <<" --> ";
				temp = temp->Next;
			}
			while (temp!= NULL);
			cout << "Null" << endl;
		}
	}

	void Search(int a)
	{
		Node *temp = currentLocation;

		do
		{
			if (temp->data == a)
			{
				cout << "Found..." << endl;
				break;

			}
			temp=temp->Next;
		} 
		while (temp->Next != NULL);
	}

	void Sort()
	{
		Node *temp ,*s;
		temp = currentLocation;
		int data=0,i=0;
		
		while (temp->Next != NULL)
		{

			for (s = temp->Next; s->Next != NULL; s = s->Next)
			{
				if (temp->data > s->data)
				{
					data = temp->data;
					temp->data = s->data;
					s->data = data;
				}
				
			}
			temp = temp->Next;
		}
		



	}
};
int _tmain(int argc, _TCHAR* argv[])
{

	LinkList l;
	l.Add(155);
	l.Add(525);
	l.Add(6);
	l.Add(16);
	l.Add(65);
	l.Display();
	
	//Search The List
	l.Search(155);
	//l.Search(1);
//	l.Search(5);

	l.Sort();
	cout << "After Sorting..."<<endl;
	l.Display();

	return 0;
}

