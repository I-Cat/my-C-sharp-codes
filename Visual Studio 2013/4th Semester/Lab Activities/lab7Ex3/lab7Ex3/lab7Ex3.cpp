// lab7Ex3.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

const int QUEUE_SIZE = 100;
/*
class QueueArray
{
private:
	int Queue[QUEUE_SIZE];
	int Front;
	int Rare;

public:
	QueueArray();
	void Enqueue(int);
	int Size();
	void Dequeue();
	bool IsFull();
	bool IsEmpty();
	int GetFront();
	void PrintQueue();
};
QueueArray::QueueArray()
{
	Front = -1;
	Rare = -1;
}
int QueueArray::Size()
{
	return (Rare + 1);
}
bool QueueArray::IsEmpty()
{
	if (Front == -1)
		return true;

	else
		return false;
}
bool QueueArray::IsFull()
{
	if (Rare == QUEUE_SIZE - 1)
		return true;

	else
		return false;
}
void QueueArray::Enqueue(int item)
{
	if (IsFull() == true)
	{
		cout << "Can't Insert because the 				Queue is Full!\n\n";
	}
	else
	{
		Queue[++Rare] = item;
		if (Front == -1) Front++;
	}
}
void QueueArray::Dequeue()
{
	if (IsEmpty() == true)
	{
		cout << "Can't Delete because the Queue is 				Empty!\n\n";
	}
	else
		if (Front == Rare)
			Front--;
	Queue[Front++];
}



void QueueArray::PrintQueue()
{
	if (IsEmpty() == true)
	{
		cout << "The Queue is Empty!\n\n";
	}
	else
	{
		for (int i = Front; i <= Rare; i++)
		{
			cout << Queue[i] << endl;
		}
	}
}

*/

//**********Implementation using LinkedList
class Node
{
private:
	int data;
	Node *next;
public:
	void SetData(int a)
	{
		data = a;
	}
	void SetNext(Node * next)
	{
		this->next = next;
	}
	int GetData()
	{
		return data;
	}
	Node * GetNext()
	{
		return next;
	}
};
class LinkedQueue
{
private:
	Node* Front;
	Node* Rear;

public:
	LinkedQueue();
	void Enqueue(int);
	void Dequeue();
	void PrintQueue();
	bool IsEmpty();
	int GetFront();
};
LinkedQueue::LinkedQueue()
{
	Front = NULL;
	Rear = NULL;
}
bool LinkedQueue::IsEmpty()
{
	if (Front == NULL)
		return true;

	else
		return false;
}
void LinkedQueue::Enqueue(int data)
{
	Node* newNode = new Node();
	newNode->SetData(data);
	newNode->SetNext(NULL);

	//If Queue is Empty
	if (IsEmpty() == true)
	{
		Front = newNode;
	}
	else
		Rear->SetNext(newNode);
	Rear = newNode;
}
void LinkedQueue::Dequeue()
{
	Node* temp = Front;

	Front = Front->GetNext();
	delete temp;
}
int LinkedQueue::GetFront()
{
	return Front->GetData();
}

void LinkedQueue::PrintQueue()
{
	Node* temp = Front;

	if (IsEmpty() == true)
	{
		cout << "The Queue is Empty!\n\n";
		return;
	}
	else
	{
		while (temp != NULL)
		{
			cout << temp->GetData();
			cout << " --> ";
			temp = temp->GetNext();
		}

		cout << "NULL\n\n";
	}
}

int main()

{
	/*QueueArray *obj = new QueueArray();
	obj->Enqueue(4);
	obj->Enqueue(3);
	obj->Enqueue(2);
	obj->Enqueue(1);

	obj->Dequeue();
	obj->PrintQueue();*/

	//Linked Queue
	LinkedQueue lq;
	lq.Enqueue(13);
	lq.Enqueue(11);
	lq.Enqueue(11);
	lq.PrintQueue();




}
