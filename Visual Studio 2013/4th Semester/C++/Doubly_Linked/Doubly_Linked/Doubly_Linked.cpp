// Doubly_Linked.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
using namespace std;

class node
{
private:
	int data;
	node *p,*n;
public:
	void Setdata(int num)
	{
		data = num;
	}
	int Getdate()
	{
		return data;
	}
	void SetP(node *p1)
	{
		this->p = p1;
	}
	node* GetP()
	{
		return p;
	}

	void SetNext(node *n1)
	  {
		this->n = n1;
	}

	node* GetNext()
	{
		return n;
	}
};

class Doublylinked{
private:
	node *currentLocation=new node();
public:
	Doublylinked()
	{
		currentLocation = NULL;
	}


	void Insert(int data)
	{
		node *newnode = new node();
		newnode->Setdata( data);
	//	newnode->SetP(NULL);
        newnode->SetNext(NULL);

		node *temp = currentLocation;
		if (temp != NULL)
		{
			while (temp->GetNext() != NULL)
			{
				temp = temp->GetNext();

			}
			temp->SetNext(newnode);
			newnode->SetP(temp->GetP());
		}
		else
			currentLocation = newnode;
	}


	void Print()
	{
		node *temp = currentLocation;
		if (temp == NULL)
		{
			cout << "empty" << endl;
		}
		else
		{

			do
			{
				cout << temp->Getdate();
				cout << "-->";
				temp = temp->GetNext();
			} while (temp != NULL);
			cout << "Null" << endl;
		}
	}

	void Addpos(int data,int p)
	{
		//cout<<currentLocation->Getdate();
		node *newnode = new node();
		newnode->Setdata(data);
		//	newnode->SetP(NULL);
		newnode->SetNext(NULL);

		node *temp = currentLocation;
		for (int i = 0; i <=p-1 ; i++){
			
			temp = temp->GetNext();

		}
		temp->SetNext(newnode);
		newnode->SetP(temp->GetP());
		}
	
};

int _tmain(int argc, _TCHAR* argv[])
{
	Doublylinked dl; int n, p;
	dl.Insert(23);
	dl.Insert(56);
	dl.Insert(55);
	dl.Insert(555);
	dl.Insert(59);
	dl.Print();
	cout << "Enter postiion and Number";
	cin >> p;
	cin >> n;
	dl.Addpos(n, p);
	dl.Print();
}

