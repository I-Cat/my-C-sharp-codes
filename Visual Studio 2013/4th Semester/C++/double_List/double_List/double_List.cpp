// DoubleLinkListPractice.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class node
{
private:
	int info;
	node *next;
	node *prev;
public:
	void SetData(int data)
	{
		info = data;
	}

   int GetData()
	{
		return info;
	}

  void SetNext(node *Next)
   {
	   next = Next;
   }
  node* GetNext()
  {
	return next;
  }
  void SetPrev(node *pre)
  {
	  prev = pre;
  }
  node* Getprev()
  {
	  return prev;
  }
};


class Double_List
{
private:
	node *start;
public:
	Double_List()
	{
		start = NULL;
	}
	void Create(int value)
	{
		node *s, *temp;
		temp = new node();
		temp->SetData(value);
		temp->SetNext( NULL);

		if (start == NULL)
		{
			temp->SetPrev(NULL);
			start = temp;
		}
		else
		{
			s = start;
			while (s->GetNext() != NULL)
			{
				s = s->GetNext();
			}
			s->SetNext(temp);
			temp->SetPrev(s);
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
				cout << temp->GetData() << " <-> ";
				temp = temp->GetNext();
			} while (temp != NULL);
		}
		cout << "Null\n\n";
	}

	void sort()
	{
		node *temp = new node();
		node *ptr = new node;
		temp = start;
		int value;
		value = temp->GetData();

		while (temp->GetNext() != NULL)
		{
			for (ptr = temp; ptr != NULL; ptr = ptr->GetNext())
			{
				if (value > ptr->GetData())
				{
					value = ptr->GetData();
					ptr->SetData(temp->GetData());
					temp->SetData(value);
				}

			}
			temp = temp->GetNext();
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
		temp->SetPrev(NULL);
		temp->SetData(data);
		temp->SetNext(start);
		start->SetPrev(temp);
		start = temp;


	}

	//************************************************max*******
	void FindMax()
	{
		node *ptr = new node;
		node *temp = new node;
		temp = start;
		int value = temp->GetData();
		for (ptr = temp->GetNext(); ptr != NULL; ptr = ptr->GetNext())
		{
			if (ptr->GetData() > temp->GetData())
			{
				value = ptr->GetData();
				ptr->SetData(temp->GetData());
				temp->SetData(value);
			}

		}

		cout << "\n\n\t\tmax = " << value << "\n\n";
	}
	//***********************delete**************************
	void Delete(int data)
	{
		node *temp = new node;
		node *q = new node;
		temp = start;

		if (temp == NULL)
			cout << "Empty List....\n\n";



		//for last node

		//only one node
		if (temp->GetData() == data)
		{

			start = temp->GetNext();
			start->SetPrev(NULL);
			delete temp;
		}

		q = start;
		while (q->GetNext() != NULL)
		{
			q = q->GetNext();
		}
		////last Node deletetion
		if (data == q->GetData())
		{
			q->Getprev()->SetNext(NULL);
			free(q);
			cout << "Deleted last...\n\n";
		}

		//between node delete
		else
		{
			while (temp->GetNext() != NULL)
			{
				if (data == temp->GetData())
					break;
				temp = temp->GetNext();
			}
			temp->Getprev()->SetNext(temp->GetNext());
			temp->GetNext()->SetPrev(temp->Getprev()->GetNext());
			delete temp;
			//free(temp);
			cout << "Deleted...\n\n";

		}



	}


	//*********reverse*****

	void Reverse()
	{
		node *p = new node;
		p = start;
		while (p->GetNext() != NULL)
		{
			p = p->GetNext();
		}


		/*do{

		cout << q->info<<"--R--";
		q = q->prev;
		}
		while (q != NULL);*/
		int c = 0;
		for (p; p != NULL; p = p->Getprev())
		{
			cout << p->GetData();
			cout << "- ";
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
	dl.Display();
	//dl.sort();
	dl.Delete(160);
	cout << "After Delete Call\n";
	dl.Display();

	dl.Reverse();
	cout << "\nSimple display Method\n";
	dl.AddAtBegining(2);
	dl.Create(1023);
	dl.Display();
	//system(GREEN, bb);
	dl.FindMax();
	return 0;
}

