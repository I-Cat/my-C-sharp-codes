// Link_List.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
using namespace std;

class Node
{
private:
	int data;
	Node *Next;
public:
	Node()
	{

	}

	int GetData()
	{
		return data;
	}

	void SetData(int a)
	{
		data = a;
	}

	Node* GetNext()
	{
		return Next;
	}

	void SetNext(Node* Next)
	{
		this->Next = Next;
	}
};

class List{
	//private:
	//	Node *first;
	//	Node *last;
	//public:
	//
	//		List()
	//	{
	//		first = last = NULL;
	//	}
	//
	//		void InsertDataAtEnd(int number)
	//		{
	//			Node *temp = new Node;
	//			temp->data = number;
	//			if (first == NULL)
	//				first = last = NULL;
	//			else{
	//				last->Next = temp;
	//				last = temp;
	//			}
	//		}
	//
	//
	//		void Traverse()
	//		{
	//			Node *current = first;
	//			while (current != NULL)
	//			{
	//				cout << current->data << "------>";
	//				current = current->Next;
	//			}
	//		}

private:
	Node *CurrentLocation;
public:
	List()
	{
		CurrentLocation = NULL;
	}

	void Insert(int data)
	{
		Node* newNode = new Node();
		newNode->SetData(data);
		newNode->SetNext(NULL);

		// Create a temp pointer
		Node *tempNode = CurrentLocation;

		if (tempNode != NULL) {
			// Nodes already present in the list
			// Parse to end of list
			while (tempNode->GetNext() != NULL) {
				tempNode = tempNode->GetNext();
			}
			// Point the last node to the new Node
			tempNode->SetNext(newNode);
		}
		else {
			// First node in the list
			CurrentLocation = newNode;
		}
	}//End of Insert

	void Print()
	{
		Node *tempNode = CurrentLocation;

		if (tempNode == NULL){
			cout << "List is Empty" << endl;
		}
		//only one node in the list
		else if (tempNode->GetNext() == NULL)
		{
			cout << tempNode->GetData();
			cout << "-->";
			cout << "Null" << endl;

		}
		else {
			do {
				cout << tempNode->GetData();
				cout << " --> ";
				tempNode = tempNode->GetNext();
			} while (tempNode != NULL);

			cout << "NULL" << endl;
		}

	}

	void Delete(int data)
	{
		// Create a temp pointer
		Node *tempNode = CurrentLocation;

		// Case1: No nodes
		if (tempNode == NULL)
			return;

		// Case2: Last node of the list
		if (tempNode->GetNext() == NULL)
		{
			delete tempNode;
			CurrentLocation = NULL;
		}
		//Case3: More than one Node

		else {
			Node *previous = NULL;

			// Parse through the nodes
			do {
				if (tempNode->GetData() == data)
				{
					break;
				}
				previous = tempNode;
				tempNode = tempNode->GetNext();

			} while (tempNode != NULL);


			// Adjust the pointers
			previous->SetNext(tempNode->GetNext());

			// Delete the current node
			delete tempNode;
			tempNode = NULL;
		}
		//End of Delete

	}
	void Max()
	{
		Node *p, *s; int value;
		p = CurrentLocation;
		for (s = p->GetNext(); s->GetNext() != NULL; s = s->GetNext())
		{
			if (p->GetData() < s->GetData())
			{
				value = p->GetData();
				p->SetData(s->GetData());
				s->SetData(value);
			}
		}
		cout << p->GetData();
	}
	void Sort()
	{
		//Node *temp = new Node();

		/*temp = CurrentLocation;
		int value;
		Node *p = new Node;
		p->SetNext(temp->GetNext());

		while (p->GetNext() != NULL)
		{
		while (p!=NULL)
		{
		if (temp->GetData() > p->GetData())
		{
		int n = temp->GetData();
		temp->SetData(p->GetData());
		p->SetData(n);
		}
		p = p->GetNext();
		}
		}
		*/

		Node *ptr, *s;
		int value = 0;
		if (CurrentLocation == NULL)

		{
			cout << "List is empty";
			return;
		}
		ptr = CurrentLocation;
		while (ptr->GetNext() != NULL)
		{
			for (s = ptr->GetNext(); s->GetNext() != NULL; s = s->GetNext())
			{
				if (ptr->GetData() > s->GetData())
				{
					value = ptr->GetData();
					ptr->SetData(s->GetData());
					s->SetData(value);
				}
			}
			ptr = ptr->GetNext();
		}

	}

};

//list Class Methods


int _tmain(int argc, _TCHAR* argv[])
{
	List li;
	li.Insert(5);;
	li.Insert(4);;
	li.Insert(3);
	li.Insert(2);
	li.Insert(9);
	li.Insert(8);
	li.Insert(15);

	li.Print();
	//li.Delete(45);
	cout << "Deleted 45..." << endl;
	li.Print();

	cout << "After Sorting..." << endl;
	//li.Sort();
	li.Print();


	li.Max();

}

