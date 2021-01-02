// Q4.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class node
{
private:
	int data;
	node *next;
public:
	void SetData(int data)
	{
		this->data = data;
}

	int Getdata(){
		return data;
	}
	void SetNext(node *ptr)
	{
		next = ptr;
	}
	node* GetNext()
	{
		return next;
	}
};

class list{

	node* currentLocation;

public:
	list(){

		currentLocation = NULL;
	}
	void Insert(int data) 
	{
		node *newnode = new node;
		newnode->SetData(data);
		newnode->SetNext(NULL);

		node *temp = currentLocation;

		if (temp != NULL)
		{
			while (temp->GetNext()!=NULL)
			{
				temp = temp->GetNext();

			}
			temp->SetNext(newnode);
		}
		else
		{
			currentLocation = newnode;
		}
	}

	void INsertAndSORT(int data)
	{
		node *newnode = new node;
		newnode->SetData(data);
		newnode->SetNext(NULL);

		node *temp = currentLocation;
		node *p=new node;
		
		if (temp == NULL)
			{
				currentLocation = newnode;
			}
		
		
		else if (temp != NULL)
		{

			//in case data is less or equal to 1st node

			if (temp->Getdata() >= data)
			{
				newnode->SetNext(currentLocation);
				currentLocation = newnode;
			}

			//in between 

			else

			{

				while (temp->GetNext() != NULL)
				{
					if (temp->Getdata() >= data)
					{
						break;
					}
					p = temp; //To save previous NOde
					temp = temp->GetNext(); //to move to next node
				}

				//	in case last value is greater then enterd value
				
				if (temp->Getdata() > data)
				
				{
					p->SetNext(newnode); //set previous node next 
					newnode->SetNext(temp); //set new node next 
				}

				//else set at end
				else
					temp->SetNext(newnode);
			}
		}
		
		
	}
	void Dispaly(){
		node * temp = currentLocation;
		if (temp == NULL)
		{
			cout << "LIst is empty";
			return;
		}
		if (temp->GetNext() == NULL){

			cout << temp->Getdata() << "->NULL" << endl;

		}

		if (temp->GetNext() != NULL){
			do{
				cout << temp->Getdata();
				cout << "->";
				temp = temp->GetNext();
			} 
			while (temp != NULL);
			cout << "NULL" << endl;
		}
	}

	//for 2nd question
	void Swap(int index, int secondIndex)
	{
		int num1, num2,num3;
		node *temp = currentLocation;
		node * ptr = currentLocation;

		for (int i = 0; i < index; i++)
		{
			temp = temp->GetNext();
			num1 = temp->Getdata();
		}
		for (int i = 0; i < secondIndex; i++)
		{
			ptr = ptr->GetNext();
			num2 = ptr->Getdata();
		}

		temp->SetData(num2);
		ptr->SetData(num1);

	}
};



int _tmain(int argc, _TCHAR* argv[])
{

	list li;
	li.Insert(5);
	li.Insert(6);
	li.Insert(8);
	li.Insert(9);
	li.Dispaly();

	li.INsertAndSORT(1);
	li.INsertAndSORT(1);
	li.INsertAndSORT(3);
	li.INsertAndSORT(7);
	li.INsertAndSORT(0);
	li.INsertAndSORT(12);
	li.Dispaly();

	//note i considered index starts from 0
	li.Swap(4,6);
	li.Dispaly();
	return 0;
}

