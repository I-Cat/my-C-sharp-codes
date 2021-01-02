// DoubleLinkListPractice.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

struct node
{
	int info;
	node *next;
	node *prev;
	 
}*start;


class Double_List
{
public:
	Double_List()
	{
		start = NULL;
	}
	void Create(int value)
	{
		node *s, *temp;
		temp = new node();
		temp->info = value;
		temp->next = NULL;

		if (start == NULL)
		{
			temp->prev = NULL;
			start = temp;
		}
		else
		{
			s = start;
			while (s->next != NULL)
			{
				s = s->next;
			}
			s->next = temp;
			temp->prev = s;
		}
	}

	void Display()
	{
		node *temp = start;
		if (temp == NULL){
			cout << "\n\n******Empty List*******\n\n";
		}
		else {

			do
			 {
				cout << temp->info<<" <-> ";
				temp=temp->next;
			} 
			while (temp != NULL);
		}
		cout << "Null\n\n";
	}

	void sort()
	{
		node *temp = new node();
		node *ptr = new node;
		temp = start;
		int value;
		value = temp->info;

		while (temp->next != NULL)
		{
			for (ptr = temp; ptr != NULL; ptr = ptr->next)
			{
				if (value > ptr->info)
				{
					value = ptr->info;
					ptr->info = temp->info;
					temp->info = value;
				}

			}
			temp = temp->next;
		}
	}

	//*****************************************************Add begin
	void AddAtBegining(int data)
	{
		
		
		if (start == NULL)
		{
			cout << "\n First Create List \n";
			return;
		}
		 
		node *temp = new node;
			temp->prev = NULL;
			temp->info = data;
			temp->next = start;
			start->prev = temp;
			start = temp;
		

	}
	
	//************************************************max*******
	void FindMax()
	{
		node *ptr=new node;
		node *temp = new node;
		temp = start;
		int value=temp->info;
		for (ptr = temp->next; ptr != NULL; ptr = ptr->next)
		{
			if (ptr->info > temp->info)
			{
				value = ptr->info;
				ptr->info = temp->info;
				temp->info = value;
			}

		}

		cout << "\n\n\t\tmax = " << value<<"\n\n";
	}
	//***********************delete**************************
	void Delete(int data)
	{
		node *temp = new node;
		node *q = new node;
		temp = start;

		if (temp == NULL)
			cout << "Empty List....\n\n";

		//first one node
		 if (temp->info==data)
		{
			start = start->next;
			start->prev = NULL;
			free( temp);
			cout << "Hello";
		}

		 //between node delete
		 else if( temp->info != data)
		 {
			 while (temp->next != NULL)
			 {
				 if (data == temp->info)
					 break;
				 temp = temp->next;
			 }
			 temp->prev->next = temp->next->next;
			 temp->next->prev = temp->prev->next;
			 //delete temp;
			 free(temp);
			 cout << "Deleted...\n\n";

		 }
		 else
		 {

			 q = start;
			 while (q->next != NULL)
			 {
				 q = q->next;
			 }
			 ////last Node deletetion
			 if (data == q->info)
			 {
				 q->prev->next = NULL;
				 free(q);
				 cout << "Deleted last...\n\n";
			 }

		 }


		
	}


	//*********reverse*****
	
	void Reverse()
	{
		node *p = new node;
		p = start;
		while (p->next != NULL)
		{
			p = p->next;
		}
	
		
		/*do{
			
			cout << q->info<<"--R--";
			q = q->prev;
		} 
		while (q != NULL);*/
		int c = 0;
		for (p; p != NULL; p = p->prev)
		{
			cout << p->info; 
			cout<< "- ";
		}
		cout << "NULL";
	}
};
int _tmain(int argc, _TCHAR* argv[])
{
	Double_List dl;
	//dl.Display();
	dl.Create(15);
	dl.Create(12);
	dl.Create(16);
	dl.Create(17);
	dl.Create(160);
	dl.Create(168);
	dl.Display();
	//dl.sort();
	//dl.Delete(168);
	cout << "\n\nAfter Deletetion\n\n";
	dl.Display();
	dl.Reverse();
	cout << "\nSimple display Method\n";
	dl.AddAtBegining(2);
	dl.Create(1023);
	dl.Display();
	//system(GREEN, bb);
	dl.FindMax();
	dl.Display();
	return 0;
}

