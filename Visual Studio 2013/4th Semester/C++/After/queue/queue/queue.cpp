// queue.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

class Node
{
	int data;
	Node *next;
public:
	void SetData(int a)

	{
		data = a;
	}
	void SetNext(Node  *next){
		this->next = next;
	}
	int GetData(){
		return data;
	}
	Node* GetNext()
	{
		return next;
	}
};



class LinkedQueue
{
private:
	Node* Front;
	Node * Rear;
public:
	LinkedQueue()
	{
		Front = NULL;
		Rear = NULL;
	}
	bool IsEmpty(){
		if (Front == NULL)
			return true;
		else 
			return false;
	}

	void Enqueue(int data)
	{
		Node* newNode = new Node();
		newNode->SetData(data);
		newNode->SetNext(NULL);
		if (IsEmpty() == true){
			Front = newNode;
		}
		else
			Rear->SetNext(newNode);
		Rear = newNode;
			
	}


	void Dequqe(){
		Node* temp = Front;
		Front = Front->GetNext();
		delete temp;
	}

	int GetFront()
	{
		return Front->GetData();
	}

	void PrintQueue()
	{
		Node* temp = Front;
		if (IsEmpty() == true)
		{
			cout << "The queue is Empty!\n\n";
			
		}
		else
		{
			while (temp!=NULL)
			{
				cout << temp->GetData();
				cout << "-->";
				temp = temp->GetNext();
			}
			cout << "NULL\n\n";
		}
	}

};

int _tmain(int argc, _TCHAR* argv[])
{
	LinkedQueue q;
	q.Enqueue(1);
	q.Enqueue(2);
	q.Enqueue(3);
	q.Enqueue(4);
	q.Enqueue(5);
	q.Dequqe();
	q.PrintQueue();
	return 0;
}

